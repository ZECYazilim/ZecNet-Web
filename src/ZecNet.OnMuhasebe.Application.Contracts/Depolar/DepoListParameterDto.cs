﻿using System;
using Volo.Abp.Application.Dtos;
using ZecNet.OnMuhasebe.CommonDtos;

namespace ZecNet.OnMuhasebe.Depolar;
public class DepoListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}