﻿namespace ZecNet.OnMuhasebe.Parametreler;
public class FirmaParametre:Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public Guid? DepoId { get; set; }
}