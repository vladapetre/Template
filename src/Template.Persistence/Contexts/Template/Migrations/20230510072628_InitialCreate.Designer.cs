﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Template.Persistence.Contexts.Template;

#nullable disable

namespace Template.Persistence.Contexts.Template.Migrations
{
    [DbContext(typeof(TemplateContext))]
    [Migration("20230510072628_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("template")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Template.Domain.Models.Example.ExampleAggregateRoot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Example", "template");
                });

            modelBuilder.Entity("Template.Domain.Models.Example.ExampleAggregateRoot", b =>
                {
                    b.OwnsOne("Template.Domain.Models.Example.ExampleDescription", "Description", b1 =>
                        {
                            b1.Property<int>("ExampleAggregateRootId")
                                .HasColumnType("int");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Version")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ExampleAggregateRootId");

                            b1.ToTable("ExampleDescription", "template");

                            b1.WithOwner()
                                .HasForeignKey("ExampleAggregateRootId");
                        });

                    b.Navigation("Description")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}