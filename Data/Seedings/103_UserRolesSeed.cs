using FluentMigrator;
using HomeRecipes.Migrations.Migrations;

namespace HomeRecipes.Migrations.Seedings
{
    [Migration(103)]
    public class _103_UserRolesSeed : Migration
    {
        public override void Down()
        {

        }

        public override void Up()
        {
            Insert.IntoTable(TableName.UserRoles)
                .Row(new
                {
                    user_id = "3d50a2e1-b8da-4616-a295-911798894905",
                    role_id = "5510db9e-2173-46cf-a5b2-6683d3f97ffd",
                    is_active = true
                });
            Insert.IntoTable(TableName.UserRoles)
                .Row(new
                {
                    user_id = "deb81ad5-e200-4acf-af11-96691522e944",
                    role_id = "5510db9e-2173-46cf-a5b2-6683d3f97ffd",
                    is_active = true
                });
            Insert.IntoTable(TableName.UserRoles)
                .Row(new
                {
                    user_id = "695b29cd-007b-4998-8b83-b63578d8f473",
                    role_id = "5510db9e-2173-46cf-a5b2-6683d3f97ffd",
                    is_active = true
                });
            Insert.IntoTable(TableName.UserRoles)
                .Row(new
                {
                    user_id = "6ad70b13-dfbd-4293-b1cb-60f046096068",
                    role_id = "a0798c89-aa12-455b-8998-b7032dac2fb1",
                    is_active = true
                });
            Insert.IntoTable(TableName.UserRoles)
                .Row(new
                {
                    user_id = "6ad70b13-dfbd-4293-b1cb-60f046096068",
                    role_id = "5510db9e-2173-46cf-a5b2-6683d3f97ffd",
                    is_active = true
                });
        }
    }
}
