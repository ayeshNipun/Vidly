namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'31aafa65-8f02-4e6d-b6e6-e44e6455d7c2', N'admin@vidly.com', 0, N'ANfoA/MMKZyqxnMngGz/QUzLwrQrVOWxQ0ANsD9PudgLZRzLla8yRl3oNhDgipuBcQ==', N'894d6ad6-0050-4f4b-b58d-039c1bdddca4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'424610e9-f07d-46ab-bd7c-03cf7fd757f3', N'guest@vidly.com', 0, N'AIeiPNTgJkvtoYFZ3797YLsruZtN52ocCmNmIc19bCz3kR/gLG9WLr0x+etOiSedvQ==', N'4d37ba72-1805-4856-a903-ea207f239c06', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6febe28a-b6f3-4b5f-a75d-b0aea75fa067', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'31aafa65-8f02-4e6d-b6e6-e44e6455d7c2', N'6febe28a-b6f3-4b5f-a75d-b0aea75fa067')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
