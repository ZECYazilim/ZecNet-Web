﻿using System;
using Volo.Abp.Application.Dtos;

namespace ZecNet.OnMuhasebe.Donemler;
public class ListDonemDto:EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
}