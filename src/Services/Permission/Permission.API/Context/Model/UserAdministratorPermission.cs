using System;

namespace EMS.Permission_Services.API.Context.Model
{
    public class UserAdministratorPermission
    {
        public Guid UserId { get; set; }
        public UserPermission UserPermission { get; set; }
        public Guid ClubId { get; set; }
        public ClubAdministratorPermission ClubAdministratorPermission { get; set; }
    }
}