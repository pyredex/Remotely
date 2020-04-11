﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Remotely.Shared.Models
{
    public class RemotelyUser : IdentityUser
    {
        public RemotelyUser()
        {
            UserOptions = new RemotelyUserOptions();
            Organization = new Organization();
        }

        public ICollection<Alert> Alerts { get; set; }
        public bool IsAdministrator { get; set; } = true;
        public bool IsServerAdmin { get; set; }
        [JsonIgnore]
        public Organization Organization { get; set; }

        public string OrganizationID { get; set; }
        public List<UserDevicePermission> PermissionLinks { get; set; }
        public RemotelyUserOptions UserOptions { get; set; }
    }
}
