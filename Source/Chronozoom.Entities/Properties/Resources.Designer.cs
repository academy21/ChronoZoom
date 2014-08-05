﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chronozoom.Entities.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Chronozoom.Entities.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- WARNING: best guess on constraint name   -- TODO: confirm name by looking at older copy of db
        ///ALTER TABLE [References] DROP CONSTRAINT [FK_dbo.References_dbo.Exhibits_Exhibit_Id];
        ///GO
        ///
        ///-- WARNING: best guess on index name        -- TODO: confirm name by looking at older copy of db
        ///DROP INDEX [IX_Exhibit_Id] ON [dbo].[References];
        ///GO
        ///
        ///ALTER TABLE [Timelines]         DROP COLUMN [Threshold], [UniqueId], [Sequence];
        ///ALTER TABLE [Exhibits]          DROP COLUMN [Threshold], [Regime], [UniqueId], [Sequ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _201305102053361_RemoveBetaFields {
            get {
                return ResourceManager.GetString("_201305102053361_RemoveBetaFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP TABLE [Bitmasks];
        ///GO
        ///
        ///INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201305102115428_RemoveRITree&apos;, &apos;Manual Migration&apos;);
        ///GO.
        /// </summary>
        internal static string _201305102115428_RemoveRITree {
            get {
                return ResourceManager.GetString("_201305102115428_RemoveRITree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[Bitmasks]
        ///(
        ///	[Id]                [int] IDENTITY(1,1)     NOT NULL,
        ///	[B1]                [bigint]                NOT NULL,
        ///	[B2]                [bigint]                NOT NULL,
        ///	[B3]                [bigint]                NOT NULL,
        ///    CONSTRAINT [PK_dbo.Bitmasks] PRIMARY KEY CLUSTERED 
        ///    (
        ///	    [Id] ASC
        ///    )
        ///)
        ///GO
        ///
        ///INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201305102117597_AddRITreeWithIndex&apos;, &apos;Manual Migration&apos;);
        ///GO.
        /// </summary>
        internal static string _201305102117597_AddRITreeWithIndex {
            get {
                return ResourceManager.GetString("_201305102117597_AddRITreeWithIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201305240425388_ChangeTours&apos;, &apos;Manual Migration&apos;);
        ///GO.
        /// </summary>
        internal static string _201305240425388_ChangeTours {
            get {
                return ResourceManager.GetString("_201305240425388_ChangeTours", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [Timelines]     ALTER COLUMN [Title] NVARCHAR(200);
        ///ALTER TABLE [Exhibits]      ALTER COLUMN [Title] NVARCHAR(200);
        ///ALTER TABLE [ContentItems]  ALTER COLUMN [Title] NVARCHAR(200);
        ///GO
        ///
        ///INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201305282325585_TitleLength&apos;, &apos;Manual Migration&apos;);
        ///GO.
        /// </summary>
        internal static string _201305282325585_TitleLength {
            get {
                return ResourceManager.GetString("_201305282325585_TitleLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [Tours] ALTER COLUMN [Description] NVARCHAR(4000);
        ///GO
        ///
        ///INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201306040017265_ToursDescription&apos;, &apos;Manual Migration&apos;);
        ///GO.
        /// </summary>
        internal static string _201306040017265_ToursDescription {
            get {
                return ResourceManager.GetString("_201306040017265_ToursDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        /// * NOTE: This SQL is only run if the following is true in C#, which it seems is never the case due to the question mark.
        /// * if (System.Configuration.ConfigurationManager.ConnectionStrings[&quot;Storage&quot;].ProviderName.Equals(&quot;System.Data.?SqlClient&quot;))
        /// * Since this is conditional, the SQL to add an entry to __MigrationHistory is not contained herein and should be run separately.
        /// */
        ///
        ///IF EXISTS (SELECT object_id FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;TimelineSubtreeQuery&apos;) AND type in (N&apos;P&apos;, N&apos;PC&apos; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _201306050753190_ProgressiveLoad {
            get {
                return ResourceManager.GetString("_201306050753190_ProgressiveLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201306072040327_ToursUserMissingMaxLen&apos;, &apos;Manual Migration&apos;);
        ///GO
        ///.
        /// </summary>
        internal static string _201306072040327_ToursUserMissingMaxLen {
            get {
                return ResourceManager.GetString("_201306072040327_ToursUserMissingMaxLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [Timelines]     ALTER COLUMN [FromYear] NUMERIC(18, 7);
        ///ALTER TABLE [Timelines]     ALTER COLUMN [ToYear]   NUMERIC(18, 7);
        ///ALTER TABLE [ContentItems]  ALTER COLUMN [Year]     NUMERIC(18, 7);
        ///ALTER TABLE [Exhibits]      ALTER COLUMN [Year]     NUMERIC(18, 7);
        ///GO
        ///
        ///INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201306210425512_IncreaseYearPrecision&apos;, &apos;Manual Migration&apos;);
        ///GO
        ///.
        /// </summary>
        internal static string _201306210425512_IncreaseYearPrecision {
            get {
                return ResourceManager.GetString("_201306210425512_IncreaseYearPrecision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE [Timelines] DROP COLUMN [FirstNodeInSubtree], [Predecessor], [Successor];
        ///GO
        ///
        ///INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201306210557399_RemoveBFSCachedFields&apos;, &apos;Manual Migration&apos;);
        ///GO
        ///.
        /// </summary>
        internal static string _201306210557399_RemoveBFSCachedFields {
            get {
                return ResourceManager.GetString("_201306210557399_RemoveBFSCachedFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- remove users.collection_id (appears to be an existing entity change that previously wasn&apos;t db migrated) --
        ///
        ///IF EXISTS
        ///(
        ///    SELECT (1) FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE WITH (NOLOCK)
        ///    WHERE CONSTRAINT_NAME = &apos;FK_dbo.Users_dbo.Collections_Collection_Id&apos;
        ///)
        ///BEGIN
        ///    ALTER TABLE [Users] DROP CONSTRAINT [FK_dbo.Users_dbo.Collections_Collection_Id];
        ///    DROP INDEX [IX_Collection_Id] ON [dbo].[Users];
        ///    ALTER TABLE [Users] DROP COLUMN [Collection_Id];
        ///END
        ///GO
        ///
        ///-- add new schema  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _201406020351501_MultipleEditors {
            get {
                return ResourceManager.GetString("_201406020351501_MultipleEditors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- add PubliclySearchable field to Collections table
        ///
        ///ALTER TABLE [Collections] ADD [PubliclySearchable] BIT NOT NULL DEFAULT (0);
        ///GO
        ///
        ///
        ///-- note transformation completed --
        ///
        ///INSERT INTO [MigrationHistory] (MigrationId, ProductVersion)
        ///VALUES
        ///    (&apos;201408040000000_PubliclySearchable&apos;, &apos;Manual Migration&apos;);
        ///GO
        ///.
        /// </summary>
        internal static string _201408040000000_PubliclySearchable {
            get {
                return ResourceManager.GetString("_201408040000000_PubliclySearchable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Users --
        ///
        ///CREATE TABLE [dbo].[Users]
        ///(
        ///	[Id]                [uniqueidentifier]      NOT NULL,
        ///	[DisplayName]       [nvarchar](4000)        NULL,
        ///	[Email]             [nvarchar](4000)        NULL,
        ///	[NameIdentifier]    [nvarchar](4000)        NULL,
        ///	[IdentityProvider]  [nvarchar](4000)        NULL,
        ///    CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED
        ///    (
        ///        [Id] ASC
        ///    )
        ///)
        ///GO
        ///
        ///
        ///-- Bitmasks --
        ///
        ///CREATE TABLE [dbo].[Bitmasks]
        ///(
        ///	[Id]                [int] IDENTITY(1,1)     NOT NULL, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateEntireSchema {
            get {
                return ResourceManager.GetString("CreateEntireSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///    It is important to rename the __MigrationHistory table to prevent
        ///    Entity Framework from performing a schema version check.
        ///    
        ///    EXEC sp_rename &apos;__MigrationHistory&apos;, &apos;MigrationHistory&apos; does not work if table was previously
        ///    marked as a system table using sp_MS_marksystemobject. So, we will create a new table from scratch,
        ///    move the data from the old table to the new table, then delete the old table.
        ///    
        ///    Note that we don&apos;t use sp_MS_marksystemobject as this is not supported i [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RenameMigrationHistory {
            get {
                return ResourceManager.GetString("RenameMigrationHistory", resourceCulture);
            }
        }
    }
}