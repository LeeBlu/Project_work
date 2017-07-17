namespace DataLayer_2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer_2.ContextFolder.TableContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayer_2.ContextFolder.TableContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.countries.AddOrUpdate(
new Model.Country { CountryName = "South Africa" });
            Model.Country c = new Model.Country();
            c.CountryName = "South Africa";
            c.CountryID = 1;

            context.provincies.AddOrUpdate(
                new Model.Province { ProvinceName = "Gauteng", country = c },
                new Model.Province { ProvinceName = "Eastern Cape", country = c },
                new Model.Province { ProvinceName = "Free State", country = c },
                new Model.Province { ProvinceName = "KwaZulu-Natal", country = c },
                new Model.Province { ProvinceName = "Limpopo", country = c },
                new Model.Province { ProvinceName = "Mpumalanga", country = c },
                new Model.Province { ProvinceName = "Northern Cape", country = c },
                new Model.Province { ProvinceName = "North West", country = c });

            Model.Town t1 = new Model.Town { TownName = "Joburg", ProvinceID = 1 };

            context.towns.AddOrUpdate(t1);
            
            context.surbubs.AddOrUpdate(
                new Model.Surbub {SuburbName="Hyde Park" ,town = t1}
                );


            context.Genders.AddOrUpdate(
                new Model.Gender { GenderDescription = "Male" },
                new Model.Gender { GenderDescription = "Female" });

            context.addresstypes.AddOrUpdate(
                new Model.AddressType { AddressTypeDecs = "Postal Code" },
                new Model.AddressType { AddressTypeDecs = "Physical" });

            context.statuses.AddOrUpdate(
                new Model.Status { StatusDesc = "Active" },
                new Model.Status { StatusDesc = "UnActive" });

            context.Usertypes.AddOrUpdate(
                new Model.UserType { UserDescribtion = "ADMIN" },
                new Model.UserType { UserDescribtion = "User" });

            context.departments.AddOrUpdate(
                new Model.Department { DepartmentName = "GMIC", DepartmentDescrption = "Gauteng Microsoft," },
                new Model.Department { DepartmentName = "GMOB", DepartmentDescrption = "Gauteng Mobility" });
        }
    }
}
