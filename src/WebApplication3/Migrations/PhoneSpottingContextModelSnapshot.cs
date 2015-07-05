using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using WebApplication3.Models;

namespace WebApplication3.Migrations
{
    [ContextType(typeof(PhoneSpottingContext))]
    partial class PhoneSpottingContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("WebApplication3.Models.PhoneSpotting", b =>
                    {
                        b.Property<int>("Latitude")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Longitude")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Notes")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<string>("PhoneManufacturer")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("PhoneModel")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<int>("PhoneSpottingId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 5)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<DateTime>("SpotTime")
                            .Annotation("OriginalValueIndex", 6);
                        b.Key("PhoneSpottingId");
                    });
                
                return builder.Model;
            }
        }
    }
}
