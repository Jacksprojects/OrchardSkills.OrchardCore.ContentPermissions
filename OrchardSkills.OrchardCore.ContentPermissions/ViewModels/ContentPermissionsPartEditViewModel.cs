﻿using OrchardSkills.OrchardCore.ContentPermissions.Models;

namespace OrchardSkills.OrchardCore.ContentPermissions.ViewModels
{
    public class ContentPermissionsPartEditViewModel
    {
        public ContentPermissionsPart ContentPermissionsPart { get; set; }

        public bool Enabled { get; set; }

        public string[] PossibleRoles { get; set; }

        public string[] Roles { get; set; }
    }
}