﻿// <auto-generated />
namespace MyCompanyName.AbpZeroTemplate.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations.Infrastructure;

    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class Added_Chat_And_Friendship_Entities : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201606150821191_Added_Chat_And_Friendship_Entities"; }
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