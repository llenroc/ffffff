﻿// <auto-generated />
namespace MyCompanyName.AbpZeroTemplate.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations.Infrastructure;

    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class Added_AuditLog_To_AbpZero : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201503252020192_Added_AuditLog_To_AbpZero"; }
        }

        string IMigrationMetadata.Source
        {
            get { return null; }
        }

        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}