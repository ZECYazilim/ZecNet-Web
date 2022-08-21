using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Bankalar;
public class BankaAppService : OnMuhasebeAppService, IBankaAppService
{
    private readonly IBankaRepository _bankaRepository;
    private readonly BankaManager _bankaManager;

    public BankaAppService(IBankaRepository bankaRepository, BankaManager bankaManager)
    {
        _bankaRepository = bankaRepository;
        _bankaManager = bankaManager;
    }
    public virtual async Task<SelectBankaDto> GetAsync(Guid id)
    {
        var entity = await _bankaRepository.GetAsync(id,b=>b.Id==id,b=>b.OzelKod1,b=>b.OzelKod2);
        return ObjectMapper.Map<Banka, SelectBankaDto>(entity);
    }
    public virtual async Task<PagedResultDto<ListBankaDto>> GetListAsync(BankaListParameterDto input)
    {
        var entities = await _bankaRepository.GetPagedListAsync(input.SkipCount, input.MaxResultCount,
            b => b.Durum == input.Durum,//predicate
            b => b.Kod,
            b=>b.OzelKod1,//include properties
            b=>b.OzelKod2);//orderby

        var totalCount = await _bankaRepository.CountAsync(b => b.Durum == input.Durum);

        return new PagedResultDto<ListBankaDto>(
            totalCount,
            ObjectMapper.Map <List<Banka>, List < ListBankaDto >> (entities)
            );
    }
    public virtual async Task<SelectBankaDto> CreateAsync(CreateBankaDto input)
    {
        await _bankaManager.CheckCreateAsync(input.Kod, input.OzelKod1Id, input.OzelKod2Id);

        var entity = ObjectMapper.Map<CreateBankaDto, Banka>(input);
        await _bankaRepository.InsertAsync(entity);
        return ObjectMapper.Map<Banka, SelectBankaDto>(entity);
    }
    public virtual async Task<SelectBankaDto> UpdateAsync(Guid id, UpdateBankaDto input)
    {
        var entity = await _bankaRepository.GetAsync(id, b=>b.Id==id);

        await _bankaManager.CheckUpdateAsync(id, input.Kod, entity, input.OzelKod1Id, input.OzelKod2Id);

        var mappedEntity = ObjectMapper.Map(input,entity);
        await _bankaRepository.UpdateAsync(mappedEntity);

        return ObjectMapper.Map<Banka, SelectBankaDto>(mappedEntity);
    }
    public virtual async Task DeleteAsync(Guid id)
    {
        await _bankaManager.CheckDeleteAsync(id);

        await _bankaRepository.DeleteAsync(id);
    }
    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _bankaRepository.GetCodeAsync(b => b.Kod, b => b.Durum == input.Durum);
    }   
}