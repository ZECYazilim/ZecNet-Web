using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using ZecNet.OnMuhasebe.Extensions;

namespace ZecNet.OnMuhasebe.Birimler;
public class BirimManager : DomainService
//Fluent Validation
{
    #region Variables
    private readonly IBirimRepository _birimRepository;
    private readonly IOzelKodRepository _ozelKodRepository;
    #endregion
    public BirimManager(IBirimRepository birimRepository, IOzelKodRepository ozelKodRepository)
    {
        _birimRepository = birimRepository;
        _ozelKodRepository = ozelKodRepository;
    }
    public async Task CheckCreateAsync(string kod, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _birimRepository.CodeAnyAsync(kod, x => x.Kod == kod);

        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1, KartTuru.Birim);
        
        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2, KartTuru.Birim);
    }
    public async Task CheckUpdateAsync(Guid id, string kod, Birim entity, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _birimRepository.CodeAnyAsync(kod, x => x.Id != id && x.Kod == kod
        , entity.Kod != kod);

        await _ozelKodRepository.EntityAnyAsync
            (ozelKod1Id, OzelKodTuru.OzelKod1, KartTuru.Birim, entity.OzelKod1Id != ozelKod1Id);

        await _ozelKodRepository.EntityAnyAsync
            (ozelKod2Id, OzelKodTuru.OzelKod2, KartTuru.Birim, entity.OzelKod2Id != ozelKod2Id);
    }
    public async Task CheckDeleteAsync(Guid id)
    {
        await _birimRepository.RelationtalEntityAnyAsync
            (
            x => x.Hizmetler.Any(z => z.BirimId == id) ||
               x.Masraflar.Any(z => z.BirimId == id ||
               x.Stoklar.Any(z => z.BirimId == id)
            ));
    }
}