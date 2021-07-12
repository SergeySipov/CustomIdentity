﻿namespace CustomIdentity.DAL.Entities
{
    public class RoleClaim
    {
        public int UserClaimId { get; set; }
        public ClaimEntity UserClaim  { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
