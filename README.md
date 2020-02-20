# OrchardSkills.OrchardCore.ContentPermissions
Orchard Core Content Permissions

# Usage
Enabled the "Content Permissions" feature, which will make a new "Content Permissions" part available. Attach this part to the desired content types, which will add a new "Security" tab to the content editor. From this tab the content item permissions can be enabled, which will display all the roles in the CMS. Select the roles that can access the content item and publish. Users not associated to one of the specified roles will receive a 403 response and redirected to /Error/403. The redirect URL can be customised within the settings for the content part.