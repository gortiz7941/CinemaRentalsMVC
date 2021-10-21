namespace CinemaRentals2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeRecords : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes" +
                " SET Name = CASE Name" +
                " WHEN Id = 1 THEN 'Pay As You Go'" +
                " WHEN Id = 2 THEN 'Monthly'" +
                " WHEN Id = 3 THEN 'Quarterly'" +
                " WHEN Id = 4 THEN 'Annualy'" +
                " Else null" +
                " END");
        }
        
        public override void Down()
        {
        }
    }
}
