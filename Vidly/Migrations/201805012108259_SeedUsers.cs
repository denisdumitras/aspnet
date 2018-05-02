namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'347796fe-bba2-4bc0-b236-29f53075f361', N'guest@moviegivers.com', 0, N'AJehCB1Slzfy5gVplKql/QiSjMDnTAnVZPlKOtui1+R5FIfGYIQeKoObdNJ4OcXzjA==', N'd8f878ed-191d-474e-86d6-cee46f20d058', NULL, 0, 0, NULL, 1, 0, N'guest@moviegivers.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c42b8ef2-7e99-4a94-84cf-88ebd7e2c5d9', N'admin@moviegivers.com', 0, N'AGm5B9krhpDgRkyDJAokYeVxGYjhdmQHJ4FBaBKzQBOehb5SOWP9q/McSm5h893j2Q==', N'4110923d-f18d-4a57-aede-8fc918bc03a9', NULL, 0, 0, NULL, 1, 0, N'admin@moviegivers.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e8f54e70-ce2e-4379-a5b3-a33f43046396', N'denisdumitras@gmail.com', 0, N'ALDZGY7pNkuNM/qGcxjWuRsfr2cFENaJLoFs7lVjaOtRzb4UUbp8Qgx2723DXpPZAA==', N'faedade9-69dd-45bf-b5db-4f21142ab249', NULL, 0, 0, NULL, 1, 0, N'denisdumitras@gmail.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'41a200e7-6af1-4303-a2b3-d02930c96c7f', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c42b8ef2-7e99-4a94-84cf-88ebd7e2c5d9', N'41a200e7-6af1-4303-a2b3-d02930c96c7f')

");
        }
        
        public override void Down()
        {
        }
    }
}
