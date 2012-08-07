﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Resources
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Globalization;
    using System.Resources;
    using System.Threading;

    /// <summary>
    ///     Strongly-typed and parameterized string resources.
    /// </summary>
    [GeneratedCode("Resources.tt", "1.0.0.0")]
    internal static class Strings
    {
        /// <summary>
        ///     A string like "AutomaticMigration"
        /// </summary>
        internal static string AutomaticMigration
        {
            get { return EntityRes.GetString(EntityRes.AutomaticMigration); }
        }

        /// <summary>
        ///     A string like "BootstrapMigration"
        /// </summary>
        internal static string BootstrapMigration
        {
            get { return EntityRes.GetString(EntityRes.BootstrapMigration); }
        }

        /// <summary>
        ///     A string like "InitialCreate"
        /// </summary>
        internal static string InitialCreate
        {
            get { return EntityRes.GetString(EntityRes.InitialCreate); }
        }

        /// <summary>
        ///     A string like "Automatic migration was not applied because it would result in data loss."
        /// </summary>
        internal static string AutomaticDataLoss
        {
            get { return EntityRes.GetString(EntityRes.AutomaticDataLoss); }
        }

        /// <summary>
        ///     A string like "Applying automatic migration: {0}."
        /// </summary>
        internal static string LoggingAutoMigrate(object p0)
        {
            return EntityRes.GetString(EntityRes.LoggingAutoMigrate, p0);
        }

        /// <summary>
        ///     A string like "Reverting automatic migration: {0}."
        /// </summary>
        internal static string LoggingRevertAutoMigrate(object p0)
        {
            return EntityRes.GetString(EntityRes.LoggingRevertAutoMigrate, p0);
        }

        /// <summary>
        ///     A string like "Applying explicit migration: {0}."
        /// </summary>
        internal static string LoggingApplyMigration(object p0)
        {
            return EntityRes.GetString(EntityRes.LoggingApplyMigration, p0);
        }

        /// <summary>
        ///     A string like "Reverting explicit migration: {0}."
        /// </summary>
        internal static string LoggingRevertMigration(object p0)
        {
            return EntityRes.GetString(EntityRes.LoggingRevertMigration, p0);
        }

        /// <summary>
        ///     A string like "[Inserting migration history record]"
        /// </summary>
        internal static string LoggingHistoryInsert
        {
            get { return EntityRes.GetString(EntityRes.LoggingHistoryInsert); }
        }

        /// <summary>
        ///     A string like "[Deleting migration history record]"
        /// </summary>
        internal static string LoggingHistoryDelete
        {
            get { return EntityRes.GetString(EntityRes.LoggingHistoryDelete); }
        }

        /// <summary>
        ///     A string like "[Updating EdmMetadata model hash]"
        /// </summary>
        internal static string LoggingMetadataUpdate
        {
            get { return EntityRes.GetString(EntityRes.LoggingMetadataUpdate); }
        }

        /// <summary>
        ///     A string like "Running Seed method."
        /// </summary>
        internal static string LoggingSeedingDatabase
        {
            get { return EntityRes.GetString(EntityRes.LoggingSeedingDatabase); }
        }

        /// <summary>
        ///     A string like "Applying explicit migrations: [{1}]."
        /// </summary>
        internal static string LoggingPendingMigrations(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.LoggingPendingMigrations, p0, p1);
        }

        /// <summary>
        ///     A string like "Reverting migrations: [{1}]."
        /// </summary>
        internal static string LoggingPendingMigrationsDown(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.LoggingPendingMigrationsDown, p0, p1);
        }

        /// <summary>
        ///     A string like "No pending explicit migrations."
        /// </summary>
        internal static string LoggingNoExplicitMigrations
        {
            get { return EntityRes.GetString(EntityRes.LoggingNoExplicitMigrations); }
        }

        /// <summary>
        ///     A string like "Target database is already at version {0}."
        /// </summary>
        internal static string LoggingAlreadyAtTarget(object p0)
        {
            return EntityRes.GetString(EntityRes.LoggingAlreadyAtTarget, p0);
        }

        /// <summary>
        ///     A string like "Target database is: {0}."
        /// </summary>
        internal static string LoggingTargetDatabase(object p0)
        {
            return EntityRes.GetString(EntityRes.LoggingTargetDatabase, p0);
        }

        /// <summary>
        ///     A string like "'{1}' (DataSource: {0}, Provider: {2}, Origin: {3})"
        /// </summary>
        internal static string LoggingTargetDatabaseFormat(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.LoggingTargetDatabaseFormat, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "Explicit"
        /// </summary>
        internal static string LoggingExplicit
        {
            get { return EntityRes.GetString(EntityRes.LoggingExplicit); }
        }

        /// <summary>
        ///     A string like "Upgrading history table."
        /// </summary>
        internal static string UpgradingHistoryTable
        {
            get { return EntityRes.GetString(EntityRes.UpgradingHistoryTable); }
        }

        /// <summary>
        ///     A string like "Cannot scaffold the next migration because the target database was created with a version of Code First earlier than EF 4.3 and does not contain the migrations history table. To start using migrations against this database, ensure the current model is compatible with the target database and execute the migrations Update process. (In Visual Studio you can use the Update-Database command from Package Manager Console to execute the migrations Update process)."
        /// </summary>
        internal static string MetadataOutOfDate
        {
            get { return EntityRes.GetString(EntityRes.MetadataOutOfDate); }
        }

        /// <summary>
        ///     A string like "The specified target migration '{0}' does not exist. Ensure that target migration refers to an existing migration id."
        /// </summary>
        internal static string MigrationNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.MigrationNotFound, p0);
        }

        /// <summary>
        ///     A string like "The Foreign Key on table '{0}' with columns '{1}' could not be created because the principal key columns could not be determined. Use the AddForeignKey fluent API to fully specify the Foreign Key."
        /// </summary>
        internal static string PartialFkOperation(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PartialFkOperation, p0, p1);
        }

        /// <summary>
        ///     A string like "'{0}' is not a valid target migration. When targeting a previously applied automatic migration, use the full migration id including timestamp."
        /// </summary>
        internal static string AutoNotValidTarget(object p0)
        {
            return EntityRes.GetString(EntityRes.AutoNotValidTarget, p0);
        }

        /// <summary>
        ///     A string like "'{0}' is not a valid migration. Explicit migrations must be used for both source and target when scripting the upgrade between them."
        /// </summary>
        internal static string AutoNotValidForScriptWindows(object p0)
        {
            return EntityRes.GetString(EntityRes.AutoNotValidForScriptWindows, p0);
        }

        /// <summary>
        ///     A string like "The target context '{0}' is not constructible. Add a default constructor or provide an implementation of IDbContextFactory."
        /// </summary>
        internal static string ContextNotConstructible(object p0)
        {
            return EntityRes.GetString(EntityRes.ContextNotConstructible, p0);
        }

        /// <summary>
        ///     A string like "The specified migration name '{0}' is ambiguous. Specify the full migration id including timestamp instead."
        /// </summary>
        internal static string AmbiguousMigrationName(object p0)
        {
            return EntityRes.GetString(EntityRes.AmbiguousMigrationName, p0);
        }

        /// <summary>
        ///     A string like "Unable to update database to match the current model because there are pending changes and automatic migration is disabled. Either write the pending model changes to a code-based migration or enable automatic migration. Set DbMigrationsConfiguration.AutomaticMigrationsEnabled to true to enable automatic migration."
        /// </summary>
        internal static string AutomaticDisabledException
        {
            get { return EntityRes.GetString(EntityRes.AutomaticDisabledException); }
        }

        /// <summary>
        ///     A string like "Scripting the downgrade between two specified migrations is not supported."
        /// </summary>
        internal static string DownScriptWindowsNotSupported
        {
            get { return EntityRes.GetString(EntityRes.DownScriptWindowsNotSupported); }
        }

        /// <summary>
        ///     A string like "The migrations configuration type '{0}' was not be found in the assembly '{1}'."
        /// </summary>
        internal static string AssemblyMigrator_NoConfigurationWithName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.AssemblyMigrator_NoConfigurationWithName, p0, p1);
        }

        /// <summary>
        ///     A string like "More than one migrations configuration type '{0}' was found in the assembly '{1}'. Specify the fully qualified name of the one to use."
        /// </summary>
        internal static string AssemblyMigrator_MultipleConfigurationsWithName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.AssemblyMigrator_MultipleConfigurationsWithName, p0, p1);
        }

        /// <summary>
        ///     A string like "No migrations configuration type was found in the assembly '{0}'. (In Visual Studio you can use the Enable-Migrations command from Package Manager Console to add a migrations configuration)."
        /// </summary>
        internal static string AssemblyMigrator_NoConfiguration(object p0)
        {
            return EntityRes.GetString(EntityRes.AssemblyMigrator_NoConfiguration, p0);
        }

        /// <summary>
        ///     A string like "More than one migrations configuration type was found in the assembly '{0}'. Specify the name of the one to use."
        /// </summary>
        internal static string AssemblyMigrator_MultipleConfigurations(object p0)
        {
            return EntityRes.GetString(EntityRes.AssemblyMigrator_MultipleConfigurations, p0);
        }

        /// <summary>
        ///     A string like "Direct column renaming is not supported by SQL Server Compact. To rename a column in SQL Server Compact, you will need to recreate it."
        /// </summary>
        internal static string SqlCeColumnRenameNotSupported
        {
            get { return EntityRes.GetString(EntityRes.SqlCeColumnRenameNotSupported); }
        }

        /// <summary>
        ///     A string like "In VB.NET projects, the migrations namespace '{0}' must be under the root namespace '{1}'. Update the migrations project's root namespace to allow classes under the migrations namespace to be added."
        /// </summary>
        internal static string MigrationsNamespaceNotUnderRootNamespace(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MigrationsNamespaceNotUnderRootNamespace, p0, p1);
        }

        /// <summary>
        ///     A string like "Unable to call public, instance method AddOrUpdate on derived IDbSet<T>type '{0}'. Method not found."
        /// </summary>
        internal static string UnableToDispatchAddOrUpdate(object p0)
        {
            return EntityRes.GetString(EntityRes.UnableToDispatchAddOrUpdate, p0);
        }

        /// <summary>
        ///     A string like "No MigrationSqlGenerator found for provider '{0}'. Use the SetSqlGenerator method in the target migrations configuration class to register additional SQL generators."
        /// </summary>
        internal static string NoSqlGeneratorForProvider(object p0)
        {
            return EntityRes.GetString(EntityRes.NoSqlGeneratorForProvider, p0);
        }

        /// <summary>
        ///     A string like "Could not load assembly '{0}'. (If you are using Code First Migrations inside Visual Studio this can happen if the startUp project for your solution does not reference the project that contains your migrations. You can either change the startUp project for your solution or use the -StartUpProjectName parameter.)"
        /// </summary>
        internal static string ToolingFacade_AssemblyNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.ToolingFacade_AssemblyNotFound, p0);
        }

        /// <summary>
        ///     A string like "The argument '{0}' cannot be null, empty or contain only white space."
        /// </summary>
        internal static string ArgumentIsNullOrWhitespace(object p0)
        {
            return EntityRes.GetString(EntityRes.ArgumentIsNullOrWhitespace, p0);
        }

        /// <summary>
        ///     A string like "The argument property '{0}' cannot be null."
        /// </summary>
        internal static string ArgumentPropertyIsNull(object p0)
        {
            return EntityRes.GetString(EntityRes.ArgumentPropertyIsNull, p0);
        }

        /// <summary>
        ///     A string like "The precondition '{0}' failed. {1}"
        /// </summary>
        internal static string PreconditionFailed(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PreconditionFailed, p0, p1);
        }

        /// <summary>
        ///     A string like "The type '{0}' has already been configured as a complex type. It cannot be reconfigured as an entity type."
        /// </summary>
        internal static string EntityTypeConfigurationMismatch(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityTypeConfigurationMismatch, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' has already been configured as an entity type. It cannot be reconfigured as a complex type."
        /// </summary>
        internal static string ComplexTypeConfigurationMismatch(object p0)
        {
            return EntityRes.GetString(EntityRes.ComplexTypeConfigurationMismatch, p0);
        }

        /// <summary>
        ///     A string like "The key component '{0}' is not a declared property on type '{1}'. Verify that it has not been explicitly excluded from the model and that it is a valid primitive property."
        /// </summary>
        internal static string KeyPropertyNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.KeyPropertyNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The foreign key component '{0}' is not a declared property on type '{1}'. Verify that it has not been explicitly excluded from the model and that it is a valid primitive property."
        /// </summary>
        internal static string ForeignKeyPropertyNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ForeignKeyPropertyNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' is not a declared property on type '{1}'. Verify that the property has not been explicitly excluded from the model by using the Ignore method or NotMappedAttribute data annotation. Make sure that it is a valid primitive property."
        /// </summary>
        internal static string PropertyNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PropertyNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' is not a declared property on type '{1}'. Verify that it has not been explicitly excluded from the model and that it is a valid navigation property."
        /// </summary>
        internal static string NavigationPropertyNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NavigationPropertyNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The expression '{0}' is not a valid property expression. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'."
        /// </summary>
        internal static string InvalidPropertyExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidPropertyExpression, p0);
        }

        /// <summary>
        ///     A string like "The expression '{0}' is not a valid property expression. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'. Use dotted paths for nested properties: C#: 't => t.MyProperty.MyProperty'  VB.Net: 'Function(t) t.MyProperty.MyProperty'."
        /// </summary>
        internal static string InvalidComplexPropertyExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidComplexPropertyExpression, p0);
        }

        /// <summary>
        ///     A string like "The properties expression '{0}' is not valid. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'. When specifying multiple properties use an anonymous type: C#: 't => new {{ t.MyProperty1, t.MyProperty2 }}'  VB.Net: 'Function(t) New With {{ t.MyProperty1, t.MyProperty2 }}'."
        /// </summary>
        internal static string InvalidPropertiesExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidPropertiesExpression, p0);
        }

        /// <summary>
        ///     A string like "The properties expression '{0}' is not valid. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'. When specifying multiple properties use an anonymous type: C#: 't => new {{ t.MyProperty1, t.MyProperty2 }}'  VB.Net: 'Function(t) New With {{ t.MyProperty1, t.MyProperty2 }}'."
        /// </summary>
        internal static string InvalidComplexPropertiesExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidComplexPropertiesExpression, p0);
        }

        /// <summary>
        ///     A string like "A configuration for type '{0}' has already been added. To reference the existing configuration use the Entity<T>() or ComplexType
        ///                                                                                                                                     <T>() methods."
        /// </summary>
        internal static string DuplicateStructuralTypeConfiguration(object p0)
        {
            return EntityRes.GetString(EntityRes.DuplicateStructuralTypeConfiguration, p0);
        }

        /// <summary>
        ///     A string like "Conflicting configuration settings were specified for property '{0}' on type '{1}': {2}"
        /// </summary>
        internal static string ConflictingPropertyConfiguration(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ConflictingPropertyConfiguration, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Conflicting configuration settings were specified for column '{0}' on table '{1}': {2}"
        /// </summary>
        internal static string ConflictingColumnConfiguration(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ConflictingColumnConfiguration, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "{0} = {1} conflicts with {2} = {3}"
        /// </summary>
        internal static string ConflictingConfigurationValue(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ConflictingConfigurationValue, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The type '{0}' was not mapped. Check that the type has not been explicitly excluded by using the Ignore method or NotMappedAttribute data annotation. Verify that the type was defined as a class, is not primitive, nested or generic, and does not inherit from ComplexObject."
        /// </summary>
        internal static string CodeFirstInvalidComplexType(object p0)
        {
            return EntityRes.GetString(EntityRes.CodeFirstInvalidComplexType, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' was not mapped. Check that the type has not been explicitly excluded by using the Ignore method or NotMappedAttribute data annotation. Verify that the type was defined as a class, is not primitive, nested or generic, and does not inherit from EntityObject."
        /// </summary>
        internal static string InvalidEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEntityType, p0);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' declared on type '{1}' cannot be the inverse of itself."
        /// </summary>
        internal static string NavigationInverseItself(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NavigationInverseItself, p0, p1);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting foreign keys."
        /// </summary>
        internal static string ConflictingConstraint(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ConflictingConstraint, p0, p1);
        }

        /// <summary>
        ///     A string like "Values of incompatible types ('{1}' and '{2}') were assigned to the '{0}' discriminator column. Values of the same type must be specified. To explicitly specify the type of the discriminator column use the HasColumnType method."
        /// </summary>
        internal static string ConflictingInferredColumnType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ConflictingInferredColumnType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting mapping information."
        /// </summary>
        internal static string ConflictingMapping(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ConflictingMapping, p0, p1);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting cascade delete operations using 'WillCascadeOnDelete'."
        /// </summary>
        internal static string ConflictingCascadeDeleteOperation(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ConflictingCascadeDeleteOperation, p0, p1);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting multiplicities."
        /// </summary>
        internal static string ConflictingMultiplicities(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ConflictingMultiplicities, p0, p1);
        }

        /// <summary>
        ///     A string like "The MaxLengthAttribute on property '{0}' on type '{1} is not valid. The Length value must be greater than zero. Use MaxLength() without parameters to indicate that the string or array can have the maximum allowable length."
        /// </summary>
        internal static string MaxLengthAttributeConvention_InvalidMaxLength(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MaxLengthAttributeConvention_InvalidMaxLength, p0, p1);
        }

        /// <summary>
        ///     A string like "The StringLengthAttribute on property '{0}' on type '{1}' is not valid. The maximum length must be greater than zero. Use MaxLength() without parameters to indicate that the string or array can have the maximum allowable length."
        /// </summary>
        internal static string StringLengthAttributeConvention_InvalidMaximumLength(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.StringLengthAttributeConvention_InvalidMaximumLength, p0, p1);
        }

        /// <summary>
        ///     A string like "Unable to determine composite primary key ordering for type '{0}'. Use the ColumnAttribute or the HasKey method to specify an order for composite primary keys."
        /// </summary>
        internal static string ModelGeneration_UnableToDetermineKeyOrder(object p0)
        {
            return EntityRes.GetString(EntityRes.ModelGeneration_UnableToDetermineKeyOrder, p0);
        }

        /// <summary>
        ///     A string like "The ForeignKeyAttribute on property '{0}' on type '{1}' is not valid. Name must not be empty."
        /// </summary>
        internal static string ForeignKeyAttributeConvention_EmptyKey(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ForeignKeyAttributeConvention_EmptyKey, p0, p1);
        }

        /// <summary>
        ///     A string like "The ForeignKeyAttribute on property '{0}' on type '{1}' is not valid. The foreign key name '{2}' was not found on the dependent type '{3}'. The Name value should be a comma separated list of foreign key property names."
        /// </summary>
        internal static string ForeignKeyAttributeConvention_InvalidKey(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ForeignKeyAttributeConvention_InvalidKey, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The ForeignKeyAttribute on property '{0}' on type '{1}' is not valid. The navigation property '{2}' was not found on the dependent type '{1}'. The Name value should be a valid navigation property name."
        /// </summary>
        internal static string ForeignKeyAttributeConvention_InvalidNavigationProperty(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ForeignKeyAttributeConvention_InvalidNavigationProperty, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Unable to determine a composite foreign key ordering for foreign key on type {0}. When using the ForeignKey data annotation on composite foreign key properties ensure order is specified by using the Column data annotation or the fluent API."
        /// </summary>
        internal static string ForeignKeyAttributeConvention_OrderRequired(object p0)
        {
            return EntityRes.GetString(EntityRes.ForeignKeyAttributeConvention_OrderRequired, p0);
        }

        /// <summary>
        ///     A string like "The InversePropertyAttribute on property '{2}' on type '{3}' is not valid. The property '{0}' is not a valid navigation property on the related type '{1}'. Ensure that the property exists and is a valid reference or collection navigation property."
        /// </summary>
        internal static string InversePropertyAttributeConvention_PropertyNotFound(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.InversePropertyAttributeConvention_PropertyNotFound, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "A relationship cannot be established from property '{0}' on type '{1}' to property '{0}' on type '{1}'. Check the values in the InversePropertyAttribute to ensure relationship definitions are unique and reference from one navigation property to its corresponding inverse navigation property."
        /// </summary>
        internal static string InversePropertyAttributeConvention_SelfInverseDetected(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InversePropertyAttributeConvention_SelfInverseDetected, p0, p1);
        }

        /// <summary>
        ///     A string like "One or more validation errors were detected during model generation:"
        /// </summary>
        internal static string ValidationHeader
        {
            get { return EntityRes.GetString(EntityRes.ValidationHeader); }
        }

        /// <summary>
        ///     A string like "\t{0}: {1}: {2}"
        /// </summary>
        internal static string ValidationItemFormat(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ValidationItemFormat, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "A key is registered for the derived type '{0}'. Keys can only be registered for the root type '{1}'."
        /// </summary>
        internal static string KeyRegisteredOnDerivedType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.KeyRegisteredOnDerivedType, p0, p1);
        }

        /// <summary>
        ///     A string like "The {0} value '{1}' already exists in the user-defined dictionary."
        /// </summary>
        internal static string DuplicateEntryInUserDictionary(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DuplicateEntryInUserDictionary, p0, p1);
        }

        /// <summary>
        ///     A string like "The type '{0}' has already been mapped to table '{1}'. Specify all mapping aspects of a table in a single Map call."
        /// </summary>
        internal static string InvalidTableMapping(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidTableMapping, p0, p1);
        }

        /// <summary>
        ///     A string like "Map was called more than once for type '{0}' and at least one of the calls didn't specify the target table name."
        /// </summary>
        internal static string InvalidTableMapping_NoTableName(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidTableMapping_NoTableName, p0);
        }

        /// <summary>
        ///     A string like "The derived type '{0}' has already been mapped using the chaining syntax. A derived type can only be mapped once using the chaining syntax."
        /// </summary>
        internal static string InvalidChainedMappingSyntax(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidChainedMappingSyntax, p0);
        }

        /// <summary>
        ///     A string like "An "is not null" condition cannot be specified on property '{0}' on type '{1}' because this property is not included in the model. Check that the property has not been explicitly excluded from the model by using the Ignore method or NotMappedAttribute data annotation."
        /// </summary>
        internal static string InvalidNotNullCondition(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidNotNullCondition, p0, p1);
        }

        /// <summary>
        ///     A string like "Values of type '{0}' cannot be used as type discriminator values. Supported types include byte, signed byte, bool, int16, int32, int64, and string."
        /// </summary>
        internal static string InvalidDiscriminatorType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidDiscriminatorType, p0);
        }

        /// <summary>
        ///     A string like "Unable to add the convention '{0}'. Could not find an existing convention of type '{1}' in the current convention set."
        /// </summary>
        internal static string ConventionNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ConventionNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "Not all properties for type '{0}' have been mapped. Either map those properties or explicitly excluded them from the model."
        /// </summary>
        internal static string InvalidEntitySplittingProperties(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEntitySplittingProperties, p0);
        }

        /// <summary>
        ///     A string like "Unable to determine the provider name for connection of type '{0}'."
        /// </summary>
        internal static string ModelBuilder_ProviderNameNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.ModelBuilder_ProviderNameNotFound, p0);
        }

        /// <summary>
        ///     A string like "The database name '{0}' is invalid. Database names must be of the form [<schema_name>.]
        ///                                                                                                <object_name>."
        /// </summary>
        internal static string InvalidDatabaseName(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidDatabaseName, p0);
        }

        /// <summary>
        ///     A string like "Properties for type '{0}' can only be mapped once. Ensure the MapInheritedProperties method is only used during one call to the Map method."
        /// </summary>
        internal static string EntityMappingConfiguration_DuplicateMapInheritedProperties(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityMappingConfiguration_DuplicateMapInheritedProperties, p0);
        }

        /// <summary>
        ///     A string like "Properties for type '{0}' can only be mapped once. Ensure the Properties method is used and that repeated calls specify each non-key property only once."
        /// </summary>
        internal static string EntityMappingConfiguration_DuplicateMappedProperties(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityMappingConfiguration_DuplicateMappedProperties, p0);
        }

        /// <summary>
        ///     A string like "Properties for type '{0}' can only be mapped once. The non-key property '{1}' is mapped more than once. Ensure the Properties method specifies each non-key property only once."
        /// </summary>
        internal static string EntityMappingConfiguration_DuplicateMappedProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityMappingConfiguration_DuplicateMappedProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{1}' on type '{0}' cannot be mapped because it has been explicitly excluded from the model or it is of a type not supported by the DbModelBuilderVersion being used."
        /// </summary>
        internal static string EntityMappingConfiguration_CannotMapIgnoredProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityMappingConfiguration_CannotMapIgnoredProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The entity types '{0}' and '{1}' cannot share table '{2}' because they are not in the same type hierarchy or do not have a valid one to one foreign key relationship with matching primary keys between them."
        /// </summary>
        internal static string EntityMappingConfiguration_InvalidTableSharing(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EntityMappingConfiguration_InvalidTableSharing, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "You cannot use Ignore method on the property '{0}' on type '{1}' because this type inherits from the type '{2}' where this property is mapped. To exclude this property from your model, use NotMappedAttribute or Ignore method on the base type."
        /// </summary>
        internal static string CannotIgnoreMappedBaseProperty(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.CannotIgnoreMappedBaseProperty, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The property '{0}' cannot be used as a key property on the entity '{1}' because the property type is not a valid key type. Only scalar types, string and byte[] are supported key types."
        /// </summary>
        internal static string ModelBuilder_KeyPropertiesMustBePrimitive(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ModelBuilder_KeyPropertiesMustBePrimitive, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified table '{0}' was not found in the model. Ensure that the table name has been correctly specified."
        /// </summary>
        internal static string TableNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.TableNotFound, p0);
        }

        /// <summary>
        ///     A string like "The specified association foreign key columns '{0}' are invalid. The number of columns specified must match the number of primary key columns."
        /// </summary>
        internal static string IncorrectColumnCount(object p0)
        {
            return EntityRes.GetString(EntityRes.IncorrectColumnCount, p0);
        }

        /// <summary>
        ///     A string like "A circular ComplexType hierarchy was detected. Self-referencing ComplexTypes are not supported."
        /// </summary>
        internal static string CircularComplexTypeHierarchy
        {
            get { return EntityRes.GetString(EntityRes.CircularComplexTypeHierarchy); }
        }

        /// <summary>
        ///     A string like "Unable to determine the principal end of an association between the types '{0}' and '{1}'. The principal end of this association must be explicitly configured using either the relationship fluent API or data annotations."
        /// </summary>
        internal static string UnableToDeterminePrincipal(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.UnableToDeterminePrincipal, p0, p1);
        }

        /// <summary>
        ///     A string like "The abstract type '{0}' has no mapped descendants and so cannot be mapped. Either remove '{0}' from the model or add one or more types deriving from '{0}' to the model. "
        /// </summary>
        internal static string UnmappedAbstractType(object p0)
        {
            return EntityRes.GetString(EntityRes.UnmappedAbstractType, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' cannot be mapped as defined because it maps inherited properties from types that use entity splitting or another form of inheritance. Either choose a different inheritance mapping strategy so as to not map inherited properties, or change all types in the hierarchy to map inherited properties and to not use splitting. "
        /// </summary>
        internal static string UnsupportedHybridInheritanceMapping(object p0)
        {
            return EntityRes.GetString(EntityRes.UnsupportedHybridInheritanceMapping, p0);
        }

        /// <summary>
        ///     A string like "The table '{0}' was configured but is not used in any mappings. Verify the mapping configuration for '{0}' is correct."
        /// </summary>
        internal static string OrphanedConfiguredTableDetected(object p0)
        {
            return EntityRes.GetString(EntityRes.OrphanedConfiguredTableDetected, p0);
        }

        /// <summary>
        ///     A string like "The configured column orders for the table '{0}' contains duplicates. Ensure the specified column order values are distinct."
        /// </summary>
        internal static string DuplicateConfiguredColumnOrder(object p0)
        {
            return EntityRes.GetString(EntityRes.DuplicateConfiguredColumnOrder, p0);
        }

        /// <summary>
        ///     A string like "The enum or spatial property '{1}' on type '{0}' cannot be mapped. Use DbModelBuilderVersion 'V5_0' or later to map enum or spatial properties."
        /// </summary>
        internal static string UnsupportedUseOfV3Type(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.UnsupportedUseOfV3Type, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiple potential primary key properties named '{0}' but differing only by case were found on entity type '{1}'. Configure the primary key explicitly using the HasKey fluent API or the KeyAttribute data annotation."
        /// </summary>
        internal static string MultiplePropertiesMatchedAsKeys(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MultiplePropertiesMatchedAsKeys, p0, p1);
        }

        /// <summary>
        ///     A string like "Connection to the database failed. The connection string is configured with an invalid LocalDB server name. This may have been set in 'global.asax' by a pre-release version of MVC4. The default connection factory is now set in web.config so the line in 'global.asax' starting with 'Database.DefaultConnectionFactory = ' should be removed. See http://go.microsoft.com/fwlink/?LinkId=243166 for details."
        /// </summary>
        internal static string BadLocalDBDatabaseName
        {
            get { return EntityRes.GetString(EntityRes.BadLocalDBDatabaseName); }
        }

        /// <summary>
        ///     A string like "An error occurred while getting provider information from the database. This can be caused by Entity Framework using an incorrect connection string. Check the inner exceptions for details and ensure that the connection string is correct."
        /// </summary>
        internal static string FailedToGetProviderInformation
        {
            get { return EntityRes.GetString(EntityRes.FailedToGetProviderInformation); }
        }

        /// <summary>
        ///     A string like "Cannot get value for property '{0}' from entity of type '{1}' because the property has no get accessor."
        /// </summary>
        internal static string DbPropertyEntry_CannotGetCurrentValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyEntry_CannotGetCurrentValue, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot set value for property '{0}' on entity of type '{1}' because the property has no set accessor."
        /// </summary>
        internal static string DbPropertyEntry_CannotSetCurrentValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyEntry_CannotSetCurrentValue, p0, p1);
        }

        /// <summary>
        ///     A string like "Member '{0}' cannot be called for property '{1}' because the entity of type '{2}' does not exist in the context. To add an entity to the context call the Add or Attach method of DbSet<{2}>."
        /// </summary>
        internal static string DbPropertyEntry_NotSupportedForDetached(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DbPropertyEntry_NotSupportedForDetached, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Cannot set value for property '{0}' on entity of type '{1}' because the property has no set accessor and is in the '{2}' state."
        /// </summary>
        internal static string DbPropertyEntry_SettingEntityRefNotSupported(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DbPropertyEntry_SettingEntityRefNotSupported, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Member '{0}' cannot be called for property '{1}' on entity of type '{2}' because the property is not part of the Entity Data Model."
        /// </summary>
        internal static string DbPropertyEntry_NotSupportedForPropertiesNotInTheModel(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DbPropertyEntry_NotSupportedForPropertiesNotInTheModel, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Member '{0}' cannot be called for the entity of type '{1}' because the entity does not exist in the context. To add an entity to the context call the Add or Attach method of DbSet<{1}>."
        /// </summary>
        internal static string DbEntityEntry_NotSupportedForDetached(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_NotSupportedForDetached, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot call the {0} method for an entity of type '{1}' on a DbSet for entities of type '{2}'. Only entities of type '{2}' or derived from type '{2}' can be added, attached, or removed."
        /// </summary>
        internal static string DbSet_BadTypeForAddAttachRemove(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DbSet_BadTypeForAddAttachRemove, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Cannot call the Create method for the type '{0}' on a DbSet for entities of type '{1}'. Only entities of type '{1}' or derived from type '{1}' can be created."
        /// </summary>
        internal static string DbSet_BadTypeForCreate(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbSet_BadTypeForCreate, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot create a {0}<{1}> from a non-generic {0} for objects of type '{2}'."
        /// </summary>
        internal static string DbEntity_BadTypeForCast(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DbEntity_BadTypeForCast, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Cannot create a {0}<{1}, {2}> from a non-generic {0} for entities of type '{3}' with property of type '{4}'."
        /// </summary>
        internal static string DbMember_BadTypeForCast(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.DbMember_BadTypeForCast, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is a collection navigation property. The Collection method should be used instead of the Reference method."
        /// </summary>
        internal static string DbEntityEntry_UsedReferenceForCollectionProp(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_UsedReferenceForCollectionProp, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is a reference navigation property. The Reference method should be used instead of the Collection method."
        /// </summary>
        internal static string DbEntityEntry_UsedCollectionForReferenceProp(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_UsedCollectionForReferenceProp, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is not a navigation property. The Reference and Collection methods can only be used with navigation properties. Use the Property or ComplexProperty method."
        /// </summary>
        internal static string DbEntityEntry_NotANavigationProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_NotANavigationProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is not a primitive or complex property. The Property method can only be used with primitive or complex properties. Use the Reference or Collection method."
        /// </summary>
        internal static string DbEntityEntry_NotAScalarProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_NotAScalarProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is not a complex property. The ComplexProperty method can only be used with complex properties. Use the Property, Reference or Collection method."
        /// </summary>
        internal static string DbEntityEntry_NotAComplexProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_NotAComplexProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is not a primitive property, complex property, collection navigation property, or reference navigation property."
        /// </summary>
        internal static string DbEntityEntry_NotAProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_NotAProperty, p0, p1);
        }

        /// <summary>
        ///     A string like ""The property '{0}' from the property path '{1}' is not a complex property on type '{2}'. Property paths must be composed of complex properties for all except the final property.""
        /// </summary>
        internal static string DbEntityEntry_DottedPartNotComplex(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_DottedPartNotComplex, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Setting IsModified to false for a modified property is not supported."
        /// </summary>
        internal static string DbPropertyEntry_CannotMarkPropertyUnmodified
        {
            get { return EntityRes.GetString(EntityRes.DbPropertyEntry_CannotMarkPropertyUnmodified); }
        }

        /// <summary>
        ///     A string like ""The property path '{0}' cannot be used for navigation properties. Property paths can only be used to access primitive or complex properties.""
        /// </summary>
        internal static string DbEntityEntry_DottedPathMustBeProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_DottedPathMustBeProperty, p0);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' on entity type '{1}' cannot be used for entities of type '{2}' because it refers to entities of type '{3}'."
        /// </summary>
        internal static string DbEntityEntry_WrongGenericForNavProp(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_WrongGenericForNavProp, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The generic type argument '{0}' cannot be used with the Member method when accessing the collection navigation property '{1}' on entity type '{2}'. The generic type argument '{3}' must be used instead."
        /// </summary>
        internal static string DbEntityEntry_WrongGenericForCollectionNavProp(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_WrongGenericForCollectionNavProp, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The property '{0}' on entity type '{1}' cannot be used for objects of type '{2}' because it is a property for objects of type '{3}'."
        /// </summary>
        internal static string DbEntityEntry_WrongGenericForProp(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_WrongGenericForProp, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The expression passed to method {0} must represent a property defined on the type '{1}'."
        /// </summary>
        internal static string DbEntityEntry_BadPropertyExpression(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbEntityEntry_BadPropertyExpression, p0, p1);
        }

        /// <summary>
        ///     A string like "An error occurred while saving entities that do not expose foreign key properties for their relationships. The EntityEntries property will return null because a single entity cannot be identified as the source of the exception. Handling of exceptions while saving can be made easier by exposing foreign key properties in your entity types. See the InnerException for details."
        /// </summary>
        internal static string DbContext_IndependentAssociationUpdateException
        {
            get { return EntityRes.GetString(EntityRes.DbContext_IndependentAssociationUpdateException); }
        }

        /// <summary>
        ///     A string like "{0} cannot be used for entities in the {1} state."
        /// </summary>
        internal static string DbPropertyValues_CannotGetValuesForState(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_CannotGetValuesForState, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot set non-nullable property '{0}' of type '{1}' to null on object of type '{2}'."
        /// </summary>
        internal static string DbPropertyValues_CannotSetNullValue(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_CannotSetNullValue, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The property '{0}' in the entity of type '{1}' is null. Store values cannot be obtained for an entity with a null complex property."
        /// </summary>
        internal static string DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot assign value of type '{0}' to property '{1}' of type '{2}' in property values for type '{3}'."
        /// </summary>
        internal static string DbPropertyValues_WrongTypeForAssignment(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_WrongTypeForAssignment, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The set of property value names is read-only."
        /// </summary>
        internal static string DbPropertyValues_PropertyValueNamesAreReadonly
        {
            get { return EntityRes.GetString(EntityRes.DbPropertyValues_PropertyValueNamesAreReadonly); }
        }

        /// <summary>
        ///     A string like "The '{0}' property does not exist or is not mapped for the type '{1}'."
        /// </summary>
        internal static string DbPropertyValues_PropertyDoesNotExist(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_PropertyDoesNotExist, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot copy values from DbPropertyValues for type '{0}' into DbPropertyValues for type '{1}'."
        /// </summary>
        internal static string DbPropertyValues_AttemptToSetValuesFromWrongObject(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_AttemptToSetValuesFromWrongObject, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot copy from property values for object of type '{0}' into property values for object of type '{1}'."
        /// </summary>
        internal static string DbPropertyValues_AttemptToSetValuesFromWrongType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_AttemptToSetValuesFromWrongType, p0, p1);
        }

        /// <summary>
        ///     A string like "A property of a complex type must be set to an instance of the generic or non-generic DbPropertyValues class for that type."
        /// </summary>
        internal static string DbPropertyValues_AttemptToSetNonValuesOnComplexProperty
        {
            get { return EntityRes.GetString(EntityRes.DbPropertyValues_AttemptToSetNonValuesOnComplexProperty); }
        }

        /// <summary>
        ///     A string like "The value of the complex property '{0}' on entity of type '{1}' is null. Complex properties cannot be set to null and values cannot be set for null complex properties."
        /// </summary>
        internal static string DbPropertyValues_ComplexObjectCannotBeNull(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_ComplexObjectCannotBeNull, p0, p1);
        }

        /// <summary>
        ///     A string like "The value of the nested property values property '{0}' on the values for entity of type '{1}' is null. Nested property values cannot be set to null and values cannot be set for null complex properties."
        /// </summary>
        internal static string DbPropertyValues_NestedPropertyValuesNull(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_NestedPropertyValuesNull, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot set the value of the nested property '{0}' because value of the complex property '{1}' to which it belongs is null."
        /// </summary>
        internal static string DbPropertyValues_CannotSetPropertyOnNullCurrentValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_CannotSetPropertyOnNullCurrentValue, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot set the original value of the nested property '{0}' because the original value of the complex property '{1}' to which it belongs is null."
        /// </summary>
        internal static string DbPropertyValues_CannotSetPropertyOnNullOriginalValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbPropertyValues_CannotSetPropertyOnNullOriginalValue, p0, p1);
        }

        /// <summary>
        ///     A string like "The model backing the '{0}' context has changed since the database was created. Consider using Code First Migrations to update the database (http://go.microsoft.com/fwlink/?LinkId=238269)."
        /// </summary>
        internal static string DatabaseInitializationStrategy_ModelMismatch(object p0)
        {
            return EntityRes.GetString(EntityRes.DatabaseInitializationStrategy_ModelMismatch, p0);
        }

        /// <summary>
        ///     A string like "Database '{0}' cannot be created because it already exists."
        /// </summary>
        internal static string Database_DatabaseAlreadyExists(object p0)
        {
            return EntityRes.GetString(EntityRes.Database_DatabaseAlreadyExists, p0);
        }

        /// <summary>
        ///     A string like "Model compatibility cannot be checked because the DbContext instance was not created using Code First patterns. DbContext instances created from an ObjectContext or using an EDMX file cannot be checked for compatibility."
        /// </summary>
        internal static string Database_NonCodeFirstCompatibilityCheck
        {
            get { return EntityRes.GetString(EntityRes.Database_NonCodeFirstCompatibilityCheck); }
        }

        /// <summary>
        ///     A string like "Model compatibility cannot be checked because the EdmMetadata type was not included in the model. Ensure that IncludeMetadataConvention has been added to the DbModelBuilder conventions."
        /// </summary>
        internal static string Database_MetadataNotMapped
        {
            get { return EntityRes.GetString(EntityRes.Database_MetadataNotMapped); }
        }

        /// <summary>
        ///     A string like "Model compatibility cannot be checked because the database does not contain model metadata. Model compatibility can only be checked for databases created using Code First or Code First Migrations."
        /// </summary>
        internal static string Database_NoDatabaseMetadata
        {
            get { return EntityRes.GetString(EntityRes.Database_NoDatabaseMetadata); }
        }

        /// <summary>
        ///     A string like "The DbContextDatabaseInitializer entry 'key="{0}" value="{1}"' in the application configuration is not valid. Entries should be of the form 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="MyNamespace.MyInitializerClass, MyAssembly"' or 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="Disabled"'. Consider using the <entityFramework>configuration section to set the database initializer (http://go.microsoft.com/fwlink/?LinkID=237468)."
        /// </summary>
        internal static string Database_BadLegacyInitializerEntry(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Database_BadLegacyInitializerEntry, p0, p1);
        }

        /// <summary>
        ///     A string like "Failed to set database initializer of type '{0}' for DbContext type '{1}' specified in the application configuration. Entries should be of the form 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="MyNamespace.MyInitializerClass, MyAssembly"' or 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="Disabled"'. Also verify that 'DatabaseInitializerArgumentForType' entries are present for every parameter of the database initializer constructor. See inner exception for details. Consider using the <entityFramework>configuration section to set the database initializer (http://go.microsoft.com/fwlink/?LinkID=237468)."
        /// </summary>
        internal static string Database_InitializeFromLegacyConfigFailed(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Database_InitializeFromLegacyConfigFailed, p0, p1);
        }

        /// <summary>
        ///     A string like "Failed to set database initializer of type '{0}' for DbContext type '{1}' specified in the application configuration. See inner exception for details."
        /// </summary>
        internal static string Database_InitializeFromConfigFailed(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Database_InitializeFromConfigFailed, p0, p1);
        }

        /// <summary>
        ///     A string like "Configuration for DbContext type '{0}' is specified multiple times in the application configuration. Each context can only be configured once."
        /// </summary>
        internal static string ContextConfiguredMultipleTimes(object p0)
        {
            return EntityRes.GetString(EntityRes.ContextConfiguredMultipleTimes, p0);
        }

        /// <summary>
        ///     A string like "Failed to set Database.DefaultConnectionFactory to an instance of the '{0}' type as specified in the application configuration. See inner exception for details."
        /// </summary>
        internal static string SetConnectionFactoryFromConfigFailed(object p0)
        {
            return EntityRes.GetString(EntityRes.SetConnectionFactoryFromConfigFailed, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' could not be found. The type name must be an assembly-qualified name."
        /// </summary>
        internal static string Database_FailedToResolveType(object p0)
        {
            return EntityRes.GetString(EntityRes.Database_FailedToResolveType, p0);
        }

        /// <summary>
        ///     A string like "The context cannot be used while the model is being created."
        /// </summary>
        internal static string DbContext_ContextUsedInModelCreating
        {
            get { return EntityRes.GetString(EntityRes.DbContext_ContextUsedInModelCreating); }
        }

        /// <summary>
        ///     A string like "The DbContext class cannot be used with models that have multiple entity sets per type (MEST)."
        /// </summary>
        internal static string DbContext_MESTNotSupported
        {
            get { return EntityRes.GetString(EntityRes.DbContext_MESTNotSupported); }
        }

        /// <summary>
        ///     A string like "The operation cannot be completed because the DbContext has been disposed."
        /// </summary>
        internal static string DbContext_Disposed
        {
            get { return EntityRes.GetString(EntityRes.DbContext_Disposed); }
        }

        /// <summary>
        ///     A string like "The provider factory returned a null connection."
        /// </summary>
        internal static string DbContext_ProviderReturnedNullConnection
        {
            get { return EntityRes.GetString(EntityRes.DbContext_ProviderReturnedNullConnection); }
        }

        /// <summary>
        ///     A string like "The connection string '{0}' in the application's configuration file does not contain the required providerName attribute.""
        /// </summary>
        internal static string DbContext_ProviderNameMissing(object p0)
        {
            return EntityRes.GetString(EntityRes.DbContext_ProviderNameMissing, p0);
        }

        /// <summary>
        ///     A string like "The DbConnectionFactory instance returned a null connection."
        /// </summary>
        internal static string DbContext_ConnectionFactoryReturnedNullConnection
        {
            get { return EntityRes.GetString(EntityRes.DbContext_ConnectionFactoryReturnedNullConnection); }
        }

        /// <summary>
        ///     A string like "The number of primary key values passed must match number of primary key values defined on the entity."
        /// </summary>
        internal static string DbSet_WrongNumberOfKeyValuesPassed
        {
            get { return EntityRes.GetString(EntityRes.DbSet_WrongNumberOfKeyValuesPassed); }
        }

        /// <summary>
        ///     A string like "The type of one of the primary key values did not match the type defined in the entity. See inner exception for details."
        /// </summary>
        internal static string DbSet_WrongKeyValueType
        {
            get { return EntityRes.GetString(EntityRes.DbSet_WrongKeyValueType); }
        }

        /// <summary>
        ///     A string like "The entity found was of type {0} when an entity of type {1} was requested."
        /// </summary>
        internal static string DbSet_WrongEntityTypeFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbSet_WrongEntityTypeFound, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiple entities were found in the Added state that match the given primary key values."
        /// </summary>
        internal static string DbSet_MultipleAddedEntitiesFound
        {
            get { return EntityRes.GetString(EntityRes.DbSet_MultipleAddedEntitiesFound); }
        }

        /// <summary>
        ///     A string like "The type '{0}' is mapped as a complex type. The Set method, DbSet objects, and DbEntityEntry objects can only be used with entity types, not complex types."
        /// </summary>
        internal static string DbSet_DbSetUsedWithComplexType(object p0)
        {
            return EntityRes.GetString(EntityRes.DbSet_DbSetUsedWithComplexType, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' is not attributed with EdmEntityTypeAttribute but is contained in an assembly attributed with EdmSchemaAttribute. POCO entities that do not use EdmEntityTypeAttribute cannot be contained in the same assembly as non-POCO entities that use EdmEntityTypeAttribute."
        /// </summary>
        internal static string DbSet_PocoAndNonPocoMixedInSameAssembly(object p0)
        {
            return EntityRes.GetString(EntityRes.DbSet_PocoAndNonPocoMixedInSameAssembly, p0);
        }

        /// <summary>
        ///     A string like "The entity type {0} is not part of the model for the current context."
        /// </summary>
        internal static string DbSet_EntityTypeNotInModel(object p0)
        {
            return EntityRes.GetString(EntityRes.DbSet_EntityTypeNotInModel, p0);
        }

        /// <summary>
        ///     A string like "Data binding directly to a store query (DbSet, DbQuery, DbSqlQuery, DbRawSqlQuery) is not supported. Instead populate a DbSet with data, for example by calling Load on the DbSet, and then bind to local data. For WPF bind to DbSet.Local. For WinForms bind to DbSet.Local.ToBindingList()."
        /// </summary>
        internal static string DbQuery_BindingToDbQueryNotSupported
        {
            get { return EntityRes.GetString(EntityRes.DbQuery_BindingToDbQueryNotSupported); }
        }

        /// <summary>
        ///     A string like "The Include path expression must refer to a navigation property defined on the type. Use dotted paths for reference navigation properties and the Select operator for collection navigation properties."
        /// </summary>
        internal static string DbExtensions_InvalidIncludePathExpression
        {
            get { return EntityRes.GetString(EntityRes.DbExtensions_InvalidIncludePathExpression); }
        }

        /// <summary>
        ///     A string like "No connection string named '{0}' could be found in the application config file."
        /// </summary>
        internal static string DbContext_ConnectionStringNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.DbContext_ConnectionStringNotFound, p0);
        }

        /// <summary>
        ///     A string like "Cannot initialize a DbContext from an entity connection string or an EntityConnection instance together with a DbCompiledModel. If an entity connection string or EntityConnection instance is used, then the model will be created from the metadata in the connection. If a DbCompiledModel is used, then the connection supplied should be a standard database connection (for example, a SqlConnection instance) rather than an entity connection."
        /// </summary>
        internal static string DbContext_ConnectionHasModel
        {
            get { return EntityRes.GetString(EntityRes.DbContext_ConnectionHasModel); }
        }

        /// <summary>
        ///     A string like "The collection navigation property '{0}' on the entity of type '{1}' cannot be set because the entity type does not define a navigation property with a set accessor."
        /// </summary>
        internal static string DbCollectionEntry_CannotSetCollectionProp(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbCollectionEntry_CannotSetCollectionProp, p0, p1);
        }

        /// <summary>
        ///     A string like "Using the same DbCompiledModel to create contexts against different types of database servers is not supported. Instead, create a separate DbCompiledModel for each type of server being used."
        /// </summary>
        internal static string CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported
        {
            get { return EntityRes.GetString(EntityRes.CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported); }
        }

        /// <summary>
        ///     A string like "Multiple object sets per type are not supported. The object sets '{0}' and '{1}' can both contain instances of type '{2}'."
        /// </summary>
        internal static string Mapping_MESTNotSupported(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_MESTNotSupported, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The context type '{0}' must have a public constructor taking an EntityConnection."
        /// </summary>
        internal static string DbModelBuilder_MissingRequiredCtor(object p0)
        {
            return EntityRes.GetString(EntityRes.DbModelBuilder_MissingRequiredCtor, p0);
        }

        /// <summary>
        ///     A string like "Validation failed for one or more entities. See 'EntityValidationErrors' property for more details."
        /// </summary>
        internal static string DbEntityValidationException_ValidationFailed
        {
            get { return EntityRes.GetString(EntityRes.DbEntityValidationException_ValidationFailed); }
        }

        /// <summary>
        ///     A string like "An unexpected exception was thrown during validation of '{0}' when invoking {1}.IsValid. See the inner exception for details."
        /// </summary>
        internal static string DbUnexpectedValidationException_ValidationAttribute(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbUnexpectedValidationException_ValidationAttribute, p0, p1);
        }

        /// <summary>
        ///     A string like "An unexpected exception was thrown during validation of '{0}' when invoking {1}.Validate. See the inner exception for details."
        /// </summary>
        internal static string DbUnexpectedValidationException_IValidatableObject(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DbUnexpectedValidationException_IValidatableObject, p0, p1);
        }

        /// <summary>
        ///     A string like "The database name '{0}' is not supported because it is an MDF file name. A full connection string must be provided to attach an MDF file."
        /// </summary>
        internal static string SqlConnectionFactory_MdfNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlConnectionFactory_MdfNotSupported, p0);
        }

        /// <summary>
        ///     A string like "An exception occurred while initializing the database. See the InnerException for details."
        /// </summary>
        internal static string Database_InitializationException
        {
            get { return EntityRes.GetString(EntityRes.Database_InitializationException); }
        }

        /// <summary>
        ///     A string like "Creating a DbModelBuilder or writing the EDMX from a DbContext created using an existing ObjectContext is not supported. EDMX can only be obtained from a Code First DbContext created without using an existing DbCompiledModel."
        /// </summary>
        internal static string EdmxWriter_EdmxFromObjectContextNotSupported
        {
            get { return EntityRes.GetString(EntityRes.EdmxWriter_EdmxFromObjectContextNotSupported); }
        }

        /// <summary>
        ///     A string like "Creating a DbModelBuilder or writing the EDMX from a DbContext created using an existing DbCompiledModel is not supported. EDMX can only be obtained from a Code First DbContext created without using an existing DbCompiledModel."
        /// </summary>
        internal static string EdmxWriter_EdmxFromDbCompiledModelNotSupported
        {
            get { return EntityRes.GetString(EntityRes.EdmxWriter_EdmxFromDbCompiledModelNotSupported); }
        }

        /// <summary>
        ///     A string like "Creating a DbModelBuilder or writing the EDMX from a DbContext created using Database First or Model First is not supported. EDMX can only be obtained from a Code First DbContext created without using an existing DbCompiledModel."
        /// </summary>
        internal static string EdmxWriter_EdmxFromModelFirstNotSupported
        {
            get { return EntityRes.GetString(EntityRes.EdmxWriter_EdmxFromModelFirstNotSupported); }
        }

        /// <summary>
        ///     A string like "Code generated using the T4 templates for Database First and Model First development may not work correctly if used in Code First mode. To continue using Database First or Model First ensure that the Entity Framework connection string is specified in the config file of executing application. To use these classes, that were generated from Database First or Model First, with Code First add any additional configuration using attributes or the DbModelBuilder API and then remove the code that throws this exception."
        /// </summary>
        internal static string UnintentionalCodeFirstException_Message
        {
            get { return EntityRes.GetString(EntityRes.UnintentionalCodeFirstException_Message); }
        }

        /// <summary>
        ///     A string like "The context factory type '{0}' must have a public default constructor."
        /// </summary>
        internal static string DbContextServices_MissingDefaultCtor(object p0)
        {
            return EntityRes.GetString(EntityRes.DbContextServices_MissingDefaultCtor, p0);
        }

        /// <summary>
        ///     A string like "The generic 'Set' method cannot be called with a proxy type. Either use the actual entity type or call the non-generic 'Set' method."
        /// </summary>
        internal static string CannotCallGenericSetWithProxyType
        {
            get { return EntityRes.GetString(EntityRes.CannotCallGenericSetWithProxyType); }
        }

        /// <summary>
        ///     A string like "The '{0}' property of EdmPrimitiveType is fixed and cannot be set."
        /// </summary>
        internal static string EdmPrimitiveType_SetPropertyNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmPrimitiveType_SetPropertyNotSupported, p0);
        }

        /// <summary>
        ///     A string like "The namespace '{0}' is a system namespace and cannot be used by other schemas. Choose another namespace name."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_SystemNamespaceEncountered(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_SystemNamespaceEncountered, p0);
        }

        /// <summary>
        ///     A string like "Role '{0}' in AssociationSets '{1}' and '{2}' refers to the same EntitySet '{3}' in EntityContainer '{4}'. Make sure that if two or more AssociationSets refer to the same AssociationType, the ends do not refer to the same EntitySet."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_SimilarRelationshipEnd(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_SimilarRelationshipEnd, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "The referenced EntitySet '{0}' for End '{1}' could not be found in the containing EntityContainer."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidEntitySetNameReference(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidEntitySetNameReference, p0, p1);
        }

        /// <summary>
        ///     A string like "Type '{0}' is derived from type '{1}' that is the type for EntitySet '{2}'. Type '{0}' defines new concurrency requirements that are not allowed for subtypes of base EntitySet types."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_ConcurrencyRedefinedOnSubTypeOfEntitySetType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_ConcurrencyRedefinedOnSubTypeOfEntitySetType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "EntitySet '{0}' is based on type '{1}' that has no keys defined."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_EntitySetTypeHasNoKeys(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_EntitySetTypeHasNoKeys, p0, p1);
        }

        /// <summary>
        ///     A string like "The end name  '{0}' is already defined."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_DuplicateEndName(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_DuplicateEndName, p0);
        }

        /// <summary>
        ///     A string like "The key specified in EntityType '{0}' is not valid. Property '{1}' is referenced more than once in the Key element."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_DuplicatePropertyNameSpecifiedInEntityKey(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_DuplicatePropertyNameSpecifiedInEntityKey, p0, p1);
        }

        /// <summary>
        ///     A string like "Property '{0}' has a CollectionKind specified but is not a collection property."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidCollectionKindNotCollection(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidCollectionKindNotCollection, p0);
        }

        /// <summary>
        ///     A string like "Property '{0}' has a CollectionKind specified. CollectionKind is only supported in version 1.1 EDM models."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidCollectionKindNotV1_1(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidCollectionKindNotV1_1, p0);
        }

        /// <summary>
        ///     A string like "ComplexType '{0}' is marked as abstract. Abstract ComplexTypes are only supported in version 1.1 EDM models."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidComplexTypeAbstract(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidComplexTypeAbstract, p0);
        }

        /// <summary>
        ///     A string like "ComplexType '{0}' has a BaseType specified. ComplexType inheritance is only supported in version 1.1 EDM models."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidComplexTypePolymorphic(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidComplexTypePolymorphic, p0);
        }

        /// <summary>
        ///     A string like "Key part '{0}' for type '{1}' is not valid. All parts of the key must be non-nullable."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidKeyNullablePart(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidKeyNullablePart, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' in EntityType '{1}' is not valid. All properties that are part of the EntityKey must be of PrimitiveType."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_EntityKeyMustBeScalar(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_EntityKeyMustBeScalar, p0, p1);
        }

        /// <summary>
        ///     A string like "Key usage is not valid. The {0} class  cannot define keys because one of its base classes ('{1}') defines keys."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidKeyKeyDefinedInBaseClass(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidKeyKeyDefinedInBaseClass, p0, p1);
        }

        /// <summary>
        ///     A string like "EntityType '{0}' has no key defined. Define the key for this EntityType."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_KeyMissingOnEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_KeyMissingOnEntityType, p0);
        }

        /// <summary>
        ///     A string like "NavigationProperty is not valid. Role '{0}' or Role '{1}' is not defined in Relationship '{2}'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_BadNavigationPropertyUndefinedRole(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_BadNavigationPropertyUndefinedRole, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "NavigationProperty is not valid. The FromRole and ToRole are the same."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_BadNavigationPropertyRolesCannotBeTheSame
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_BadNavigationPropertyRolesCannotBeTheSame); }
        }

        /// <summary>
        ///     A string like "OnDelete can be specified on only one End of an EdmAssociation."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidOperationMultipleEndsInAssociation
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidOperationMultipleEndsInAssociation); }
        }

        /// <summary>
        ///     A string like "End '{0}' on relationship '{1}' cannot have an operation specified because its multiplicity is '*'. Operations cannot be specified on ends with multiplicity '*'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_EndWithManyMultiplicityCannotHaveOperationsSpecified(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_EndWithManyMultiplicityCannotHaveOperationsSpecified, p0, p1);
        }

        /// <summary>
        ///     A string like "Each Name and PluralName in a relationship must be unique. '{0}' is already defined."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_EndNameAlreadyDefinedDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_EndNameAlreadyDefinedDuplicate, p0);
        }

        /// <summary>
        ///     A string like "In relationship '{0}', the Principal and Dependent Role of the referential constraint refer to the same Role in the relationship type."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_SameRoleReferredInReferentialConstraint(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_SameRoleReferredInReferentialConstraint, p0);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. Valid values for multiplicity for the Principal Role are '0..1' or '1'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleUpperBoundMustBeOne(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleUpperBoundMustBeOne, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. Because all the properties in the Dependent Role are nullable, multiplicity of the Principal Role must be '0..1'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNullableV1(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNullableV1, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity conflicts with the referential constraint in Role '{0}' in relationship '{1}'. Because at least one  of the properties in the Dependent Role is non-nullable, multiplicity of the Principal Role must be '1'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV1(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV1, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity conflicts with the referential constraint in Role '{0}' in relationship '{1}'. Because all of the properties in the Dependent Role are non-nullable, multiplicity of the Principal Role must be '1'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV2(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV2, p0, p1);
        }

        /// <summary>
        ///     A string like "Properties referred by the Dependent Role '{0}' must be a subset of the key of the EntityType '{1}' referred to by the Dependent Role in the referential constraint for relationship '{2}'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidToPropertyInRelationshipConstraint(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidToPropertyInRelationshipConstraint, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. Because the Dependent Role refers to the key properties, the upper bound of the multiplicity of the Dependent Role must be '1'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeOne(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeOne, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. Because the Dependent Role properties are not the key properties, the upper bound of the multiplicity of the Dependent Role must be '*'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeMany(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeMany, p0, p1);
        }

        /// <summary>
        ///     A string like "The number of properties in the Dependent and Principal Roles in a relationship constraint must be identical."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_MismatchNumberOfPropertiesinRelationshipConstraint
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_MismatchNumberOfPropertiesinRelationshipConstraint); }
        }

        /// <summary>
        ///     A string like "The types of all properties in the Dependent Role of a referential constraint must be the same as the corresponding property types in the Principal Role. The type of property '{0}' on entity '{1}' does not match the type of property '{2}' on entity '{3}' in the referential constraint '{4}'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_TypeMismatchRelationshipConstraint(
            object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_TypeMismatchRelationshipConstraint, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "There is no property with name '{0}' defined in the type referred to by Role '{1}'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidPropertyInRelationshipConstraint(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidPropertyInRelationshipConstraint, p0, p1);
        }

        /// <summary>
        ///     A string like "A nullable ComplexType is not supported. Property '{0}' must not allow nulls."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_NullableComplexType(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_NullableComplexType, p0);
        }

        /// <summary>
        ///     A string like "A property cannot be of type '{0}'. The property type must be a ComplexType or a PrimitiveType."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidPropertyType(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidPropertyType, p0);
        }

        /// <summary>
        ///     A string like "Each member name in an EntityContainer must be unique. A member with name '{0}' is already defined."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_DuplicateEntityContainerMemberName(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_DuplicateEntityContainerMemberName, p0);
        }

        /// <summary>
        ///     A string like "Each type name in a schema must be unique. Type name '{0}' is already defined."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_TypeNameAlreadyDefinedDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_TypeNameAlreadyDefinedDuplicate, p0);
        }

        /// <summary>
        ///     A string like "Name '{0}' cannot be used in type '{1}'. Member names cannot be the same as their enclosing type."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidMemberNameMatchesTypeName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidMemberNameMatchesTypeName, p0, p1);
        }

        /// <summary>
        ///     A string like "Each property name in a type must be unique. Property name '{0}' is already defined."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate, p0);
        }

        /// <summary>
        ///     A string like "A cycle was detected in the type hierarchy of '{0}'."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_CycleInTypeHierarchy(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_CycleInTypeHierarchy, p0);
        }

        /// <summary>
        ///     A string like "A property cannot be of type '{0}'. The property type must be a ComplexType, a PrimitiveType, or a CollectionType."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidPropertyType_V1_1(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidPropertyType_V1_1, p0);
        }

        /// <summary>
        ///     A string like "A property cannot be of type {0}. The property type must be a ComplexType, a PrimitiveType or an EnumType."
        /// </summary>
        internal static string EdmModel_Validator_Semantic_InvalidPropertyType_V3(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Semantic_InvalidPropertyType_V3, p0);
        }

        /// <summary>
        ///     A string like "The name is missing or not valid."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_MissingName
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_MissingName); }
        }

        /// <summary>
        ///     A string like "The specified name must not be longer than 480 characters: '{0}'."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmModel_NameIsTooLong(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmModel_NameIsTooLong, p0);
        }

        /// <summary>
        ///     A string like "The specified name is not allowed: '{0}'."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmModel_NameIsNotAllowed(object p0)
        {
            return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmModel_NameIsNotAllowed, p0);
        }

        /// <summary>
        ///     A string like "AssociationEnd must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmAssociationType_AssocationEndMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmAssociationType_AssocationEndMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "DependentEnd must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentEndMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentEndMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "DependentProperties must not be empty."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentPropertiesMustNotBeEmpty
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentPropertiesMustNotBeEmpty); }
        }

        /// <summary>
        ///     A string like "Association must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmNavigationProperty_AssocationMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmNavigationProperty_AssocationMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "ResultEnd must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmNavigationProperty_ResultEndMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmNavigationProperty_ResultEndMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "EntityType must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmAssociationEnd_EntityTypeMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmAssociationEnd_EntityTypeMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "ElementType must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmEntitySet_ElementTypeMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmEntitySet_ElementTypeMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "ElementType must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmAssociationSet_ElementTypeMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmAssociationSet_ElementTypeMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "SourceSet must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmAssociationSet_SourceSetMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmAssociationSet_SourceSetMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "TargetSet must not be null."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmAssociationSet_TargetSetMustNotBeNull
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmAssociationSet_TargetSetMustNotBeNull); }
        }

        /// <summary>
        ///     A string like "The type is not a valid EdmTypeReference."
        /// </summary>
        internal static string EdmModel_Validator_Syntactic_EdmTypeReferenceNotValid
        {
            get { return EntityRes.GetString(EntityRes.EdmModel_Validator_Syntactic_EdmTypeReferenceNotValid); }
        }

        /// <summary>
        ///     A string like "Serializer can only serialize an EdmModel that has one EdmNamespace and one EdmEntityContainer."
        /// </summary>
        internal static string Serializer_OneNamespaceAndOneContainer
        {
            get { return EntityRes.GetString(EntityRes.Serializer_OneNamespaceAndOneContainer); }
        }

        /// <summary>
        ///     A string like "The field {0} must be a string or array type with a maximum length of '{1}'."
        /// </summary>
        internal static string MaxLengthAttribute_ValidationError(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MaxLengthAttribute_ValidationError, p0, p1);
        }

        /// <summary>
        ///     A string like "MaxLengthAttribute must have a Length value that is greater than zero. Use MaxLength() without parameters to  indicate that the string or array can have the maximum allowable length."
        /// </summary>
        internal static string MaxLengthAttribute_InvalidMaxLength
        {
            get { return EntityRes.GetString(EntityRes.MaxLengthAttribute_InvalidMaxLength); }
        }

        /// <summary>
        ///     A string like "The field {0} must be a string or array type with a minimum length of '{1}'."
        /// </summary>
        internal static string MinLengthAttribute_ValidationError(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MinLengthAttribute_ValidationError, p0, p1);
        }

        /// <summary>
        ///     A string like "MinLengthAttribute must have a Length value that is zero or greater."
        /// </summary>
        internal static string MinLengthAttribute_InvalidMinLength
        {
            get { return EntityRes.GetString(EntityRes.MinLengthAttribute_InvalidMinLength); }
        }

        /// <summary>
        ///     A string like "No connection string named '{0}' could be found in the application config file."
        /// </summary>
        internal static string DbConnectionInfo_ConnectionStringNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.DbConnectionInfo_ConnectionStringNotFound, p0);
        }

        /// <summary>
        ///     A string like "The connection can not be overridden because this context was created from an existing ObjectContext."
        /// </summary>
        internal static string EagerInternalContext_CannotSetConnectionInfo
        {
            get { return EntityRes.GetString(EntityRes.EagerInternalContext_CannotSetConnectionInfo); }
        }

        /// <summary>
        ///     A string like "Can not override the connection for this context with a standard DbConnection because the original connection was an EntityConnection."
        /// </summary>
        internal static string LazyInternalContext_CannotReplaceEfConnectionWithDbConnection
        {
            get { return EntityRes.GetString(EntityRes.LazyInternalContext_CannotReplaceEfConnectionWithDbConnection); }
        }

        /// <summary>
        ///     A string like "Can not override the connection for this context with an EntityConnection because the original connection was a standard DbConnection."
        /// </summary>
        internal static string LazyInternalContext_CannotReplaceDbConnectionWithEfConnection
        {
            get { return EntityRes.GetString(EntityRes.LazyInternalContext_CannotReplaceDbConnectionWithEfConnection); }
        }

        /// <summary>
        ///     A string like "The supplied IExtendedDataRecord must represent an entity object."
        /// </summary>
        internal static string EntityKey_DataRecordMustBeEntity
        {
            get { return EntityRes.GetString(EntityRes.EntityKey_DataRecordMustBeEntity); }
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' obtained from the metadata workspace is incompatible with the EntitySet required by this EntityKey."
        /// </summary>
        internal static string EntityKey_EntitySetDoesNotMatch(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityKey_EntitySetDoesNotMatch, p0);
        }

        /// <summary>
        ///     A string like "The object represented by the IExtendedDataRecord '{0}' does not match the EntityType for the EntitySet ('{1}')."
        /// </summary>
        internal static string EntityKey_EntityTypesDoNotMatch(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityKey_EntityTypesDoNotMatch, p0, p1);
        }

        /// <summary>
        ///     A string like "The provided list of key-value pairs contains an incorrect number of entries. There are {1} key fields defined on type '{0}', but {2} were provided."
        /// </summary>
        internal static string EntityKey_IncorrectNumberOfKeyValuePairs(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EntityKey_IncorrectNumberOfKeyValuePairs, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The type of the key field '{0}' is expected to be '{1}', but the value provided is actually of type '{2}'."
        /// </summary>
        internal static string EntityKey_IncorrectValueType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EntityKey_IncorrectValueType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "No corresponding object layer type found for the key field '{0}' whose type in the conceptual layer is '{1}'."
        /// </summary>
        internal static string EntityKey_NoCorrespondingOSpaceTypeForEnumKeyMember(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityKey_NoCorrespondingOSpaceTypeForEnumKeyMember, p0, p1);
        }

        /// <summary>
        ///     A string like "The required entry '{0}' was not found in the provided input. This entry is required by the key fields defined on type '{1}'."
        /// </summary>
        internal static string EntityKey_MissingKeyValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityKey_MissingKeyValue, p0, p1);
        }

        /// <summary>
        ///     A string like "The key-value pairs that define an EntityKey cannot be null or empty."
        /// </summary>
        internal static string EntityKey_NoNullsAllowedInKeyValuePairs
        {
            get { return EntityRes.GetString(EntityRes.EntityKey_NoNullsAllowedInKeyValuePairs); }
        }

        /// <summary>
        ///     A string like "The requested operation could not be completed, because a null EntityKey property value was returned by the object."
        /// </summary>
        internal static string EntityKey_UnexpectedNull
        {
            get { return EntityRes.GetString(EntityRes.EntityKey_UnexpectedNull); }
        }

        /// <summary>
        ///     A string like "The requested operation could not be completed, because a mismatched EntityKey was returned from the EntityKey property on an object of type '{0}'."
        /// </summary>
        internal static string EntityKey_DoesntMatchKeyOnEntity(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityKey_DoesntMatchKeyOnEntity, p0);
        }

        /// <summary>
        ///     A string like "An EntityKey must have at least one key name and value."
        /// </summary>
        internal static string EntityKey_EntityKeyMustHaveValues
        {
            get { return EntityRes.GetString(EntityRes.EntityKey_EntityKeyMustHaveValues); }
        }

        /// <summary>
        ///     A string like "The EntitySet name cannot be null or empty, and must be qualified with an EntityContainer name that is not null or empty."
        /// </summary>
        internal static string EntityKey_InvalidQualifiedEntitySetName
        {
            get { return EntityRes.GetString(EntityRes.EntityKey_InvalidQualifiedEntitySetName); }
        }

        /// <summary>
        ///     A string like "The EntityKey does not contain a valid EntitySet name."
        /// </summary>
        internal static string EntityKey_MissingEntitySetName
        {
            get { return EntityRes.GetString(EntityRes.EntityKey_MissingEntitySetName); }
        }

        /// <summary>
        ///     A string like "The name '{0}' contains characters that are not valid."
        /// </summary>
        internal static string EntityKey_InvalidName(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityKey_InvalidName, p0);
        }

        /// <summary>
        ///     A string like "EntityKey values cannot be changed once they are set."
        /// </summary>
        internal static string EntityKey_CannotChangeKey
        {
            get { return EntityRes.GetString(EntityRes.EntityKey_CannotChangeKey); }
        }

        /// <summary>
        ///     A string like "The EntityType specified for the metadata parameter is not compatible with the specified EntitySet. "
        /// </summary>
        internal static string EntityTypesDoNotAgree
        {
            get { return EntityRes.GetString(EntityRes.EntityTypesDoNotAgree); }
        }

        /// <summary>
        ///     A string like "The key field '{0}' cannot have a value of null. A non-null value is required for the key fields defined on type '{1}'."
        /// </summary>
        internal static string EntityKey_NullKeyValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityKey_NullKeyValue, p0, p1);
        }

        /// <summary>
        ///     A string like "The type of the TypeUsage object specified for the metadata parameter is not compatible with the type to which an EdmMember belongs."
        /// </summary>
        internal static string EdmMembersDefiningTypeDoNotAgreeWithMetadataType
        {
            get { return EntityRes.GetString(EntityRes.EdmMembersDefiningTypeDoNotAgreeWithMetadataType); }
        }

        /// <summary>
        ///     A string like "Parameter '{0}' is not valid. String arguments cannot be empty."
        /// </summary>
        internal static string InvalidStringArgument(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidStringArgument, p0);
        }

        /// <summary>
        ///     A string like "The function or function import '{0}' is not composable. A non-composable function or function import cannot be called in a query expression."
        /// </summary>
        internal static string CannotCallNoncomposableFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.CannotCallNoncomposableFunction, p0);
        }

        /// <summary>
        ///     A string like "Some required information is missing from the connection string. The '{0}' keyword is always required."
        /// </summary>
        internal static string EntityClient_ConnectionStringMissingInfo(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_ConnectionStringMissingInfo, p0);
        }

        /// <summary>
        ///     A string like "The specified value is not a string."
        /// </summary>
        internal static string EntityClient_ValueNotString
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ValueNotString); }
        }

        /// <summary>
        ///     A string like "The '{0}' keyword is not supported."
        /// </summary>
        internal static string EntityClient_KeywordNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_KeywordNotSupported, p0);
        }

        /// <summary>
        ///     A string like "The EntityCommand.CommandText property has not been initialized."
        /// </summary>
        internal static string EntityClient_NoCommandText
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_NoCommandText); }
        }

        /// <summary>
        ///     A string like "A connection string must be set on the connection before you attempt this operation."
        /// </summary>
        internal static string EntityClient_ConnectionStringNeededBeforeOperation
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ConnectionStringNeededBeforeOperation); }
        }

        /// <summary>
        ///     A string like "The connection was not closed."
        /// </summary>
        internal static string EntityClient_CannotReopenConnection
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotReopenConnection); }
        }

        /// <summary>
        ///     A string like "The connection is not open."
        /// </summary>
        internal static string EntityClient_ConnectionNotOpen
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ConnectionNotOpen); }
        }

        /// <summary>
        ///     A string like "Parameters must have a unique ParameterName. A second instance of '{0}' was discovered."
        /// </summary>
        internal static string EntityClient_DuplicateParameterNames(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_DuplicateParameterNames, p0);
        }

        /// <summary>
        ///     A string like "Cannot perform the operation because the command does not have a connection."
        /// </summary>
        internal static string EntityClient_NoConnectionForCommand
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_NoConnectionForCommand); }
        }

        /// <summary>
        ///     A string like "Cannot perform the operation because the adapter does not have a connection."
        /// </summary>
        internal static string EntityClient_NoConnectionForAdapter
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_NoConnectionForAdapter); }
        }

        /// <summary>
        ///     A string like "Cannot perform the update operation because the adapter's connection is not open."
        /// </summary>
        internal static string EntityClient_ClosedConnectionForUpdate
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ClosedConnectionForUpdate); }
        }

        /// <summary>
        ///     A string like "The specified named connection is either not found in the configuration, not intended to be used with the EntityClient provider, or not valid."
        /// </summary>
        internal static string EntityClient_InvalidNamedConnection
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_InvalidNamedConnection); }
        }

        /// <summary>
        ///     A string like "The connection string of the named connection '{0}' cannot contain a 'Name' keyword in the configuration."
        /// </summary>
        internal static string EntityClient_NestedNamedConnection(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_NestedNamedConnection, p0);
        }

        /// <summary>
        ///     A string like "The specified store provider cannot be found in the configuration, or is not valid."
        /// </summary>
        internal static string EntityClient_InvalidStoreProvider
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_InvalidStoreProvider); }
        }

        /// <summary>
        ///     A string like "The command is still associated with an open data reader. Changes cannot be made on this command and this command cannot be executed until the data reader is closed."
        /// </summary>
        internal static string EntityClient_DataReaderIsStillOpen
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_DataReaderIsStillOpen); }
        }

        /// <summary>
        ///     A string like "No modifications to connection are permitted after the metadata has been registered either by opening a connection or constructing the connection with a MetadataWorkspace."
        /// </summary>
        internal static string EntityClient_SettingsCannotBeChangedOnOpenConnection
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_SettingsCannotBeChangedOnOpenConnection); }
        }

        /// <summary>
        ///     A string like "Execution of the command requires an open and available connection. The connection's current state is {0}."
        /// </summary>
        internal static string EntityClient_ExecutingOnClosedConnection(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_ExecutingOnClosedConnection, p0);
        }

        /// <summary>
        ///     A string like "closed"
        /// </summary>
        internal static string EntityClient_ConnectionStateClosed
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ConnectionStateClosed); }
        }

        /// <summary>
        ///     A string like "broken"
        /// </summary>
        internal static string EntityClient_ConnectionStateBroken
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ConnectionStateBroken); }
        }

        /// <summary>
        ///     A string like "This store command cannot be cloned because the underlying store provider does not support cloning."
        /// </summary>
        internal static string EntityClient_CannotCloneStoreProvider
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotCloneStoreProvider); }
        }

        /// <summary>
        ///     A string like "The only EntityCommand.CommandType values supported by the EntityClient provider are Text and StoredProcedure."
        /// </summary>
        internal static string EntityClient_UnsupportedCommandType
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_UnsupportedCommandType); }
        }

        /// <summary>
        ///     A string like "An error occurred while closing the provider connection. See the inner exception for details."
        /// </summary>
        internal static string EntityClient_ErrorInClosingConnection
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ErrorInClosingConnection); }
        }

        /// <summary>
        ///     A string like "An error occurred while starting a transaction on the provider connection. See the inner exception for details."
        /// </summary>
        internal static string EntityClient_ErrorInBeginningTransaction
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ErrorInBeginningTransaction); }
        }

        /// <summary>
        ///     A string like "Other keywords are not allowed when the 'Name' keyword is specified."
        /// </summary>
        internal static string EntityClient_ExtraParametersWithNamedConnection
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ExtraParametersWithNamedConnection); }
        }

        /// <summary>
        ///     A string like "An error occurred while preparing the command definition. See the inner exception for details."
        /// </summary>
        internal static string EntityClient_CommandDefinitionPreparationFailed
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CommandDefinitionPreparationFailed); }
        }

        /// <summary>
        ///     A string like "An error occurred while executing the command definition. See the inner exception for details."
        /// </summary>
        internal static string EntityClient_CommandDefinitionExecutionFailed
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CommandDefinitionExecutionFailed); }
        }

        /// <summary>
        ///     A string like "An error occurred while executing the command. See the inner exception for details."
        /// </summary>
        internal static string EntityClient_CommandExecutionFailed
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CommandExecutionFailed); }
        }

        /// <summary>
        ///     A string like "An error occurred while reading from the store provider's data reader. See the inner exception for details."
        /// </summary>
        internal static string EntityClient_StoreReaderFailed
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_StoreReaderFailed); }
        }

        /// <summary>
        ///     A string like "The store data provider failed to return information for the {0} request. See the inner exception for details."
        /// </summary>
        internal static string EntityClient_FailedToGetInformation(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_FailedToGetInformation, p0);
        }

        /// <summary>
        ///     A string like "The data reader returned by the store data provider does not have enough columns for the query requested."
        /// </summary>
        internal static string EntityClient_TooFewColumns
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_TooFewColumns); }
        }

        /// <summary>
        ///     A string like "The parameter name '{0}' is not valid. A valid parameter name must begin with a letter and contain only letters, numbers, and underscores."
        /// </summary>
        internal static string EntityClient_InvalidParameterName(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_InvalidParameterName, p0);
        }

        /// <summary>
        ///     A string like "One of the parameters in the EntityParameterCollection is null or empty. A name must begin with a letter and contain only letters, numbers, and underscores. "
        /// </summary>
        internal static string EntityClient_EmptyParameterName
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_EmptyParameterName); }
        }

        /// <summary>
        ///     A string like "A null was returned after calling the '{0}' method on a store provider instance of type '{1}'. The store provider might not be functioning correctly."
        /// </summary>
        internal static string EntityClient_ReturnedNullOnProviderMethod(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityClient_ReturnedNullOnProviderMethod, p0, p1);
        }

        /// <summary>
        ///     A string like "The correct DbType cannot be inferred based on the value that has been set for the EntityParameter.DbType property."
        /// </summary>
        internal static string EntityClient_CannotDeduceDbType
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotDeduceDbType); }
        }

        /// <summary>
        ///     A string like "The parameter '{0}' is not an input-only parameter. The EntityClient provider only allows input-only parameters when the CommandType property is set to CommandText."
        /// </summary>
        internal static string EntityClient_InvalidParameterDirection(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_InvalidParameterDirection, p0);
        }

        /// <summary>
        ///     A string like "The EntityParameter '{0}' must have a value from which the DbType can be inferred, or a supported DbType must be set as the value of the EntityParameter.DbType property."
        /// </summary>
        internal static string EntityClient_UnknownParameterType(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_UnknownParameterType, p0);
        }

        /// <summary>
        ///     A string like "The DbType '{0}' is not valid for the EntityParameter.DbType property on the '{1}' object."
        /// </summary>
        internal static string EntityClient_UnsupportedDbType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityClient_UnsupportedDbType, p0, p1);
        }

        /// <summary>
        ///     A string like "The store provider factory type '{0}' does not implement the IServiceProvider interface. Use a store provider that implements this interface."
        /// </summary>
        internal static string EntityClient_DoesNotImplementIServiceProvider(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_DoesNotImplementIServiceProvider, p0);
        }

        /// <summary>
        ///     A string like "The declared type of navigation property {0}.{1} is not compatible with the result of the specified navigation. "
        /// </summary>
        internal static string EntityClient_IncompatibleNavigationPropertyResult(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityClient_IncompatibleNavigationPropertyResult, p0, p1);
        }

        /// <summary>
        ///     A string like "The connection is already in a transaction and cannot participate in another transaction. EntityClient does not support parallel transactions."
        /// </summary>
        internal static string EntityClient_TransactionAlreadyStarted
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_TransactionAlreadyStarted); }
        }

        /// <summary>
        ///     A string like "The transaction is either not associated with the current connection or has been completed."
        /// </summary>
        internal static string EntityClient_InvalidTransactionForCommand
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_InvalidTransactionForCommand); }
        }

        /// <summary>
        ///     A string like "The update operation cannot be performed, because the adapter's connection is not associated with a valid store connection."
        /// </summary>
        internal static string EntityClient_NoStoreConnectionForUpdate
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_NoStoreConnectionForUpdate); }
        }

        /// <summary>
        ///     A string like "The command could not be executed, because the connection metadata is incompatible with the command metadata."
        /// </summary>
        internal static string EntityClient_CommandTreeMetadataIncompatible
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CommandTreeMetadataIncompatible); }
        }

        /// <summary>
        ///     A string like "The underlying provider failed."
        /// </summary>
        internal static string EntityClient_ProviderGeneralError
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ProviderGeneralError); }
        }

        /// <summary>
        ///     A string like "The underlying provider failed on {0}."
        /// </summary>
        internal static string EntityClient_ProviderSpecificError(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_ProviderSpecificError, p0);
        }

        /// <summary>
        ///     A string like "EntityCommand.CommandText was not specified for the StoredProcedure EntityCommand."
        /// </summary>
        internal static string EntityClient_FunctionImportEmptyCommandText
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_FunctionImportEmptyCommandText); }
        }

        /// <summary>
        ///     A string like "The container '{0}' specified for the FunctionImport could not be found in the current workspace."
        /// </summary>
        internal static string EntityClient_UnableToFindFunctionImportContainer(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_UnableToFindFunctionImportContainer, p0);
        }

        /// <summary>
        ///     A string like "The FunctionImport '{1}' could not be found in the container '{0}'."
        /// </summary>
        internal static string EntityClient_UnableToFindFunctionImport(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityClient_UnableToFindFunctionImport, p0, p1);
        }

        /// <summary>
        ///     A string like "The function import '{0}' is composable. Only non-composable function imports can be executed as stored procedures."
        /// </summary>
        internal static string EntityClient_FunctionImportMustBeNonComposable(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_FunctionImportMustBeNonComposable, p0);
        }

        /// <summary>
        ///     A string like "The function import '{0}' cannot be executed because it is not mapped to a store function."
        /// </summary>
        internal static string EntityClient_UnmappedFunctionImport(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_UnmappedFunctionImport, p0);
        }

        /// <summary>
        ///     A string like "The value of EntityCommand.CommandText is not valid for a StoredProcedure command. The EntityCommand.CommandText value must be of the form 'ContainerName.FunctionImportName'."
        /// </summary>
        internal static string EntityClient_InvalidStoredProcedureCommandText
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_InvalidStoredProcedureCommandText); }
        }

        /// <summary>
        ///     A string like "MetadataWorkspace must have {0} pre-registered."
        /// </summary>
        internal static string EntityClient_ItemCollectionsNotRegisteredInWorkspace(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_ItemCollectionsNotRegisteredInWorkspace, p0);
        }

        /// <summary>
        ///     A string like "EntityConnection can only be constructed with a closed DbConnection."
        /// </summary>
        internal static string EntityClient_ConnectionMustBeClosed
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_ConnectionMustBeClosed); }
        }

        /// <summary>
        ///     A string like "The DbConnection parameter '{0}' contains no ProviderFactory."
        /// </summary>
        internal static string EntityClient_DbConnectionHasNoProvider(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_DbConnectionHasNoProvider, p0);
        }

        /// <summary>
        ///     A string like "EntityClient cannot be used to create a command definition from a store command tree."
        /// </summary>
        internal static string EntityClient_RequiresNonStoreCommandTree
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_RequiresNonStoreCommandTree); }
        }

        /// <summary>
        ///     A string like "This EntityCommand is based on a prepared command definition and cannot be re-prepared. To create an equivalent command with different parameters, create a new command definition and call its CreateCommand method."
        /// </summary>
        internal static string EntityClient_CannotReprepareCommandDefinitionBasedCommand
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotReprepareCommandDefinitionBasedCommand); }
        }

        /// <summary>
        ///     A string like "The EdmType '{0}' is not a scalar type."
        /// </summary>
        internal static string EntityClient_EntityParameterEdmTypeNotScalar(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityClient_EntityParameterEdmTypeNotScalar, p0);
        }

        /// <summary>
        ///     A string like "The EdmType '{0}' is not consistent with the DbType provided for parameter '{1}'."
        /// </summary>
        internal static string EntityClient_EntityParameterInconsistentEdmType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityClient_EntityParameterInconsistentEdmType, p0, p1);
        }

        /// <summary>
        ///     A string like "CommandText property value cannot be retrieved because the CommandTree property is not null."
        /// </summary>
        internal static string EntityClient_CannotGetCommandText
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotGetCommandText); }
        }

        /// <summary>
        ///     A string like "Cannot set the CommandText property value because the CommandTree property is not null."
        /// </summary>
        internal static string EntityClient_CannotSetCommandText
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotSetCommandText); }
        }

        /// <summary>
        ///     A string like "CommandTree property value cannot be retrieved because the CommandText property is not null."
        /// </summary>
        internal static string EntityClient_CannotGetCommandTree
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotGetCommandTree); }
        }

        /// <summary>
        ///     A string like "Cannot set the CommandTree property value because the CommandText property is not null."
        /// </summary>
        internal static string EntityClient_CannotSetCommandTree
        {
            get { return EntityRes.GetString(EntityRes.EntityClient_CannotSetCommandTree); }
        }

        /// <summary>
        ///     A string like "LINQ to Entities query expressions can only be constructed from instances that implement the IQueryable interface."
        /// </summary>
        internal static string ELinq_ExpressionMustBeIQueryable
        {
            get { return EntityRes.GetString(EntityRes.ELinq_ExpressionMustBeIQueryable); }
        }

        /// <summary>
        ///     A string like "The LINQ expression node type '{0}' is not supported in LINQ to Entities."
        /// </summary>
        internal static string ELinq_UnsupportedExpressionType(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedExpressionType, p0);
        }

        /// <summary>
        ///     A string like "The ObjectContext parameter ('{0}') in a compiled query can only be used as the source for queries."
        /// </summary>
        internal static string ELinq_UnsupportedUseOfContextParameter(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedUseOfContextParameter, p0);
        }

        /// <summary>
        ///     A string like "The parameter '{0}' was not bound in the specified LINQ to Entities query expression."
        /// </summary>
        internal static string ELinq_UnboundParameterExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnboundParameterExpression, p0);
        }

        /// <summary>
        ///     A string like "Only parameterless constructors and initializers are supported in LINQ to Entities."
        /// </summary>
        internal static string ELinq_UnsupportedConstructor
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedConstructor); }
        }

        /// <summary>
        ///     A string like "Only list initializer items with a single element are supported in LINQ to Entities."
        /// </summary>
        internal static string ELinq_UnsupportedInitializers
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedInitializers); }
        }

        /// <summary>
        ///     A string like "In constructors and initializers, only property or field parameter bindings are supported in LINQ to Entities."
        /// </summary>
        internal static string ELinq_UnsupportedBinding
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedBinding); }
        }

        /// <summary>
        ///     A string like "LINQ to Entities does not recognize the method '{0}' method, and this method cannot be translated into a store expression."
        /// </summary>
        internal static string ELinq_UnsupportedMethod(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedMethod, p0);
        }

        /// <summary>
        ///     A string like "The method '{0}' cannot be translated into a LINQ to Entities store expression. Consider using the method '{1}' instead."
        /// </summary>
        internal static string ELinq_UnsupportedMethodSuggestedAlternative(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedMethodSuggestedAlternative, p0, p1);
        }

        /// <summary>
        ///     A string like "The ThenBy method must follow either the OrderBy method or another call to the ThenBy method."
        /// </summary>
        internal static string ELinq_ThenByDoesNotFollowOrderBy
        {
            get { return EntityRes.GetString(EntityRes.ELinq_ThenByDoesNotFollowOrderBy); }
        }

        /// <summary>
        ///     A string like "The specified type member '{0}' is not supported in LINQ to Entities. Only initializers, entity members, and entity navigation properties are supported."
        /// </summary>
        internal static string ELinq_UnrecognizedMember(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnrecognizedMember, p0);
        }

        /// <summary>
        ///     A string like "The specified method '{0}' on the type '{1}' cannot be translated into a LINQ to Entities store expression."
        /// </summary>
        internal static string ELinq_UnresolvableFunctionForMethod(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnresolvableFunctionForMethod, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified method '{0}' on the type '{1}' cannot be translated into a LINQ to Entities store expression because one or more passed arguments match more than one function overload."
        /// </summary>
        internal static string ELinq_UnresolvableFunctionForMethodAmbiguousMatch(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnresolvableFunctionForMethodAmbiguousMatch, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified method '{0}' on the type '{1}' cannot be translated into a LINQ to Entities store expression because no overload matches the passed arguments."
        /// </summary>
        internal static string ELinq_UnresolvableFunctionForMethodNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnresolvableFunctionForMethodNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified member '{0}' on the type '{1}' cannot be translated into a LINQ to Entities store expression."
        /// </summary>
        internal static string ELinq_UnresolvableFunctionForMember(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnresolvableFunctionForMember, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified member '{0}' on the type '{1}' cannot be translated into a valid provider-specific LINQ to Entities store expression equivalent."
        /// </summary>
        internal static string ELinq_UnresolvableStoreFunctionForMember(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnresolvableStoreFunctionForMember, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified LINQ expression of type '{0}' cannot be translated into a LINQ to Entities store expression."
        /// </summary>
        internal static string ELinq_UnresolvableFunctionForExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnresolvableFunctionForExpression, p0);
        }

        /// <summary>
        ///     A string like "The specified LINQ expression of type '{0}' cannot be translated into a valid provider-specific LINQ to Entities store expression equivalent."
        /// </summary>
        internal static string ELinq_UnresolvableStoreFunctionForExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnresolvableStoreFunctionForExpression, p0);
        }

        /// <summary>
        ///     A string like "Unable to process the type '{0}', because it has no known mapping to the value layer."
        /// </summary>
        internal static string ELinq_UnsupportedType(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedType, p0);
        }

        /// <summary>
        ///     A string like "Unable to create a null constant value of type '{0}'. Only entity types, enumeration types or primitive types are supported in this context."
        /// </summary>
        internal static string ELinq_UnsupportedNullConstant(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedNullConstant, p0);
        }

        /// <summary>
        ///     A string like "Unable to create a constant value of type '{0}'. Only primitive types or enumeration types are supported in this context."
        /// </summary>
        internal static string ELinq_UnsupportedConstant(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedConstant, p0);
        }

        /// <summary>
        ///     A string like "Unable to cast the type '{0}' to type '{1}'. LINQ to Entities only supports casting EDM primitive or enumeration types."
        /// </summary>
        internal static string ELinq_UnsupportedCast(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedCast, p0, p1);
        }

        /// <summary>
        ///     A string like "The '{0}' expression with an input of type '{1}' and a check of type '{2}' is not supported. Only entity types and complex types are supported in LINQ to Entities queries."
        /// </summary>
        internal static string ELinq_UnsupportedIsOrAs(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedIsOrAs, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "This method is not supported against a materialized query result."
        /// </summary>
        internal static string ELinq_UnsupportedQueryableMethod
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedQueryableMethod); }
        }

        /// <summary>
        ///     A string like "'{0}' is not a valid metadata type for type filtering operations. Type filtering is only valid on entity types and complex types."
        /// </summary>
        internal static string ELinq_InvalidOfTypeResult(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_InvalidOfTypeResult, p0);
        }

        /// <summary>
        ///     A string like "The entity or complex type '{0}' cannot be constructed in a LINQ to Entities query."
        /// </summary>
        internal static string ELinq_UnsupportedNominalType(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedNominalType, p0);
        }

        /// <summary>
        ///     A string like "A type that implements IEnumerable '{0}' cannot be initialized in a LINQ to Entities query."
        /// </summary>
        internal static string ELinq_UnsupportedEnumerableType(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedEnumerableType, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' appears in two structurally incompatible initializations within a single LINQ to Entities query. A type can be initialized in two places in the same query, but only if the same properties are set in both places and those properties are set in the same order."
        /// </summary>
        internal static string ELinq_UnsupportedHeterogeneousInitializers(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedHeterogeneousInitializers, p0);
        }

        /// <summary>
        ///     A string like "The specified LINQ expression contains references to queries that are associated with different contexts."
        /// </summary>
        internal static string ELinq_UnsupportedDifferentContexts
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedDifferentContexts); }
        }

        /// <summary>
        ///     A string like "Casting to Decimal is not supported in LINQ to Entities queries, because the required precision and scale information cannot be inferred."
        /// </summary>
        internal static string ELinq_UnsupportedCastToDecimal
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedCastToDecimal); }
        }

        /// <summary>
        ///     A string like "The key selector type for the call to the '{0}' method is not comparable in the underlying store provider."
        /// </summary>
        internal static string ELinq_UnsupportedKeySelector(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedKeySelector, p0);
        }

        /// <summary>
        ///     A string like "Calling the CreateOrderedEnumerable generic method on the result of a LINQ to Entities query is not supported."
        /// </summary>
        internal static string ELinq_CreateOrderedEnumerableNotSupported
        {
            get { return EntityRes.GetString(EntityRes.ELinq_CreateOrderedEnumerableNotSupported); }
        }

        /// <summary>
        ///     A string like "The method '{0}' is not supported when called on an instance of type '{1}'."
        /// </summary>
        internal static string ELinq_UnsupportedPassthrough(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedPassthrough, p0, p1);
        }

        /// <summary>
        ///     A string like "A navigation property of type '{0}' is not valid. '{1}' or a single implementation of '{2}' was expected, but '{3}' was found."
        /// </summary>
        internal static string ELinq_UnexpectedTypeForNavigationProperty(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnexpectedTypeForNavigationProperty, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The method 'Skip' is only supported for sorted input in LINQ to Entities. The method 'OrderBy' must be called before the method 'Skip'."
        /// </summary>
        internal static string ELinq_SkipWithoutOrder
        {
            get { return EntityRes.GetString(EntityRes.ELinq_SkipWithoutOrder); }
        }

        /// <summary>
        ///     A string like "Property indexers are not supported in LINQ to Entities."
        /// </summary>
        internal static string ELinq_PropertyIndexNotSupported
        {
            get { return EntityRes.GetString(EntityRes.ELinq_PropertyIndexNotSupported); }
        }

        /// <summary>
        ///     A string like "The member '{0}' is not a property or a field."
        /// </summary>
        internal static string ELinq_NotPropertyOrField(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_NotPropertyOrField, p0);
        }

        /// <summary>
        ///     A string like "The method '{0}' is only supported in LINQ to Entities when the argument '{1}' is a non-negative integer constant."
        /// </summary>
        internal static string ELinq_UnsupportedStringRemoveCase(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedStringRemoveCase, p0, p1);
        }

        /// <summary>
        ///     A string like "The method '{0}' is only supported in LINQ to Entities when there are no trim characters specified as arguments."
        /// </summary>
        internal static string ELinq_UnsupportedTrimStartTrimEndCase(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedTrimStartTrimEndCase, p0);
        }

        /// <summary>
        ///     A string like "The method '{0}' is only supported in LINQ to Entities when the argument '{1}' is a constant."
        /// </summary>
        internal static string ELinq_UnsupportedVBDatePartNonConstantInterval(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedVBDatePartNonConstantInterval, p0, p1);
        }

        /// <summary>
        ///     A string like "The method '{0}' is not supported in LINQ to Entities when the argument '{1}' has the value '{2}'."
        /// </summary>
        internal static string ELinq_UnsupportedVBDatePartInvalidInterval(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedVBDatePartInvalidInterval, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The method '{0}' is only supported in LINQ to Entities when the argument is a string variable or literal."
        /// </summary>
        internal static string ELinq_UnsupportedAsUnicodeAndAsNonUnicode(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedAsUnicodeAndAsNonUnicode, p0);
        }

        /// <summary>
        ///     A string like "Cannot compare elements of type '{0}'. Only primitive types, enumeration types and entity types are supported."
        /// </summary>
        internal static string ELinq_UnsupportedComparison(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedComparison, p0);
        }

        /// <summary>
        ///     A string like "Cannot compare EntityKeys referring to types '{0}' and '{1}' because they do not share a common super-type."
        /// </summary>
        internal static string ELinq_UnsupportedRefComparison(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedRefComparison, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot compare '{0}'. Only primitive types, enumeration types and entity types are supported."
        /// </summary>
        internal static string ELinq_UnsupportedRowComparison(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedRowComparison, p0);
        }

        /// <summary>
        ///     A string like "member '{0}' of "
        /// </summary>
        internal static string ELinq_UnsupportedRowMemberComparison(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedRowMemberComparison, p0);
        }

        /// <summary>
        ///     A string like "type '{0}'"
        /// </summary>
        internal static string ELinq_UnsupportedRowTypeComparison(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnsupportedRowTypeComparison, p0);
        }

        /// <summary>
        ///     A string like "Anonymous type"
        /// </summary>
        internal static string ELinq_AnonymousType
        {
            get { return EntityRes.GetString(EntityRes.ELinq_AnonymousType); }
        }

        /// <summary>
        ///     A string like "Closure type"
        /// </summary>
        internal static string ELinq_ClosureType
        {
            get { return EntityRes.GetString(EntityRes.ELinq_ClosureType); }
        }

        /// <summary>
        ///     A string like "Unknown LINQ expression of type '{0}'."
        /// </summary>
        internal static string ELinq_UnhandledExpressionType(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnhandledExpressionType, p0);
        }

        /// <summary>
        ///     A string like "Unknown LINQ binding of type '{0}'."
        /// </summary>
        internal static string ELinq_UnhandledBindingType(object p0)
        {
            return EntityRes.GetString(EntityRes.ELinq_UnhandledBindingType, p0);
        }

        /// <summary>
        ///     A string like "The method 'First' can only be used as a final query operation. Consider using the method 'FirstOrDefault' in this instance instead."
        /// </summary>
        internal static string ELinq_UnsupportedNestedFirst
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedNestedFirst); }
        }

        /// <summary>
        ///     A string like "The methods 'Single' and 'SingleOrDefault' can only be used as a final query operation. Consider using the method 'FirstOrDefault' in this instance instead."
        /// </summary>
        internal static string ELinq_UnsupportedNestedSingle
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedNestedSingle); }
        }

        /// <summary>
        ///     A string like "The method 'Include' is only supported by LINQ to Entities when the argument is a string constant."
        /// </summary>
        internal static string ELinq_UnsupportedInclude
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedInclude); }
        }

        /// <summary>
        ///     A string like "The method 'MergeAs' is only supported by LINQ to Entities when the argument is a MergeOption constant."
        /// </summary>
        internal static string ELinq_UnsupportedMergeAs
        {
            get { return EntityRes.GetString(EntityRes.ELinq_UnsupportedMergeAs); }
        }

        /// <summary>
        ///     A string like "This method supports the LINQ to Entities infrastructure and is not intended to be used directly from your code."
        /// </summary>
        internal static string ELinq_MethodNotDirectlyCallable
        {
            get { return EntityRes.GetString(EntityRes.ELinq_MethodNotDirectlyCallable); }
        }

        /// <summary>
        ///     A string like "A cycle was detected in a LINQ expression."
        /// </summary>
        internal static string ELinq_CycleDetected
        {
            get { return EntityRes.GetString(EntityRes.ELinq_CycleDetected); }
        }

        /// <summary>
        ///     A string like "The specified method '{0}' on the type '{1}' cannot be translated into a LINQ to Entities store expression because the parameter {2} on its DbFunction attribute is empty."
        /// </summary>
        internal static string ELinq_DbFunctionAttributeParameterNameNotValid(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ELinq_DbFunctionAttributeParameterNameNotValid, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The specified method '{0}' on the type '{1}' cannot be translated into a LINQ to Entities store expression because its return type does not match the return type of the function specified by its DbFunction attribute."
        /// </summary>
        internal static string ELinq_DbFunctionAttributedFunctionWithWrongReturnType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ELinq_DbFunctionAttributedFunctionWithWrongReturnType, p0, p1);
        }

        /// <summary>
        ///     A string like "This function can only be invoked from LINQ to Entities."
        /// </summary>
        internal static string ELinq_DbFunctionDirectCall
        {
            get { return EntityRes.GetString(EntityRes.ELinq_DbFunctionDirectCall); }
        }

        /// <summary>
        ///     A string like "The specified parameter type '{0}' is not valid. Only scalar parameters (such as Int32, Decimal, and Guid) are supported."
        /// </summary>
        internal static string CompiledELinq_UnsupportedParameterTypes(object p0)
        {
            return EntityRes.GetString(EntityRes.CompiledELinq_UnsupportedParameterTypes, p0);
        }

        /// <summary>
        ///     A string like "The specified parameter '{0}' of type '{1}' is not valid. Only scalar parameters (such as Int32, Decimal, and Guid) are supported."
        /// </summary>
        internal static string CompiledELinq_UnsupportedNamedParameterType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.CompiledELinq_UnsupportedNamedParameterType, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified use of parameter '{0}' to produce a value of type '{1}' is not supported by LINQ to Entities in a compiled query."
        /// </summary>
        internal static string CompiledELinq_UnsupportedNamedParameterUseAsType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.CompiledELinq_UnsupportedNamedParameterUseAsType, p0, p1);
        }

        /// <summary>
        ///     A string like "Internal error. An unsupported expression kind ({0}) encountered in update mapping view by the ({1}) visitor."
        /// </summary>
        internal static string Update_UnsupportedExpressionKind(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Update_UnsupportedExpressionKind, p0, p1);
        }

        /// <summary>
        ///     A string like "Internal error. An unsupported type ({0}) was used as an argument to cast an expression in the update mapping view. The argument must be a scalar."
        /// </summary>
        internal static string Update_UnsupportedCastArgument(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_UnsupportedCastArgument, p0);
        }

        /// <summary>
        ///     A string like "Internal error. EntitySet ({0}) has unsupported type ({1}). Only EntitySets and AssociationSets can be processed in the update pipeline."
        /// </summary>
        internal static string Update_UnsupportedExtentType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Update_UnsupportedExtentType, p0, p1);
        }

        /// <summary>
        ///     A string like "Unable to determine a valid ordering for dependent operations. Dependencies may exist due to foreign key constraints, model requirements, or store-generated values."
        /// </summary>
        internal static string Update_ConstraintCycle
        {
            get { return EntityRes.GetString(EntityRes.Update_ConstraintCycle); }
        }

        /// <summary>
        ///     A string like "Internal error. An unsupported join type is in update mapping view ({0}). Only binary inner or left outer joins are supported."
        /// </summary>
        internal static string Update_UnsupportedJoinType(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_UnsupportedJoinType, p0);
        }

        /// <summary>
        ///     A string like "Internal error. Unsupported projection expression type ({0}). Only DBNewInstanceExpression projections are supported in update mapping views."
        /// </summary>
        internal static string Update_UnsupportedProjection(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_UnsupportedProjection, p0);
        }

        /// <summary>
        ///     A string like "Store update, insert, or delete statement affected an unexpected number of rows ({0}). Entities may have been modified or deleted since entities were loaded. Refresh ObjectStateManager entries."
        /// </summary>
        internal static string Update_ConcurrencyError(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_ConcurrencyError, p0);
        }

        /// <summary>
        ///     A string like "In order to update the AssociationSet '{0}', the corresponding entity from EntitySet '{1}' must be available in the ObjectStateManager."
        /// </summary>
        internal static string Update_MissingEntity(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Update_MissingEntity, p0, p1);
        }

        /// <summary>
        ///     A string like "Entities in '{0}' participate in the '{1}' relationship. '{2}' related '{3}' were found. Between {4} and {5} '{3}' are expected."
        /// </summary>
        internal static string Update_RelationshipCardinalityConstraintViolation(
            object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.Update_RelationshipCardinalityConstraintViolation, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "An error occurred while updating the entries. See the inner exception for details."
        /// </summary>
        internal static string Update_GeneralExecutionException
        {
            get { return EntityRes.GetString(EntityRes.Update_GeneralExecutionException); }
        }

        /// <summary>
        ///     A string like "A relationship from the '{0}' AssociationSet is in the '{1}' state. Given multiplicity constraints, a corresponding '{2}' must also in the '{1}' state."
        /// </summary>
        internal static string Update_MissingRequiredEntity(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Update_MissingRequiredEntity, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "At most, '{0}' relationships may be in the '{1}' state for the '{2}' relationship from End '{3}' to an instance of End '{4}'. '{5}' instances were found."
        /// </summary>
        internal static string Update_RelationshipCardinalityViolation(object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.Update_RelationshipCardinalityViolation, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "Modifications to tables where a primary key column has property '{0}' set to '{1}' are not supported. Use '{2}' pattern instead. Key column: '{3}'. Table: '{4}'."
        /// </summary>
        internal static string Update_NotSupportedComputedKeyColumn(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.Update_NotSupportedComputedKeyColumn, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "A value shared across entities or associations is generated in more than one location. Check that mapping does not split an EntityKey to multiple store-generated columns."
        /// </summary>
        internal static string Update_AmbiguousServerGenIdentifier
        {
            get { return EntityRes.GetString(EntityRes.Update_AmbiguousServerGenIdentifier); }
        }

        /// <summary>
        ///     A string like "The entity client's MetadataWorkspace differs from the workspace referenced by the state manager."
        /// </summary>
        internal static string Update_WorkspaceMismatch
        {
            get { return EntityRes.GetString(EntityRes.Update_WorkspaceMismatch); }
        }

        /// <summary>
        ///     A string like "A function mapping for EntitySet '{0}' requires that corresponding Associations in AssociationSet '{1}' are loaded. Load the AssociationSet before saving changes to this EntitySet."
        /// </summary>
        internal static string Update_MissingRequiredRelationshipValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Update_MissingRequiredRelationshipValue, p0, p1);
        }

        /// <summary>
        ///     A string like "A function mapping specifies a result column '{0}' that the result set does not contain."
        /// </summary>
        internal static string Update_MissingResultColumn(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_MissingResultColumn, p0);
        }

        /// <summary>
        ///     A string like "A null store-generated value was returned for a non-nullable member '{0}' of type '{1}'."
        /// </summary>
        internal static string Update_NullReturnValueForNonNullableMember(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Update_NullReturnValueForNonNullableMember, p0, p1);
        }

        /// <summary>
        ///     A string like "A store-generated value of type '{0}' could not be converted to a value of type '{1}' required for member '{2}' of type '{3}'."
        /// </summary>
        internal static string Update_ReturnValueHasUnexpectedType(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Update_ReturnValueHasUnexpectedType, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "Unable to determine rows affected. The value of parameter '{0}' is not convertible to '{1}'."
        /// </summary>
        internal static string Update_UnableToConvertRowsAffectedParameter(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Update_UnableToConvertRowsAffectedParameter, p0, p1);
        }

        /// <summary>
        ///     A string like "Update Mapping not found for EntitySet '{0}'."
        /// </summary>
        internal static string Update_MappingNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_MappingNotFound, p0);
        }

        /// <summary>
        ///     A string like "Modifying a column with the '{0}' pattern is not supported. Column: '{1}'. Table: '{2}'."
        /// </summary>
        internal static string Update_ModifyingIdentityColumn(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Update_ModifyingIdentityColumn, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "A dependent property in a ReferentialConstraint is mapped to a store-generated column. Column: '{0}'."
        /// </summary>
        internal static string Update_GeneratedDependent(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_GeneratedDependent, p0);
        }

        /// <summary>
        ///     A string like "Referential integrity constraint violation. A Dependent Role has multiple principals with different values."
        /// </summary>
        internal static string Update_ReferentialConstraintIntegrityViolation
        {
            get { return EntityRes.GetString(EntityRes.Update_ReferentialConstraintIntegrityViolation); }
        }

        /// <summary>
        ///     A string like "Error retrieving values from ObjectStateEntry. See inner exception for details."
        /// </summary>
        internal static string Update_ErrorLoadingRecord
        {
            get { return EntityRes.GetString(EntityRes.Update_ErrorLoadingRecord); }
        }

        /// <summary>
        ///     A string like "Null value for non-nullable member. Member: '{0}'."
        /// </summary>
        internal static string Update_NullValue(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_NullValue, p0);
        }

        /// <summary>
        ///     A string like "Circular relationships with referential integrity constraints detected."
        /// </summary>
        internal static string Update_CircularRelationships
        {
            get { return EntityRes.GetString(EntityRes.Update_CircularRelationships); }
        }

        /// <summary>
        ///     A string like "Entities in '{0}' participate in the '{1}' relationship. {2} related '{3}' were found. {4} '{3}' is expected."
        /// </summary>
        internal static string Update_RelationshipCardinalityConstraintViolationSingleValue(
            object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.Update_RelationshipCardinalityConstraintViolationSingleValue, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "Cannot find the {0}FunctionMapping for {1} '{2}' in the mapping file."
        /// </summary>
        internal static string Update_MissingFunctionMapping(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Update_MissingFunctionMapping, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Invalid data encountered. A required relationship is missing. Examine StateEntries to determine the source of the constraint violation."
        /// </summary>
        internal static string Update_InvalidChanges
        {
            get { return EntityRes.GetString(EntityRes.Update_InvalidChanges); }
        }

        /// <summary>
        ///     A string like "Conflicting changes detected. This may happen when trying to insert multiple entities with the same key."
        /// </summary>
        internal static string Update_DuplicateKeys
        {
            get { return EntityRes.GetString(EntityRes.Update_DuplicateKeys); }
        }

        /// <summary>
        ///     A string like "Unable to determine the principal end of the '{0}' relationship. Multiple added entities may have the same primary key."
        /// </summary>
        internal static string Update_AmbiguousForeignKey(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_AmbiguousForeignKey, p0);
        }

        /// <summary>
        ///     A string like "Unable to insert or update an entity because the principal end of the '{0}' relationship is deleted."
        /// </summary>
        internal static string Update_InsertingOrUpdatingReferenceToDeletedEntity(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_InsertingOrUpdatingReferenceToDeletedEntity, p0);
        }

        /// <summary>
        ///     A string like "Set"
        /// </summary>
        internal static string ViewGen_Extent
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_Extent); }
        }

        /// <summary>
        ///     A string like "NULL"
        /// </summary>
        internal static string ViewGen_Null
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_Null); }
        }

        /// <summary>
        ///     A string like ", "
        /// </summary>
        internal static string ViewGen_CommaBlank
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_CommaBlank); }
        }

        /// <summary>
        ///     A string like "entities"
        /// </summary>
        internal static string ViewGen_Entities
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_Entities); }
        }

        /// <summary>
        ///     A string like "rows"
        /// </summary>
        internal static string ViewGen_Tuples
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_Tuples); }
        }

        /// <summary>
        ///     A string like "NOT_NULL"
        /// </summary>
        internal static string ViewGen_NotNull
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_NotNull); }
        }

        /// <summary>
        ///     A string like "Values other than [{0}]"
        /// </summary>
        internal static string ViewGen_NegatedCellConstant(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_NegatedCellConstant, p0);
        }

        /// <summary>
        ///     A string like "ERROR"
        /// </summary>
        internal static string ViewGen_Error
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_Error); }
        }

        /// <summary>
        ///     A string like "AND "
        /// </summary>
        internal static string ViewGen_AND
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_AND); }
        }

        /// <summary>
        ///     A string like "Insufficient or contradictory mapping. Cannot generate query views for entities in {0} when:"
        /// </summary>
        internal static string Viewgen_CannotGenerateQueryViewUnderNoValidation(object p0)
        {
            return EntityRes.GetString(EntityRes.Viewgen_CannotGenerateQueryViewUnderNoValidation, p0);
        }

        /// <summary>
        ///     A string like "No mapping specified for instances of the EntitySet and AssociationSet in the EntityContainer {0}."
        /// </summary>
        internal static string ViewGen_Missing_Sets_Mapping(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Missing_Sets_Mapping, p0);
        }

        /// <summary>
        ///     A string like "No mapping specified for the following types - {0}."
        /// </summary>
        internal static string ViewGen_Missing_Type_Mapping(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Missing_Type_Mapping, p0);
        }

        /// <summary>
        ///     A string like "No mapping specified for the following EntitySet/AssociationSet - {0}."
        /// </summary>
        internal static string ViewGen_Missing_Set_Mapping(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Missing_Set_Mapping, p0);
        }

        /// <summary>
        ///     A string like "Cannot define new concurrency token member {0} in the derived class {1} of EntitySet {2}."
        /// </summary>
        internal static string ViewGen_Concurrency_Derived_Class(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Concurrency_Derived_Class, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Concurrency token(s) [{0}] in EntitySet {1} must not have a condition."
        /// </summary>
        internal static string ViewGen_Concurrency_Invalid_Condition(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Concurrency_Invalid_Condition, p0, p1);
        }

        /// <summary>
        ///     A string like "Must specify mapping for all key properties ({0}) of table {1}."
        /// </summary>
        internal static string ViewGen_TableKey_Missing(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_TableKey_Missing, p0, p1);
        }

        /// <summary>
        ///     A string like "Must specify mapping for all key properties ({0}) of the EntitySet {1}."
        /// </summary>
        internal static string ViewGen_EntitySetKey_Missing(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_EntitySetKey_Missing, p0, p1);
        }

        /// <summary>
        ///     A string like "Must specify mapping for all key properties ({0}) of End {1} in Relationship {2}."
        /// </summary>
        internal static string ViewGen_AssociationSetKey_Missing(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_AssociationSetKey_Missing, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "No mapping specified for properties {0} in {1} {2}."
        /// </summary>
        internal static string ViewGen_Cannot_Recover_Attributes(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Cannot_Recover_Attributes, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Must specify mapping for all types in {0} {1}."
        /// </summary>
        internal static string ViewGen_Cannot_Recover_Types(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Cannot_Recover_Types, p0, p1);
        }

        /// <summary>
        ///     A string like "Insufficient mapping: It is possible to have {0} within {1} that are not mapped."
        /// </summary>
        internal static string ViewGen_Cannot_Disambiguate_MultiConstant(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Cannot_Disambiguate_MultiConstant, p0, p1);
        }

        /// <summary>
        ///     A string like "Column {1} in table {0} must be mapped: It has no default value and is not nullable."
        /// </summary>
        internal static string ViewGen_No_Default_Value(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_No_Default_Value, p0, p1);
        }

        /// <summary>
        ///     A string like "Column {0} has no default value and is not nullable. A column value is required to store entity data."
        /// </summary>
        internal static string ViewGen_No_Default_Value_For_Configuration(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_No_Default_Value_For_Configuration, p0);
        }

        /// <summary>
        ///     A string like "Potential runtime violation of table {0}'s keys ({2}): Columns ({1}) are mapped to EntitySet {3}'s properties ({4}) on the conceptual side but they do not form the EntitySet's key properties ({5})."
        /// </summary>
        internal static string ViewGen_KeyConstraint_Violation(object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.ViewGen_KeyConstraint_Violation, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "All the key properties ({0}) of the EntitySet {1} must be mapped to all the key properties ({2}) of table {3}."
        /// </summary>
        internal static string ViewGen_KeyConstraint_Update_Violation_EntitySet(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ViewGen_KeyConstraint_Update_Violation_EntitySet, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "At least one of the key properties of AssociationSet {0} must be mapped to all the key properties ({1}) of table {2}."
        /// </summary>
        internal static string ViewGen_KeyConstraint_Update_Violation_AssociationSet(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_KeyConstraint_Update_Violation_AssociationSet, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Given the cardinality of Association End Member {0}, it should be mapped to key columns of the table {1}. Either fix the mapping or change the multiplicity of this end."
        /// </summary>
        internal static string ViewGen_AssociationEndShouldBeMappedToKey(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_AssociationEndShouldBeMappedToKey, p0, p1);
        }

        /// <summary>
        ///     A string like "Each of the following columns in table {0} is mapped to multiple conceptual side properties:"
        /// </summary>
        internal static string ViewGen_Duplicate_CProperties(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Duplicate_CProperties, p0);
        }

        /// <summary>
        ///     A string like "{0} is mapped to <{1}>"
        /// </summary>
        internal static string ViewGen_Duplicate_CProperties_IsMapped(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Duplicate_CProperties_IsMapped, p0, p1);
        }

        /// <summary>
        ///     A string like "Property {0} with 'IsNull=false' condition must be mapped."
        /// </summary>
        internal static string ViewGen_NotNull_No_Projected_Slot(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_NotNull_No_Projected_Slot, p0);
        }

        /// <summary>
        ///     A string like "Conditions specified on member {0} in this fragment are not allowed."
        /// </summary>
        internal static string ViewGen_InvalidCondition(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_InvalidCondition, p0);
        }

        /// <summary>
        ///     A string like "Column(s) [{0}] are being mapped in both fragments to different conceptual side properties."
        /// </summary>
        internal static string ViewGen_NonKeyProjectedWithOverlappingPartitions(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_NonKeyProjectedWithOverlappingPartitions, p0);
        }

        /// <summary>
        ///     A string like "Data loss or key constraint violation is possible in table {0}."
        /// </summary>
        internal static string ViewGen_CQ_PartitionConstraint(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_CQ_PartitionConstraint, p0);
        }

        /// <summary>
        ///     A string like "Data loss is possible in {0}."
        /// </summary>
        internal static string ViewGen_CQ_DomainConstraint(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_CQ_DomainConstraint, p0);
        }

        /// <summary>
        ///     A string like "{0} must be non-nullable"
        /// </summary>
        internal static string ViewGen_OneOfConst_MustBeNonNullable(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_MustBeNonNullable, p0);
        }

        /// <summary>
        ///     A string like "{0} must be null"
        /// </summary>
        internal static string ViewGen_OneOfConst_MustBeNull(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_MustBeNull, p0);
        }

        /// <summary>
        ///     A string like "{0} must be equal to {1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_MustBeEqualTo(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_MustBeEqualTo, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} must not be equal to {1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_MustNotBeEqualTo(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_MustNotBeEqualTo, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} must be one of {1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_MustBeOneOf(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_MustBeOneOf, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} must not be one of {1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_MustNotBeOneOf(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_MustNotBeOneOf, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} is non-nullable"
        /// </summary>
        internal static string ViewGen_OneOfConst_IsNonNullable(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_IsNonNullable, p0);
        }

        /// <summary>
        ///     A string like "{0} ={1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_IsEqualTo(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_IsEqualTo, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} is not equal to {1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_IsNotEqualTo(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_IsNotEqualTo, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} is one of {1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_IsOneOf(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_IsOneOf, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} is not one of {1}"
        /// </summary>
        internal static string ViewGen_OneOfConst_IsNotOneOf(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_IsNotOneOf, p0, p1);
        }

        /// <summary>
        ///     A string like ", (for example, is one of the following type(s): {0})"
        /// </summary>
        internal static string ViewGen_OneOfConst_IsOneOfTypes(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_OneOfConst_IsOneOfTypes, p0);
        }

        /// <summary>
        ///     A string like "Problem in mapping fragments starting at line {0}:"
        /// </summary>
        internal static string ViewGen_ErrorLog(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_ErrorLog, p0);
        }

        /// <summary>
        ///     A string like "Problem in mapping fragments starting at lines {0}:"
        /// </summary>
        internal static string ViewGen_ErrorLog2(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_ErrorLog2, p0);
        }

        /// <summary>
        ///     A string like "Missing table mapping: {0} no mapping specified for the table {1}."
        /// </summary>
        internal static string ViewGen_Foreign_Key_Missing_Table_Mapping(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key_Missing_Table_Mapping, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} The columns of table {1} are mapped to AssociationSet {2}'s End {3} but the key columns of table {4} are not mapped to the keys of the EntitySet {5} corresponding to this End."
        /// </summary>
        internal static string ViewGen_Foreign_Key_ParentTable_NotMappedToEnd(
            object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key_ParentTable_NotMappedToEnd, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "Foreign key constraint '{0}' from table {1} ({2}) to table {3} ({4}):"
        /// </summary>
        internal static string ViewGen_Foreign_Key(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like " {0} is mapped to AssociationSet  {1} - for this mapping to be correct, the upper multiplicity bound of end {2} needs to be 1."
        /// </summary>
        internal static string ViewGen_Foreign_Key_UpperBound_MustBeOne(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key_UpperBound_MustBeOne, p0, p1, p2);
        }

        /// <summary>
        ///     A string like " {0} is mapped to AssociationSet {1} - for this mapping to be correct, the lower multiplicity bound of end {2} needs to be 1."
        /// </summary>
        internal static string ViewGen_Foreign_Key_LowerBound_MustBeOne(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key_LowerBound_MustBeOne, p0, p1, p2);
        }

        /// <summary>
        ///     A string like " {0}: Insufficient mapping: Foreign key must be mapped to some AssociationSet or EntitySets participating in a foreign key association on the conceptual side."
        /// </summary>
        internal static string ViewGen_Foreign_Key_Missing_Relationship_Mapping(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key_Missing_Relationship_Mapping, p0);
        }

        /// <summary>
        ///     A string like "The foreign key '{0}' is not being enforced in the model. An Association or inheritance relationship needs to be created to enforce this constraint."
        /// </summary>
        internal static string ViewGen_Foreign_Key_Not_Guaranteed_InCSpace(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key_Not_Guaranteed_InCSpace, p0);
        }

        /// <summary>
        ///     A string like "Incorrect mapping of composite key columns. {0} Columns ({1}) in table {2} are mapped to properties ({3}) in {4} and columns ({5}) in table {6} are mapped to properties ({7}) in {8}. The order of the columns through the mappings is not preserved."
        /// </summary>
        internal static string ViewGen_Foreign_Key_ColumnOrder_Incorrect(
            object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8)
        {
            return EntityRes.GetString(EntityRes.ViewGen_Foreign_Key_ColumnOrder_Incorrect, p0, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        /// <summary>
        ///     A string like " {0} plays Role '{1}' in AssociationSet '{2}'"
        /// </summary>
        internal static string ViewGen_AssociationSet_AsUserString(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_AssociationSet_AsUserString, p0, p1, p2);
        }

        /// <summary>
        ///     A string like " {0} does NOT play Role '{1}' in AssociationSet '{2}'"
        /// </summary>
        internal static string ViewGen_AssociationSet_AsUserString_Negated(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ViewGen_AssociationSet_AsUserString_Negated, p0, p1, p2);
        }

        /// <summary>
        ///     A string like " {0} is in '{1}' EntitySet"
        /// </summary>
        internal static string ViewGen_EntitySet_AsUserString(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_EntitySet_AsUserString, p0, p1);
        }

        /// <summary>
        ///     A string like " {0} is NOT in '{1}' EntitySet"
        /// </summary>
        internal static string ViewGen_EntitySet_AsUserString_Negated(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ViewGen_EntitySet_AsUserString_Negated, p0, p1);
        }

        /// <summary>
        ///     A string like "Entity"
        /// </summary>
        internal static string ViewGen_EntityInstanceToken
        {
            get { return EntityRes.GetString(EntityRes.ViewGen_EntityInstanceToken); }
        }

        /// <summary>
        ///     A string like "An Entity with Key ({0}) will not round-trip when:"
        /// </summary>
        internal static string Viewgen_ConfigurationErrorMsg(object p0)
        {
            return EntityRes.GetString(EntityRes.Viewgen_ConfigurationErrorMsg, p0);
        }

        /// <summary>
        ///     A string like "The mapping and metadata information for EntityContainer '{0}' no longer matches the information used to create the pre-generated views."
        /// </summary>
        internal static string ViewGen_HashOnMappingClosure_Not_Matching(object p0)
        {
            return EntityRes.GetString(EntityRes.ViewGen_HashOnMappingClosure_Not_Matching, p0);
        }

        /// <summary>
        ///     A string like "Ensure that mapping fragments for EntitySet {0} do not map entities with the same primary key to different rows of the same table."
        /// </summary>
        internal static string Viewgen_RightSideNotDisjoint(object p0)
        {
            return EntityRes.GetString(EntityRes.Viewgen_RightSideNotDisjoint, p0);
        }

        /// <summary>
        ///     A string like "Could not validate mapping for EntitySet {0}. Check that the mapping constraints are possible in the presence of store side constraints. Having an 'IsNull=True' condition in the mapping for a non-nullable column is an example of an impossible constraint."
        /// </summary>
        internal static string Viewgen_QV_RewritingNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.Viewgen_QV_RewritingNotFound, p0);
        }

        /// <summary>
        ///     A string like "Non-nullable column {1} in table {0} is mapped to a nullable entity property."
        /// </summary>
        internal static string Viewgen_NullableMappingForNonNullableColumn(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Viewgen_NullableMappingForNonNullableColumn, p0, p1);
        }

        /// <summary>
        ///     A string like "Condition member '{0}' with a condition other than 'IsNull=False' is mapped. Either remove the condition on {0} or remove it from the mapping."
        /// </summary>
        internal static string Viewgen_ErrorPattern_ConditionMemberIsMapped(object p0)
        {
            return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_ConditionMemberIsMapped, p0);
        }

        /// <summary>
        ///     A string like "Condition members {0} have duplicate condition values."
        /// </summary>
        internal static string Viewgen_ErrorPattern_DuplicateConditionValue(object p0)
        {
            return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_DuplicateConditionValue, p0);
        }

        /// <summary>
        ///     A string like "EntitySets '{1}' and '{2}' are both mapped to table '{0}'. Their primary keys may collide."
        /// </summary>
        internal static string Viewgen_ErrorPattern_TableMappedToMultipleES(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_TableMappedToMultipleES, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "An entity is mapped to different rows within the same table. Ensure these two mapping fragments do not map two groups of entities with identical keys to two distinct groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Disj_Eq
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Disj_Eq); }
        }

        /// <summary>
        ///     A string like "Column {0} is used in a Not Null condition but it is mapped to a property {1} which is nullable. Consider making this property non-nullable."
        /// </summary>
        internal static string Viewgen_ErrorPattern_NotNullConditionMappedToNullableMember(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_NotNullConditionMappedToNullableMember, p0, p1);
        }

        /// <summary>
        ///     A string like "EntityTypes {0} are being mapped to the same rows in table {1}. Mapping conditions can be used to distinguish the rows that these types are mapped to."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_MultipleTypesMappedToSameTable_WithoutCondition(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_MultipleTypesMappedToSameTable_WithoutCondition, p0, p1);
        }

        /// <summary>
        ///     A string like "Two entities with identical keys are mapped to different rows within the same table. Ensure these two mapping fragments do not map two groups of entities with overlapping keys to two distinct groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Disj_Subs_Ref
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Disj_Subs_Ref); }
        }

        /// <summary>
        ///     A string like "An entity is mapped to different rows within the same table. Ensure these two mapping fragments do not map two groups of entities with overlapping keys to two distinct groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Disj_Subs
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Disj_Subs); }
        }

        /// <summary>
        ///     A string like "Two entities with possibly identical keys are mapped to different rows within the same table. Ensure these two mapping fragments do not map two unrelated EntitySets to two distinct groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Disj_Unk
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Disj_Unk); }
        }

        /// <summary>
        ///     A string like "Two entities with different keys are mapped to the same row. Ensure these two mapping fragments do not map two groups of entities with different keys to the same group of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Eq_Disj
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Eq_Disj); }
        }

        /// <summary>
        ///     A string like "Two entities with different keys are mapped to the same row. Ensure these two mapping fragments do not map two EntitySets with overlapping keys to the same group of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Eq_Subs_Ref
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Eq_Subs_Ref); }
        }

        /// <summary>
        ///     A string like "Two entities with different keys are mapped to the same row. Ensure these two mapping fragments do not map two groups of entities with overlapping keys to the same group of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Eq_Subs
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Eq_Subs); }
        }

        /// <summary>
        ///     A string like "Two entities with possibly different keys are mapped to the same row. Ensure these two mapping fragments do not map two unrelated EntitySets to the same group of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Eq_Unk
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Eq_Unk); }
        }

        /// <summary>
        ///     A string like "Two entities with possibly different keys are mapped to the same row. Ensure these two mapping fragments map both ends of the AssociationSet to the corresponding columns."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Eq_Unk_Association
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Eq_Unk_Association); }
        }

        /// <summary>
        ///     A string like "Two entities with different keys are mapped to the same row. Ensure these two mapping fragments do not map two groups of entities with different keys to two overlapping groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Sub_Disj
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Sub_Disj); }
        }

        /// <summary>
        ///     A string like "Two rows with different primary keys are mapped to the same entity. Ensure these two mapping fragments do not map two groups of entities with identical keys to two overlapping groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Sub_Eq
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Sub_Eq); }
        }

        /// <summary>
        ///     A string like "Two rows with different primary keys are mapped to two entities that carry identical keys through a referential integrity constraint. Ensure these two mapping fragments do not map two EntitySets with identical keys to two overlapping groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Sub_Eq_Ref
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Sub_Eq_Ref); }
        }

        /// <summary>
        ///     A string like "An entity from one EntitySet is mapped to a row that is also mapped to an entity from another EntitySet with possibly different key. Ensure these two mapping fragments do not map two unrelated EntitySets to two overlapping groups of rows."
        /// </summary>
        internal static string Viewgen_ErrorPattern_Partition_Sub_Unk
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_ErrorPattern_Partition_Sub_Unk); }
        }

        /// <summary>
        ///     A string like "Mapping fragments cannot be joined. Ensure every mapping fragment maps a key on which it should be joined with one of the other mapping fragments."
        /// </summary>
        internal static string Viewgen_NoJoinKeyOrFK
        {
            get { return EntityRes.GetString(EntityRes.Viewgen_NoJoinKeyOrFK); }
        }

        /// <summary>
        ///     A string like "When there is a mapping fragment between EntitySet '{0}' and Table '{1}' with MakeColumnsDistinct attribute marked to 'true', there can be no additional mapping fragments between '{0}' and '{1}'."
        /// </summary>
        internal static string Viewgen_MultipleFragmentsBetweenCandSExtentWithDistinct(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Viewgen_MultipleFragmentsBetweenCandSExtentWithDistinct, p0, p1);
        }

        /// <summary>
        ///     A string like "Item has an empty identity."
        /// </summary>
        internal static string Validator_EmptyIdentity
        {
            get { return EntityRes.GetString(EntityRes.Validator_EmptyIdentity); }
        }

        /// <summary>
        ///     A string like "CollectionType has a null type usage."
        /// </summary>
        internal static string Validator_CollectionHasNoTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.Validator_CollectionHasNoTypeUsage); }
        }

        /// <summary>
        ///     A string like "The type '{0}' doesn't have any key members. A RelationshipType or EntityType must either have key members or a BaseType with key members."
        /// </summary>
        internal static string Validator_NoKeyMembers(object p0)
        {
            return EntityRes.GetString(EntityRes.Validator_NoKeyMembers, p0);
        }

        /// <summary>
        ///     A string like "The facet object has null for the FacetType. Null is not valid for this property."
        /// </summary>
        internal static string Validator_FacetTypeIsNull
        {
            get { return EntityRes.GetString(EntityRes.Validator_FacetTypeIsNull); }
        }

        /// <summary>
        ///     A string like "The member has null for the DeclaringType. Null is not valid for this property."
        /// </summary>
        internal static string Validator_MemberHasNullDeclaringType
        {
            get { return EntityRes.GetString(EntityRes.Validator_MemberHasNullDeclaringType); }
        }

        /// <summary>
        ///     A string like "The member has null for the MemberTypeUsage. Null is not valid for this property."
        /// </summary>
        internal static string Validator_MemberHasNullTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.Validator_MemberHasNullTypeUsage); }
        }

        /// <summary>
        ///     A string like "The item property has null for TypeUsage. Null is not valid for this property."
        /// </summary>
        internal static string Validator_ItemAttributeHasNullTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.Validator_ItemAttributeHasNullTypeUsage); }
        }

        /// <summary>
        ///     A string like "The RefType has null for EntityType. Null is not valid for this property."
        /// </summary>
        internal static string Validator_RefTypeHasNullEntityType
        {
            get { return EntityRes.GetString(EntityRes.Validator_RefTypeHasNullEntityType); }
        }

        /// <summary>
        ///     A string like "The type usage object has null for EdmType. Null is not valid for this property."
        /// </summary>
        internal static string Validator_TypeUsageHasNullEdmType
        {
            get { return EntityRes.GetString(EntityRes.Validator_TypeUsageHasNullEdmType); }
        }

        /// <summary>
        ///     A string like "A member of the same name is already defined in a BaseType."
        /// </summary>
        internal static string Validator_BaseTypeHasMemberOfSameName
        {
            get { return EntityRes.GetString(EntityRes.Validator_BaseTypeHasMemberOfSameName); }
        }

        /// <summary>
        ///     A string like "CollectionType objects cannot have a base type."
        /// </summary>
        internal static string Validator_CollectionTypesCannotHaveBaseType
        {
            get { return EntityRes.GetString(EntityRes.Validator_CollectionTypesCannotHaveBaseType); }
        }

        /// <summary>
        ///     A string like "Reference types cannot have a base type."
        /// </summary>
        internal static string Validator_RefTypesCannotHaveBaseType
        {
            get { return EntityRes.GetString(EntityRes.Validator_RefTypesCannotHaveBaseType); }
        }

        /// <summary>
        ///     A string like "The type does not have a name."
        /// </summary>
        internal static string Validator_TypeHasNoName
        {
            get { return EntityRes.GetString(EntityRes.Validator_TypeHasNoName); }
        }

        /// <summary>
        ///     A string like "The type does not have a namespace."
        /// </summary>
        internal static string Validator_TypeHasNoNamespace
        {
            get { return EntityRes.GetString(EntityRes.Validator_TypeHasNoNamespace); }
        }

        /// <summary>
        ///     A string like "The facet does not have a name."
        /// </summary>
        internal static string Validator_FacetHasNoName
        {
            get { return EntityRes.GetString(EntityRes.Validator_FacetHasNoName); }
        }

        /// <summary>
        ///     A string like "The member does not have a name."
        /// </summary>
        internal static string Validator_MemberHasNoName
        {
            get { return EntityRes.GetString(EntityRes.Validator_MemberHasNoName); }
        }

        /// <summary>
        ///     A string like "The metadata property does not have a name."
        /// </summary>
        internal static string Validator_MetadataPropertyHasNoName
        {
            get { return EntityRes.GetString(EntityRes.Validator_MetadataPropertyHasNoName); }
        }

        /// <summary>
        ///     A string like "EntityKeyProperty and IsNullable cannot both be true in the EdmScalarPropertyAttribute for property '{0}' on type '{1}'. Properties that are part of the key cannot be nullable."
        /// </summary>
        internal static string Validator_NullableEntityKeyProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Validator_NullableEntityKeyProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' has the return type '{2}', which is not a recognized EntityType or enumeration of instances of EntityType."
        /// </summary>
        internal static string Validator_OSpace_InvalidNavPropReturnType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_InvalidNavPropReturnType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is attributed with EdmScalarPropertyAttribute but returns the type '{2}', which is not a primitive type or a recognized enumeration type."
        /// </summary>
        internal static string Validator_OSpace_ScalarPropertyNotPrimitive(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_ScalarPropertyNotPrimitive, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' is attributed with EdmComplexPropertyAttribute but returns the type '{2}', which is not a recognized ComplexType."
        /// </summary>
        internal static string Validator_OSpace_ComplexPropertyNotComplex(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_ComplexPropertyNotComplex, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Multiple types with the name '{0}' exist in the EdmItemCollection in different namespaces.  Convention based mapping requires unique names without regard to namespace in the EdmItemCollection."
        /// </summary>
        internal static string Validator_OSpace_Convention_MultipleTypesWithSameName(object p0)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_MultipleTypesWithSameName, p0);
        }

        /// <summary>
        ///     A string like "The property '{0}' on the type '{1}' has a property type of '{2}' which cannot be mapped to a primitive type."
        /// </summary>
        internal static string Validator_OSpace_Convention_NonPrimitiveTypeProperty(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_NonPrimitiveTypeProperty, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The required property '{0}' does not exist on the type '{1}'."
        /// </summary>
        internal static string Validator_OSpace_Convention_MissingRequiredProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_MissingRequiredProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The base type '{0}' of type '{1}' does not match the model base type '{2}'."
        /// </summary>
        internal static string Validator_OSpace_Convention_BaseTypeIncompatible(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_BaseTypeIncompatible, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "No corresponding object layer type could be found for the conceptual type '{0}'."
        /// </summary>
        internal static string Validator_OSpace_Convention_MissingOSpaceType(object p0)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_MissingOSpaceType, p0);
        }

        /// <summary>
        ///     A string like "The relationship '{0}' was not loaded because the type '{1}' is not available."
        /// </summary>
        internal static string Validator_OSpace_Convention_RelationshipNotLoaded(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_RelationshipNotLoaded, p0, p1);
        }

        /// <summary>
        ///     A string like "The types in the assembly '{0}' cannot be loaded because the assembly contains the EdmSchemaAttribute, and the closure of types is being loaded by name.  Loading by both name and attribute is not allowed."
        /// </summary>
        internal static string Validator_OSpace_Convention_AttributeAssemblyReferenced(object p0)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_AttributeAssemblyReferenced, p0);
        }

        /// <summary>
        ///     A string like "The property '{0}' of type '{1}' in the assembly '{2}' cannot be used as a scalar property because it does not have both a getter and setter."
        /// </summary>
        internal static string Validator_OSpace_Convention_ScalarPropertyMissginGetterOrSetter(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_ScalarPropertyMissginGetterOrSetter, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The mapping of CLR type to EDM type is ambiguous because multiple CLR types match the EDM type '{0}'. Previously found CLR type '{1}', newly found CLR type '{2}'."
        /// </summary>
        internal static string Validator_OSpace_Convention_AmbiguousClrType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_AmbiguousClrType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The EntityType or ComplexType '{0}' cannot be mapped by convention to the value type '{1}'.  Value types are not allowed to be mapped to EntityTypes or ComplexTypes."
        /// </summary>
        internal static string Validator_OSpace_Convention_Struct(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_Struct, p0, p1);
        }

        /// <summary>
        ///     A string like "The type '{0}' was not loaded because the base type '{1}' is not available."
        /// </summary>
        internal static string Validator_OSpace_Convention_BaseTypeNotLoaded(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_BaseTypeNotLoaded, p0, p1);
        }

        /// <summary>
        ///     A string like "Type '{0}' defined in the object layer is not compatible with type '{1}' defined in the conceptual model. An enumeration type cannot be mapped to a non-enumeration type."
        /// </summary>
        internal static string Validator_OSpace_Convention_SSpaceOSpaceTypeMismatch(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_SSpaceOSpaceTypeMismatch, p0, p1);
        }

        /// <summary>
        ///     A string like "The underlying type of CLR enumeration type does not match the underlying type of EDM enumeration type."
        /// </summary>
        internal static string Validator_OSpace_Convention_NonMatchingUnderlyingTypes
        {
            get { return EntityRes.GetString(EntityRes.Validator_OSpace_Convention_NonMatchingUnderlyingTypes); }
        }

        /// <summary>
        ///     A string like "The type '{0}' is not a supported underlying type for enumeration types."
        /// </summary>
        internal static string Validator_UnsupportedEnumUnderlyingType(object p0)
        {
            return EntityRes.GetString(EntityRes.Validator_UnsupportedEnumUnderlyingType, p0);
        }

        /// <summary>
        ///     A string like "The following information may be useful in resolving the previous error:"
        /// </summary>
        internal static string ExtraInfo
        {
            get { return EntityRes.GetString(EntityRes.ExtraInfo); }
        }

        /// <summary>
        ///     A string like "Inconsistent metadata error"
        /// </summary>
        internal static string Metadata_General_Error
        {
            get { return EntityRes.GetString(EntityRes.Metadata_General_Error); }
        }

        /// <summary>
        ///     A string like "Error in Function '{0}'. Aggregate Functions should take exactly one input parameter."
        /// </summary>
        internal static string InvalidNumberOfParametersForAggregateFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidNumberOfParametersForAggregateFunction, p0);
        }

        /// <summary>
        ///     A string like "Type of parameter '{0}' in function '{1}' is not valid. The aggregate function parameter type must be of CollectionType."
        /// </summary>
        internal static string InvalidParameterTypeForAggregateFunction(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidParameterTypeForAggregateFunction, p0, p1);
        }

        /// <summary>
        ///     A string like "The ItemCollection for the '{0}' space has already been registered."
        /// </summary>
        internal static string ItemCollectionAlreadyRegistered(object p0)
        {
            return EntityRes.GetString(EntityRes.ItemCollectionAlreadyRegistered, p0);
        }

        /// <summary>
        ///     A string like "Schema specified is not valid. Errors: {0}"
        /// </summary>
        internal static string InvalidSchemaEncountered(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidSchemaEncountered, p0);
        }

        /// <summary>
        ///     A string like "The namespace '{0}' is a system namespace and cannot be used by other schemas. Choose another namespace name."
        /// </summary>
        internal static string SystemNamespaceEncountered(object p0)
        {
            return EntityRes.GetString(EntityRes.SystemNamespaceEncountered, p0);
        }

        /// <summary>
        ///     A string like "The space '{0}' has no associated collection."
        /// </summary>
        internal static string NoCollectionForSpace(object p0)
        {
            return EntityRes.GetString(EntityRes.NoCollectionForSpace, p0);
        }

        /// <summary>
        ///     A string like "The operation cannot be performed because the collection is read only."
        /// </summary>
        internal static string OperationOnReadOnlyCollection
        {
            get { return EntityRes.GetString(EntityRes.OperationOnReadOnlyCollection); }
        }

        /// <summary>
        ///     A string like "The operation cannot be performed because the item is read only."
        /// </summary>
        internal static string OperationOnReadOnlyItem
        {
            get { return EntityRes.GetString(EntityRes.OperationOnReadOnlyItem); }
        }

        /// <summary>
        ///     A string like "The EntitySet already has an EntityContainer, it cannot be added to this collection."
        /// </summary>
        internal static string EntitySetInAnotherContainer
        {
            get { return EntityRes.GetString(EntityRes.EntitySetInAnotherContainer); }
        }

        /// <summary>
        ///     A string like "The specified key Member '{0}' does not exist in the Members collection."
        /// </summary>
        internal static string InvalidKeyMember(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidKeyMember, p0);
        }

        /// <summary>
        ///     A string like "Specified file '{0}' has extension '{1}' that is not valid. The valid extension is {2}."
        /// </summary>
        internal static string InvalidFileExtension(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidFileExtension, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The type '{0}' that is being loaded conflicts with the type '{1}' that is already loaded because they have the same namespace and name."
        /// </summary>
        internal static string NewTypeConflictsWithExistingType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NewTypeConflictsWithExistingType, p0, p1);
        }

        /// <summary>
        ///     A string like "At least one of the input paths is not valid because either it is too long or it has incorrect format."
        /// </summary>
        internal static string NotValidInputPath
        {
            get { return EntityRes.GetString(EntityRes.NotValidInputPath); }
        }

        /// <summary>
        ///     A string like "Unable to determine application context. The ASP.NET application path could not be resolved."
        /// </summary>
        internal static string UnableToDetermineApplicationContext
        {
            get { return EntityRes.GetString(EntityRes.UnableToDetermineApplicationContext); }
        }

        /// <summary>
        ///     A string like "The wildcard assembly enumerator function returned null."
        /// </summary>
        internal static string WildcardEnumeratorReturnedNull
        {
            get { return EntityRes.GetString(EntityRes.WildcardEnumeratorReturnedNull); }
        }

        /// <summary>
        ///     A string like "'{0}' is only valid in metadata file paths when running inside ASP.NET."
        /// </summary>
        internal static string InvalidUseOfWebPath(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidUseOfWebPath, p0);
        }

        /// <summary>
        ///     A string like "Unable to find type '{0}' in assembly '{1}'."
        /// </summary>
        internal static string UnableToFindReflectedType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.UnableToFindReflectedType, p0, p1);
        }

        /// <summary>
        ///     A string like "The assembly '{0}' specified does not exist in the assemblies enumeration."
        /// </summary>
        internal static string AssemblyMissingFromAssembliesToConsider(object p0)
        {
            return EntityRes.GetString(EntityRes.AssemblyMissingFromAssembliesToConsider, p0);
        }

        /// <summary>
        ///     A string like "Item Collection for '{0}' is not valid. Make sure that the StorageMappingItemCollection was constructed with the same instances of item collection that are registered for conceptual model and storage model."
        /// </summary>
        internal static string InvalidCollectionSpecified(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidCollectionSpecified, p0);
        }

        /// <summary>
        ///     A string like "Unable to load the specified metadata resource."
        /// </summary>
        internal static string UnableToLoadResource
        {
            get { return EntityRes.GetString(EntityRes.UnableToLoadResource); }
        }

        /// <summary>
        ///     A string like "The EDMVersion of the item collection {0} is not an EDMVersion that the runtime supports. The supported versions are {1}."
        /// </summary>
        internal static string EdmVersionNotSupportedByRuntime(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EdmVersionNotSupportedByRuntime, p0, p1);
        }

        /// <summary>
        ///     A string like "At least one SSDL artifact is required for creating StoreItemCollection."
        /// </summary>
        internal static string AtleastOneSSDLNeeded
        {
            get { return EntityRes.GetString(EntityRes.AtleastOneSSDLNeeded); }
        }

        /// <summary>
        ///     A string like "The specified metadata path is not valid. A valid path must be either an existing directory, an existing file with extension '.csdl', '.ssdl', or '.msl', or a URI that identifies an embedded resource."
        /// </summary>
        internal static string InvalidMetadataPath
        {
            get { return EntityRes.GetString(EntityRes.InvalidMetadataPath); }
        }

        /// <summary>
        ///     A string like "Unable to resolve assembly '{0}'."
        /// </summary>
        internal static string UnableToResolveAssembly(object p0)
        {
            return EntityRes.GetString(EntityRes.UnableToResolveAssembly, p0);
        }

        /// <summary>
        ///     A string like "The parameters of Function '{0}' are converted to conceptual side type '{1}', and the function with the same conceptual side type parameters already exists. Please make sure that function overloads are not ambiguous."
        /// </summary>
        internal static string DuplicatedFunctionoverloads(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DuplicatedFunctionoverloads, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' that was passed in does not belong to the conceptual model."
        /// </summary>
        internal static string EntitySetNotInCSPace(object p0)
        {
            return EntityRes.GetString(EntityRes.EntitySetNotInCSPace, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' specified is not the declared type '{1}' or a derivation of the type of the EntitySet '{2}'."
        /// </summary>
        internal static string TypeNotInEntitySet(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.TypeNotInEntitySet, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The type '{0}' specified is not the declared type '{1}' or a derivation of the type of the AssociationSet '{2}'."
        /// </summary>
        internal static string TypeNotInAssociationSet(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.TypeNotInAssociationSet, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The {0} could not be registered with the MetadataWorkspace because its version ('{1}') is different from the version ('{2}') already associated with the MetadataWorkspace."
        /// </summary>
        internal static string DifferentSchemaVersionInCollection(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DifferentSchemaVersionInCollection, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "ItemCollection is not valid. For '{0}' space, the CollectionType should be MappingItemCollection."
        /// </summary>
        internal static string InvalidCollectionForMapping(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidCollectionForMapping, p0);
        }

        /// <summary>
        ///     A string like "Entity connections are not supported; only storage connections are supported."
        /// </summary>
        internal static string OnlyStoreConnectionsSupported
        {
            get { return EntityRes.GetString(EntityRes.OnlyStoreConnectionsSupported); }
        }

        /// <summary>
        ///     A string like "Argument '{0}' is not valid. A minimum of one .ssdl artifact must be supplied. "
        /// </summary>
        internal static string StoreItemCollectionMustHaveOneArtifact(object p0)
        {
            return EntityRes.GetString(EntityRes.StoreItemCollectionMustHaveOneArtifact, p0);
        }

        /// <summary>
        ///     A string like "Argument '{0}' is not valid.  The set contains a null value."
        /// </summary>
        internal static string CheckArgumentContainsNullFailed(object p0)
        {
            return EntityRes.GetString(EntityRes.CheckArgumentContainsNullFailed, p0);
        }

        /// <summary>
        ///     A string like "The RelationshipSet with the specified name '{0}' does not exist in the EntityContainer."
        /// </summary>
        internal static string InvalidRelationshipSetName(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidRelationshipSetName, p0);
        }

        /// <summary>
        ///     A string like "The member with identity '{0}' does not exist in the member collection."
        /// </summary>
        internal static string MemberInvalidIdentity(object p0)
        {
            return EntityRes.GetString(EntityRes.MemberInvalidIdentity, p0);
        }

        /// <summary>
        ///     A string like "The EntitySet with the specified name '{0}' does not exist in the EntityContainer."
        /// </summary>
        internal static string InvalidEntitySetName(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEntitySetName, p0);
        }

        /// <summary>
        ///     A string like "The member with identity '{0}' does not exist in the metadata collection."
        /// </summary>
        internal static string ItemInvalidIdentity(object p0)
        {
            return EntityRes.GetString(EntityRes.ItemInvalidIdentity, p0);
        }

        /// <summary>
        ///     A string like "The item with identity '{0}' already exists in the metadata collection."
        /// </summary>
        internal static string ItemDuplicateIdentity(object p0)
        {
            return EntityRes.GetString(EntityRes.ItemDuplicateIdentity, p0);
        }

        /// <summary>
        ///     A string like "The PrimitiveType is not a string type."
        /// </summary>
        internal static string NotStringTypeForTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.NotStringTypeForTypeUsage); }
        }

        /// <summary>
        ///     A string like "The PrimitiveType is not a binary type."
        /// </summary>
        internal static string NotBinaryTypeForTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.NotBinaryTypeForTypeUsage); }
        }

        /// <summary>
        ///     A string like "The PrimitiveType is not a DateTime type."
        /// </summary>
        internal static string NotDateTimeTypeForTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.NotDateTimeTypeForTypeUsage); }
        }

        /// <summary>
        ///     A string like "The given primitive type is not a DateTimeOffset type."
        /// </summary>
        internal static string NotDateTimeOffsetTypeForTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.NotDateTimeOffsetTypeForTypeUsage); }
        }

        /// <summary>
        ///     A string like "The given primitive type is not a Time type."
        /// </summary>
        internal static string NotTimeTypeForTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.NotTimeTypeForTypeUsage); }
        }

        /// <summary>
        ///     A string like "The PrimitiveType is not a Decimal type."
        /// </summary>
        internal static string NotDecimalTypeForTypeUsage
        {
            get { return EntityRes.GetString(EntityRes.NotDecimalTypeForTypeUsage); }
        }

        /// <summary>
        ///     A string like "Destination array was not long enough. Check arrayIndex and length, and the array's lower bounds."
        /// </summary>
        internal static string ArrayTooSmall
        {
            get { return EntityRes.GetString(EntityRes.ArrayTooSmall); }
        }

        /// <summary>
        ///     A string like "More than one item in the metadata collection match the identity '{0}'."
        /// </summary>
        internal static string MoreThanOneItemMatchesIdentity(object p0)
        {
            return EntityRes.GetString(EntityRes.MoreThanOneItemMatchesIdentity, p0);
        }

        /// <summary>
        ///     A string like "Missing default value for '{0}' in type '{1}'. Default value must be specified because the '{0}' is specified as constant."
        /// </summary>
        internal static string MissingDefaultValueForConstantFacet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MissingDefaultValueForConstantFacet, p0, p1);
        }

        /// <summary>
        ///     A string like "Minimum and maximum value must not be specified for '{0}' in type '{1}' since '{0}' is specified as constant."
        /// </summary>
        internal static string MinAndMaxValueMustBeSameForConstantFacet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MinAndMaxValueMustBeSameForConstantFacet, p0, p1);
        }

        /// <summary>
        ///     A string like "Both minimum and maximum values must be provided for '{0}' in type '{1}' since '{0}' is not specified as a constant."
        /// </summary>
        internal static string BothMinAndMaxValueMustBeSpecifiedForNonConstantFacet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.BothMinAndMaxValueMustBeSpecifiedForNonConstantFacet, p0, p1);
        }

        /// <summary>
        ///     A string like "Minimum and maximum values cannot be identical for '{0}' in type '{1}' because '{0}' is not specified as constant."
        /// </summary>
        internal static string MinAndMaxValueMustBeDifferentForNonConstantFacet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MinAndMaxValueMustBeDifferentForNonConstantFacet, p0, p1);
        }

        /// <summary>
        ///     A string like "Minimum and maximum values must be greater than or equal to zero for '{0}' in type '{1}'."
        /// </summary>
        internal static string MinAndMaxMustBePositive(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MinAndMaxMustBePositive, p0, p1);
        }

        /// <summary>
        ///     A string like "Minimum value '{0}' specified for '{1}' in type '{2} is not valid. Minimum value must be always less than the maximum value."
        /// </summary>
        internal static string MinMustBeLessThanMax(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.MinMustBeLessThanMax, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Both Ends on the EdmRelationshipAttribute for relationship '{0}' have the same Role name '{1}'. The ends of a relationship type must have different Role names."
        /// </summary>
        internal static string SameRoleNameOnRelationshipAttribute(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.SameRoleNameOnRelationshipAttribute, p0, p1);
        }

        /// <summary>
        ///     A string like "The property for the relationship '{0}' contains a Role '{1}' has a type '{2}' that is not valid for a relationship End. Change the End Role to an EntityType."
        /// </summary>
        internal static string RoleTypeInEdmRelationshipAttributeIsInvalidType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.RoleTypeInEdmRelationshipAttributeIsInvalidType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "EdmRelationshipNavigationPropertyAttribute for RelationshipType '{3}' on NavigationProperty '{0}' in EntityType '{1}' has a TargetRole name '{2}' that is not valid. Make sure that TargetRole name is a valid name. "
        /// </summary>
        internal static string TargetRoleNameInNavigationPropertyNotValid(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.TargetRoleNameInNavigationPropertyNotValid, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "EdmRelationshipNavigationPropertyAttribute on NavigationProperty '{0}' in EntityType '{1}' has a RelationshipName '{2}' that is not valid. Make sure the RelationshipName is valid."
        /// </summary>
        internal static string RelationshipNameInNavigationPropertyNotValid(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.RelationshipNameInNavigationPropertyNotValid, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Type '{0}' in Assembly '{1}' is a nested class. Nested classes are not supported."
        /// </summary>
        internal static string NestedClassNotSupported(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NestedClassNotSupported, p0, p1);
        }

        /// <summary>
        ///     A string like "The EdmRelationshipAttribute for the relationship '{1}' has a null parameter '{0}'."
        /// </summary>
        internal static string NullParameterForEdmRelationshipAttribute(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NullParameterForEdmRelationshipAttribute, p0, p1);
        }

        /// <summary>
        ///     A string like "The RelationshipName parameter of an EdmRelationshipAttribute in the assembly '{0}' is null."
        /// </summary>
        internal static string NullRelationshipNameforEdmRelationshipAttribute(object p0)
        {
            return EntityRes.GetString(EntityRes.NullRelationshipNameforEdmRelationshipAttribute, p0);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' that the NavigationProperty '{1}' is declared on is not the same type '{4}' referred by the end '{3}' of the RelationshipType '{2}' that this NavigationProperty represents."
        /// </summary>
        internal static string NavigationPropertyRelationshipEndTypeMismatch(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.NavigationPropertyRelationshipEndTypeMismatch, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "All SSDL artifacts must target the same provider. The Provider '{0}' is different from '{1}' that was encountered earlier."
        /// </summary>
        internal static string AllArtifactsMustTargetSameProvider_InvariantName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.AllArtifactsMustTargetSameProvider_InvariantName, p0, p1);
        }

        /// <summary>
        ///     A string like "All SSDL artifacts must target the same provider. The ProviderManifestToken '{0}' is different from '{1}' that was encountered earlier."
        /// </summary>
        internal static string AllArtifactsMustTargetSameProvider_ManifestToken(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.AllArtifactsMustTargetSameProvider_ManifestToken, p0, p1);
        }

        /// <summary>
        ///     A string like "The storage provider manifest could not be obtained."
        /// </summary>
        internal static string ProviderManifestTokenNotFound
        {
            get { return EntityRes.GetString(EntityRes.ProviderManifestTokenNotFound); }
        }

        /// <summary>
        ///     A string like "Could not retrieve the provider manifest."
        /// </summary>
        internal static string FailedToRetrieveProviderManifest
        {
            get { return EntityRes.GetString(EntityRes.FailedToRetrieveProviderManifest); }
        }

        /// <summary>
        ///     A string like "MaxLength must be greater than zero."
        /// </summary>
        internal static string InvalidMaxLengthSize
        {
            get { return EntityRes.GetString(EntityRes.InvalidMaxLengthSize); }
        }

        /// <summary>
        ///     A string like "The argument to the function must be a conceptual schema type."
        /// </summary>
        internal static string ArgumentMustBeCSpaceType
        {
            get { return EntityRes.GetString(EntityRes.ArgumentMustBeCSpaceType); }
        }

        /// <summary>
        ///     A string like "The argument to the function must be an CLR type."
        /// </summary>
        internal static string ArgumentMustBeOSpaceType
        {
            get { return EntityRes.GetString(EntityRes.ArgumentMustBeOSpaceType); }
        }

        /// <summary>
        ///     A string like "Could not find the CLR type for '{0}'."
        /// </summary>
        internal static string FailedToFindOSpaceTypeMapping(object p0)
        {
            return EntityRes.GetString(EntityRes.FailedToFindOSpaceTypeMapping, p0);
        }

        /// <summary>
        ///     A string like "Could not find the conceptual model type for '{0}'."
        /// </summary>
        internal static string FailedToFindCSpaceTypeMapping(object p0)
        {
            return EntityRes.GetString(EntityRes.FailedToFindCSpaceTypeMapping, p0);
        }

        /// <summary>
        ///     A string like "Could not find the CLR type for '{0}'."
        /// </summary>
        internal static string FailedToFindClrTypeMapping(object p0)
        {
            return EntityRes.GetString(EntityRes.FailedToFindClrTypeMapping, p0);
        }

        /// <summary>
        ///     A string like "EdmComplexTypeAttribute and EdmEntityTypeAttribute can not be used on the generic type '{0}'."
        /// </summary>
        internal static string GenericTypeNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.GenericTypeNotSupported, p0);
        }

        /// <summary>
        ///     A string like "The EDM version {0} is not supported by the runtime."
        /// </summary>
        internal static string InvalidEDMVersion(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEDMVersion, p0);
        }

        /// <summary>
        ///     A string like ""Mapping not valid error""
        /// </summary>
        internal static string Mapping_General_Error
        {
            get { return EntityRes.GetString(EntityRes.Mapping_General_Error); }
        }

        /// <summary>
        ///     A string like "Content in MSL is not valid."
        /// </summary>
        internal static string Mapping_InvalidContent_General
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_General); }
        }

        /// <summary>
        ///     A string like "The EntityContainer '{0}' for the conceptual model specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_EntityContainer(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_EntityContainer, p0);
        }

        /// <summary>
        ///     A string like "The EntityContainer '{0}' for the storage model specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_StorageEntityContainer(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_StorageEntityContainer, p0);
        }

        /// <summary>
        ///     A string like "The EntityContainer '{0}' for the storage model has already been mapped."
        /// </summary>
        internal static string Mapping_AlreadyMapped_StorageEntityContainer(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_AlreadyMapped_StorageEntityContainer, p0);
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Entity_Set(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Entity_Set, p0);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Entity_Type(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Entity_Type, p0);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' is Abstract and cannot be mapped using Function Mapping."
        /// </summary>
        internal static string Mapping_InvalidContent_AbstractEntity_FunctionMapping(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_AbstractEntity_FunctionMapping, p0);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' is Abstract and can be mapped only using IsTypeOf."
        /// </summary>
        internal static string Mapping_InvalidContent_AbstractEntity_Type(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_AbstractEntity_Type, p0);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' used in IsTypeOf does not have any concrete descendants."
        /// </summary>
        internal static string Mapping_InvalidContent_AbstractEntity_IsOfType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_AbstractEntity_IsOfType, p0);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' specified is not the declared type '{1}' or a derivation of the type of the EntitySet '{2}'."
        /// </summary>
        internal static string Mapping_InvalidContent_Entity_Type_For_Entity_Set(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Entity_Type_For_Entity_Set, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The AssociationType '{0}' specified is not the declared type '{1}' of the AssociationSet '{2}'."
        /// </summary>
        internal static string Mapping_Invalid_Association_Type_For_Association_Set(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_Association_Type_For_Association_Set, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The Table '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Table(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Table, p0);
        }

        /// <summary>
        ///     A string like "The Complex Type '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Complex_Type(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Complex_Type, p0);
        }

        /// <summary>
        ///     A string like "The AssociationSet '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Association_Set(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Association_Set, p0);
        }

        /// <summary>
        ///     A string like "The AssociationSet '{0}' cannot have a Condition because it does not provide maps for the End elements."
        /// </summary>
        internal static string Mapping_InvalidContent_AssociationSet_Condition(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_AssociationSet_Condition, p0);
        }

        /// <summary>
        ///     A string like "AssociationType '{0}' has a referential integrity constraint and cannot be mapped."
        /// </summary>
        internal static string Mapping_InvalidContent_ForeignKey_Association_Set(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ForeignKey_Association_Set, p0);
        }

        /// <summary>
        ///     A string like "AssociationType '{0}' has a primary key to primary key referential integrity constraint. Any mappings for it will be ignored."
        /// </summary>
        internal static string Mapping_InvalidContent_ForeignKey_Association_Set_PKtoPK(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ForeignKey_Association_Set_PKtoPK, p0);
        }

        /// <summary>
        ///     A string like "The AssociationType '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Association_Type(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Association_Type, p0);
        }

        /// <summary>
        ///     A string like "The property '{0}' is not a key member of the EntityType. Only key members can be mapped as part of the EndProperty mapping."
        /// </summary>
        internal static string Mapping_InvalidContent_EndProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_EndProperty, p0);
        }

        /// <summary>
        ///     A string like "AssociationType Name should be specified when providing a function mapping or End property mapping."
        /// </summary>
        internal static string Mapping_InvalidContent_Association_Type_Empty
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Association_Type_Empty); }
        }

        /// <summary>
        ///     A string like "A table mapping element is expected but not present."
        /// </summary>
        internal static string Mapping_InvalidContent_Table_Expected
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Table_Expected); }
        }

        /// <summary>
        ///     A string like "Content not valid. The conceptual side Member or Property '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Cdm_Member(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Cdm_Member, p0);
        }

        /// <summary>
        ///     A string like "The Column '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_Column(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Column, p0);
        }

        /// <summary>
        ///     A string like "The End property '{0}' specified as part of this MSL does not exist in MetadataWorkspace."
        /// </summary>
        internal static string Mapping_InvalidContent_End(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_End, p0);
        }

        /// <summary>
        ///     A string like "Expecting only EntitySetMapping, AssociationSetMapping, or FunctionImportMapping elements."
        /// </summary>
        internal static string Mapping_InvalidContent_Container_SubElement
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Container_SubElement); }
        }

        /// <summary>
        ///     A string like "The conceptual side Member or Property '{0}' has multiple mappings specified as part of the same mapping fragment."
        /// </summary>
        internal static string Mapping_InvalidContent_Duplicate_Cdm_Member(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Duplicate_Cdm_Member, p0);
        }

        /// <summary>
        ///     A string like "The Member or Property '{0}' has multiple conditions specified as part of the same mapping fragment."
        /// </summary>
        internal static string Mapping_InvalidContent_Duplicate_Condition_Member(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Duplicate_Condition_Member, p0);
        }

        /// <summary>
        ///     A string like "Both conceptual model and column members cannot be specified for condition mapping."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_Both_Members
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_Both_Members); }
        }

        /// <summary>
        ///     A string like "Either conceptual model or Column Members must  be specified for condition mapping."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_Either_Members
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_Either_Members); }
        }

        /// <summary>
        ///     A string like "Both Value and IsNull attributes cannot be specified for condition mapping."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_Both_Values
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_Both_Values); }
        }

        /// <summary>
        ///     A string like "Either Value or IsNullAttribute has to be specified for condition mapping."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_Either_Values
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_Either_Values); }
        }

        /// <summary>
        ///     A string like "Conditions are not supported on complex-valued members."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_NonScalar
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_NonScalar); }
        }

        /// <summary>
        ///     A string like "Condition can not be specified on values of member '{0}'. Value conditions are not supported for type '{1}'."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_InvalidPrimitiveTypeKind(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_InvalidPrimitiveTypeKind, p0, p1);
        }

        /// <summary>
        ///     A string like "Member '{0}' specified in Condition does not exist."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_InvalidMember(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_InvalidMember, p0);
        }

        /// <summary>
        ///     A string like "Condition cannot be specified for Column member '{0}' because it is marked with a 'Computed' or 'Identity' StoreGeneratedPattern."
        /// </summary>
        internal static string Mapping_InvalidContent_ConditionMapping_Computed(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_ConditionMapping_Computed, p0);
        }

        /// <summary>
        ///     A string like "At least one property must be mapped in the set mapping for '{0}'."
        /// </summary>
        internal static string Mapping_InvalidContent_Emtpty_SetMap(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidContent_Emtpty_SetMap, p0);
        }

        /// <summary>
        ///     A string like "Only EntityTypeMapping and QueryView elements are allowed when the EntityType name is not specified on the EntitySetMapping."
        /// </summary>
        internal static string Mapping_InvalidContent_TypeMapping_QueryView
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_TypeMapping_QueryView); }
        }

        /// <summary>
        ///     A string like "The Member '{0}' in the conceptual model type '{1}' is not present in the CLR type '{2}'."
        /// </summary>
        internal static string Mapping_Default_OCMapping_Clr_Member(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_Default_OCMapping_Clr_Member, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The Member '{0}' in the CLR type '{1}' is not present in the conceptual model type '{2}'."
        /// </summary>
        internal static string Mapping_Default_OCMapping_Clr_Member2(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_Default_OCMapping_Clr_Member2, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The type '{0}' of the member '{1}' in the conceptual side type '{2}' does not match with the type '{3}' of the member '{4}' on the object side type '{5}'."
        /// </summary>
        internal static string Mapping_Default_OCMapping_Invalid_MemberType(
            object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.Mapping_Default_OCMapping_Invalid_MemberType, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "The '{0}' property on the conceptual model type '{1}' is of type '{2}'. The property '{3}' on the CLR type '{4}' is of type '{5}'. The property types must match."
        /// </summary>
        internal static string Mapping_Default_OCMapping_MemberKind_Mismatch(
            object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.Mapping_Default_OCMapping_MemberKind_Mismatch, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "The multiplicity '{0}' on End '{1}' in the conceptual side Association '{2}' doesn't match with multiplicity '{3}' on end '{4}' on the object side Association '{5}'."
        /// </summary>
        internal static string Mapping_Default_OCMapping_MultiplicityMismatch(
            object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.Mapping_Default_OCMapping_MultiplicityMismatch, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "The number of members in the conceptual type '{0}' does not match with the number of members on the object side type '{1}'. Make sure the number of members are the same."
        /// </summary>
        internal static string Mapping_Default_OCMapping_Member_Count_Mismatch(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_Default_OCMapping_Member_Count_Mismatch, p0, p1);
        }

        /// <summary>
        ///     A string like "The type '{0}'('{1}') of the member '{2}' in the conceptual  type '{3}' doesn't match with the type '{4}'('{5}') of the member '{6}' on the object side type '{7}'."
        /// </summary>
        internal static string Mapping_Default_OCMapping_Member_Type_Mismatch(
            object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
        {
            return EntityRes.GetString(EntityRes.Mapping_Default_OCMapping_Member_Type_Mismatch, p0, p1, p2, p3, p4, p5, p6, p7);
        }

        /// <summary>
        ///     A string like "The underlying type '{0}' of the enumeration type '{1}' defined in the conceptual model does not match the underlying type '{2}' of the enumeration type '{3}' defined in the object layer."
        /// </summary>
        internal static string Mapping_Enum_OCMapping_UnderlyingTypesMismatch(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_Enum_OCMapping_UnderlyingTypesMismatch, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The enumeration type '{0}' defined in the object layer does not have a member that corresponds to the member '{1}' whose value is '{2}' of the enumeration type '{3}' defined in the conceptual model."
        /// </summary>
        internal static string Mapping_Enum_OCMapping_MemberMismatch(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_Enum_OCMapping_MemberMismatch, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The mapping for EntityContainer '{0}' was not found in Workspace."
        /// </summary>
        internal static string Mapping_NotFound_EntityContainer(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_NotFound_EntityContainer, p0);
        }

        /// <summary>
        ///     A string like "The conceptual AssociationSet '{0}' cannot be mapped multiple times."
        /// </summary>
        internal static string Mapping_Duplicate_CdmAssociationSet_StorageMap(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Duplicate_CdmAssociationSet_StorageMap, p0);
        }

        /// <summary>
        ///     A string like "Invalid root element found in the mapping file. Make sure that the root element's local name is 'Mapping' and the namespaceURI is '{0}', '{1}' or '{2}'."
        /// </summary>
        internal static string Mapping_Invalid_CSRootElementMissing(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_CSRootElementMissing, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The value specified for the condition is not compatible with the type of the member."
        /// </summary>
        internal static string Mapping_ConditionValueTypeMismatch
        {
            get { return EntityRes.GetString(EntityRes.Mapping_ConditionValueTypeMismatch); }
        }

        /// <summary>
        ///     A string like "The Storage Map can be looked up only from the type in conceptual model. It cannot be looked up from type in the following space: {0}."
        /// </summary>
        internal static string Mapping_Storage_InvalidSpace(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Storage_InvalidSpace, p0);
        }

        /// <summary>
        ///     A string like "Member Mapping specified is not valid. The type '{0}' of member '{1}' in type '{2}' is not compatible with '{3}' of member '{4}' in type '{5}'."
        /// </summary>
        internal static string Mapping_Invalid_Member_Mapping(object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_Member_Mapping, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "The property '{0}' on the conceptual side is not a scalar property."
        /// </summary>
        internal static string Mapping_Invalid_CSide_ScalarProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_CSide_ScalarProperty, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' has been mapped more than once."
        /// </summary>
        internal static string Mapping_Duplicate_Type(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Duplicate_Type, p0);
        }

        /// <summary>
        ///     A string like "More than one property map found for property '{0}' when using case-insensitive search."
        /// </summary>
        internal static string Mapping_Duplicate_PropertyMap_CaseInsensitive(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Duplicate_PropertyMap_CaseInsensitive, p0);
        }

        /// <summary>
        ///     A string like "Non-empty enumeration value must be specified for condition mapping for enumeration '{0}'."
        /// </summary>
        internal static string Mapping_Enum_EmptyValue(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Enum_EmptyValue, p0);
        }

        /// <summary>
        ///     A string like "Enumeration value '{0}' specified in condition mapping is not valid."
        /// </summary>
        internal static string Mapping_Enum_InvalidValue(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Enum_InvalidValue, p0);
        }

        /// <summary>
        ///     A string like "XML parsing failed for mapping schema. Schema Error Information : {0}."
        /// </summary>
        internal static string Mapping_InvalidMappingSchema_Parsing(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidMappingSchema_Parsing, p0);
        }

        /// <summary>
        ///     A string like "XML Schema validation failed for mapping schema. Schema Error Information : {0}."
        /// </summary>
        internal static string Mapping_InvalidMappingSchema_validation(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_InvalidMappingSchema_validation, p0);
        }

        /// <summary>
        ///     A string like "Object mapping could not be found for Type with identity '{0}'."
        /// </summary>
        internal static string Mapping_Object_InvalidType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Object_InvalidType, p0);
        }

        /// <summary>
        ///     A string like "The connection is not of type '{0}'."
        /// </summary>
        internal static string Mapping_Provider_WrongConnectionType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Provider_WrongConnectionType, p0);
        }

        /// <summary>
        ///     A string like "No views were found in assemblies or could be generated for {0} '{1}'."
        /// </summary>
        internal static string Mapping_Views_For_Extent_Not_Generated(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_Views_For_Extent_Not_Generated, p0, p1);
        }

        /// <summary>
        ///     A string like "Store EntitySet name should not be specified on set mapping for Set '{0}' because a query view is being specified."
        /// </summary>
        internal static string Mapping_TableName_QueryView(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_TableName_QueryView, p0);
        }

        /// <summary>
        ///     A string like "The query view specified for EntitySet '{0}' is empty."
        /// </summary>
        internal static string Mapping_Empty_QueryView(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Empty_QueryView, p0);
        }

        /// <summary>
        ///     A string like "The IsTypeOf({0}) query view specified for EntitySet '{1}' is empty."
        /// </summary>
        internal static string Mapping_Empty_QueryView_OfType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_Empty_QueryView_OfType, p0, p1);
        }

        /// <summary>
        ///     A string like "The query view specified for EntitySet '{0}' for EntityType '{1}' is empty."
        /// </summary>
        internal static string Mapping_Empty_QueryView_OfTypeOnly(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_Empty_QueryView_OfTypeOnly, p0, p1);
        }

        /// <summary>
        ///     A string like "Property maps cannot be specified for EntitySet '{0}' because a query view has been specified."
        /// </summary>
        internal static string Mapping_QueryView_PropertyMaps(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_QueryView_PropertyMaps, p0);
        }

        /// <summary>
        ///     A string like "The query view generated for the EntitySet '{0}' is not valid. The query parser threw the following error : {1}."
        /// </summary>
        internal static string Mapping_Invalid_QueryView(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_QueryView, p0, p1);
        }

        /// <summary>
        ///     A string like "The query view specified for the EntitySet '{0}' is not valid. The query parser threw the following error : {1}."
        /// </summary>
        internal static string Mapping_Invalid_QueryView2(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_QueryView2, p0, p1);
        }

        /// <summary>
        ///     A string like "The ResultType of the query view expression specified for the EntitySet '{0}' is not assignable to the element type of the EntitySet."
        /// </summary>
        internal static string Mapping_Invalid_QueryView_Type(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_QueryView_Type, p0);
        }

        /// <summary>
        ///     A string like "The first QueryView must not be type-specific. Try removing the TypeName property."
        /// </summary>
        internal static string Mapping_TypeName_For_First_QueryView
        {
            get { return EntityRes.GetString(EntityRes.Mapping_TypeName_For_First_QueryView); }
        }

        /// <summary>
        ///     A string like "The EntitySetMapping in EntityContainerMapping for EntityContainer '{0}' must contain only mapping fragments and no query view. The EntitySetMapping contains only query views and the view for this EntityContainerMapping will not be generated."
        /// </summary>
        internal static string Mapping_AllQueryViewAtCompileTime(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_AllQueryViewAtCompileTime, p0);
        }

        /// <summary>
        ///     A string like "A single QueryView is defined for multiple types within EntitySet {0}."
        /// </summary>
        internal static string Mapping_QueryViewMultipleTypeInTypeName(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_QueryViewMultipleTypeInTypeName, p0);
        }

        /// <summary>
        ///     A string like "IsTypeOf( ) QueryView is already defined for EntitySet {0} and TypeName {1}."
        /// </summary>
        internal static string Mapping_QueryView_Duplicate_OfType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_QueryView_Duplicate_OfType, p0, p1);
        }

        /// <summary>
        ///     A string like "QueryView is already defined for EntitySet {0} and TypeName {1}."
        /// </summary>
        internal static string Mapping_QueryView_Duplicate_OfTypeOnly(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_QueryView_Duplicate_OfTypeOnly, p0, p1);
        }

        /// <summary>
        ///     A string like "TypeName property must be defined for all but the first QueryViews within mapping for EntitySet {0}."
        /// </summary>
        internal static string Mapping_QueryView_TypeName_Not_Defined(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_QueryView_TypeName_Not_Defined, p0);
        }

        /// <summary>
        ///     A string like "IsTypeOf({0}) QueryView should not be specified for {1} EntitySet's element type {0}."
        /// </summary>
        internal static string Mapping_QueryView_For_Base_Type(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_QueryView_For_Base_Type, p0, p1);
        }

        /// <summary>
        ///     A string like "The query view specified for '{0}' EntitySet's type(s) '{1}' contains an unsupported expression of kind '{2}'."
        /// </summary>
        internal static string Mapping_UnsupportedExpressionKind_QueryView(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_UnsupportedExpressionKind_QueryView, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The query view specified for the EntitySet '{0}' includes a call to the Function '{1}'. Only storage Functions may be referenced in a query view."
        /// </summary>
        internal static string Mapping_UnsupportedFunctionCall_QueryView(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_UnsupportedFunctionCall_QueryView, p0, p1);
        }

        /// <summary>
        ///     A string like "The query view specified for the EntitySet '{0}' includes a scan of the '{1}' EntitySet. Only storage EntitySets may be referenced in a query view."
        /// </summary>
        internal static string Mapping_UnsupportedScanTarget_QueryView(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_UnsupportedScanTarget_QueryView, p0, p1);
        }

        /// <summary>
        ///     A string like "The query view specified for the EntitySet '{0}' contains a reference to member '{1}' of kind '{2}'. Only columns may be referenced."
        /// </summary>
        internal static string Mapping_UnsupportedPropertyKind_QueryView(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_UnsupportedPropertyKind_QueryView, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The query view specified for the EntitySet '{0}' initializes an instance of type '{1}'. Only types assignable to the element type of the EntitySet are permitted."
        /// </summary>
        internal static string Mapping_UnsupportedInitialization_QueryView(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_UnsupportedInitialization_QueryView, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' used for creating the Ref expression does not match the EntitySet '{1}' declared on the AssociationSetEnd '{2}' of the AssociationSet '{3}'."
        /// </summary>
        internal static string Mapping_EntitySetMismatchOnAssociationSetEnd_QueryView(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_EntitySetMismatchOnAssociationSetEnd_QueryView, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "If an EntitySet or AssociationSet includes a query view, all related entity and association sets in the EntityContainer must also define query views. The following sets require query views: {0}."
        /// </summary>
        internal static string Mapping_Invalid_Query_Views_MissingSetClosure(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Invalid_Query_Views_MissingSetClosure, p0);
        }

        /// <summary>
        ///     A string like "The type that contains generated views '{0}' should derive from the System.Data.Mapping.EntityViewContainer type."
        /// </summary>
        internal static string Generated_View_Type_Super_Class(object p0)
        {
            return EntityRes.GetString(EntityRes.Generated_View_Type_Super_Class, p0);
        }

        /// <summary>
        ///     A string like "The content of the views or the EntitySet base names have changed from the design time."
        /// </summary>
        internal static string Generated_Views_Changed
        {
            get { return EntityRes.GetString(EntityRes.Generated_Views_Changed); }
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' for which the view has been specified could not be found in the workspace."
        /// </summary>
        internal static string Generated_Views_Invalid_Extent(object p0)
        {
            return EntityRes.GetString(EntityRes.Generated_Views_Invalid_Extent, p0);
        }

        /// <summary>
        ///     A string like "GlobalItem with name '{0}' exists both in conceptual model and storage model. Make sure that every item has a unique name across conceptual model and storage model."
        /// </summary>
        internal static string Mapping_ItemWithSameNameExistsBothInCSpaceAndSSpace(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ItemWithSameNameExistsBothInCSpaceAndSSpace, p0);
        }

        /// <summary>
        ///     A string like "Type '{0}' in conceptual side  cannot be mapped to type '{1}' on the object side.  Both the types must be abstract or both must be concrete types."
        /// </summary>
        internal static string Mapping_AbstractTypeMappingToNonAbstractType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_AbstractTypeMappingToNonAbstractType, p0, p1);
        }

        /// <summary>
        ///     A string like "Type '{0}' defined in the conceptual model cannot be mapped to type '{1}' from the object layer. An enumeration type cannot be mapped to a non-enumeration type."
        /// </summary>
        internal static string Mapping_EnumTypeMappingToNonEnumType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_EnumTypeMappingToNonEnumType, p0, p1);
        }

        /// <summary>
        ///     A string like "Storage EntityContainer name '{0}' specified in this mapping schema doesn't match with the storage EntityContainer name '{1}' specified in the previous mapping schema(s) for EntityContainer '{2}' in the conceptual model. Make sure that you specify exactly one mapping per EntityContainer, or if you want to specify partial mapping, make sure that they map to the same storage EntityContainer."
        /// </summary>
        internal static string StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Unclosed parenthesis in IsOfType declaration."
        /// </summary>
        internal static string Mapping_InvalidContent_IsTypeOfNotTerminated
        {
            get { return EntityRes.GetString(EntityRes.Mapping_InvalidContent_IsTypeOfNotTerminated); }
        }

        /// <summary>
        ///     A string like "An EdmType cannot be mapped to CLR classes multiple times. The EdmType '{0}' is mapped more than once."
        /// </summary>
        internal static string Mapping_CannotMapCLRTypeMultipleTimes(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_CannotMapCLRTypeMultipleTimes, p0);
        }

        /// <summary>
        ///     A string like "An EntityType Mapping containing a function mapping cannot specify the TableName property."
        /// </summary>
        internal static string Mapping_ModificationFunction_In_Table_Context
        {
            get { return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_In_Table_Context); }
        }

        /// <summary>
        ///     A string like "An EntityType Mapping function binding cannot map multiple types. Function mappings may be specified only for EntityType mappings for single types -- do not use the 'IsTypeOf' modifier or specify multiple types."
        /// </summary>
        internal static string Mapping_ModificationFunction_Multiple_Types
        {
            get { return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_Multiple_Types); }
        }

        /// <summary>
        ///     A string like "A mapping function binding specifies an unknown function {0}."
        /// </summary>
        internal static string Mapping_ModificationFunction_UnknownFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_UnknownFunction, p0);
        }

        /// <summary>
        ///     A string like "A mapping function binding specifies an ambiguous function {0} with more than one overload."
        /// </summary>
        internal static string Mapping_ModificationFunction_AmbiguousFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AmbiguousFunction, p0);
        }

        /// <summary>
        ///     A string like "A mapping function binding specifies a function {0} that is not supported. Only functions that cannot be composed are supported."
        /// </summary>
        internal static string Mapping_ModificationFunction_NotValidFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_NotValidFunction, p0);
        }

        /// <summary>
        ///     A string like "A mapping function binding specifies a function {0} with an unsupported parameter: {1}. Output parameters may only be mapped through the {2} property. Use result bindings to return values from a function invocation."
        /// </summary>
        internal static string Mapping_ModificationFunction_NotValidFunctionParameter(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_NotValidFunctionParameter, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "A mapping function bindings specifies a function {0} but does not map the following function parameters: {1}."
        /// </summary>
        internal static string Mapping_ModificationFunction_MissingParameter(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_MissingParameter, p0, p1);
        }

        /// <summary>
        ///     A string like "An association End mapping specifies an AssociationSet {0} that does not exist in the current container."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationSetDoesNotExist(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationSetDoesNotExist, p0);
        }

        /// <summary>
        ///     A string like "An association End mapping specifies a Role {0} that does not exist in the current AssociationSet."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationSetRoleDoesNotExist(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationSetRoleDoesNotExist, p0);
        }

        /// <summary>
        ///     A string like "An association End mapping defines a from Role {0} that is not bound to the current EntitySet."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationSetFromRoleIsNotEntitySet(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationSetFromRoleIsNotEntitySet, p0);
        }

        /// <summary>
        ///     A string like "An association End mapping has a 'to' Role {0} with multiplicity greater than one. A maximum multiplicity of one is supported."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationSetCardinality(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationSetCardinality, p0);
        }

        /// <summary>
        ///     A string like "Unable to find ComplexType {0} in the current MetadataWorkspace."
        /// </summary>
        internal static string Mapping_ModificationFunction_ComplexTypeNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_ComplexTypeNotFound, p0);
        }

        /// <summary>
        ///     A string like "The Complex Type {0} does not match the type of the current property {1}."
        /// </summary>
        internal static string Mapping_ModificationFunction_WrongComplexType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_WrongComplexType, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot determine the version for the current parameter binding."
        /// </summary>
        internal static string Mapping_ModificationFunction_MissingVersion
        {
            get { return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_MissingVersion); }
        }

        /// <summary>
        ///     A string like "This function mapping can only contain bindings to 'original' property versions."
        /// </summary>
        internal static string Mapping_ModificationFunction_VersionMustBeOriginal
        {
            get { return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_VersionMustBeOriginal); }
        }

        /// <summary>
        ///     A string like "This function mapping can only contain bindings to 'current' property versions."
        /// </summary>
        internal static string Mapping_ModificationFunction_VersionMustBeCurrent
        {
            get { return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_VersionMustBeCurrent); }
        }

        /// <summary>
        ///     A string like "The function parameter {0} is not defined in the function {1}."
        /// </summary>
        internal static string Mapping_ModificationFunction_ParameterNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_ParameterNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The property {0} does not exist in the type {1}."
        /// </summary>
        internal static string Mapping_ModificationFunction_PropertyNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_PropertyNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The property {0} is not a key of {1}. Association End mappings may only include key properties."
        /// </summary>
        internal static string Mapping_ModificationFunction_PropertyNotKey(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_PropertyNotKey, p0, p1);
        }

        /// <summary>
        ///     A string like "The parameter {0} is bound multiple times."
        /// </summary>
        internal static string Mapping_ModificationFunction_ParameterBoundTwice(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_ParameterBoundTwice, p0);
        }

        /// <summary>
        ///     A string like "The EntityType {0} is mapped to functions more than once."
        /// </summary>
        internal static string Mapping_ModificationFunction_RedundantEntityTypeMapping(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_RedundantEntityTypeMapping, p0);
        }

        /// <summary>
        ///     A string like "If some of the EntitySet or the AssociationSet mapped to the same store EntitySet, and one of the sets includes a function mapping, all related entity and AssociationSets in the EntityContainer must also define function mappings. The following sets require function mappings: {0}."
        /// </summary>
        internal static string Mapping_ModificationFunction_MissingSetClosure(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_MissingSetClosure, p0);
        }

        /// <summary>
        ///     A string like "If an EntitySet mapping includes a function binding, function bindings must be included for all types. The following types do not have function bindings: {0}."
        /// </summary>
        internal static string Mapping_ModificationFunction_MissingEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_MissingEntityType, p0);
        }

        /// <summary>
        ///     A string like "Parameter Mapping specified is not valid. The type '{0}' of member '{1}' in type '{2}' is not compatible with '{3}' of parameter '{4}' in function '{5}'."
        /// </summary>
        internal static string Mapping_ModificationFunction_PropertyParameterTypeMismatch(
            object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_PropertyParameterTypeMismatch, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "AssociationSet instances may only be mapped using functions in one EntitySetMapping or AssociationSetMapping. The following AssociationSet instances are mapped in multiple locations: {0}."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationSetAmbiguous(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationSetAmbiguous, p0);
        }

        /// <summary>
        ///     A string like "A function mapping includes parameter bindings for two different Ends of the same AssociationSet. Only one End of a particular AssociationSet may be mapped within a single function mapping. End Roles: {0}, {1}. AssociationSet: {2}."
        /// </summary>
        internal static string Mapping_ModificationFunction_MultipleEndsOfAssociationMapped(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_MultipleEndsOfAssociationMapped, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "A function mapping includes multiple result bindings for a single property. Property name: {0}. Column names: {1}."
        /// </summary>
        internal static string Mapping_ModificationFunction_AmbiguousResultBinding(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AmbiguousResultBinding, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' includes function mappings for AssociationSet '{1}', but none exists in element '{2}' for type '{3}'. AssociationSets must be consistently mapped for all operations."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationSetNotMappedForOperation(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationSetNotMappedForOperation, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' includes function mappings for AssociationSet '{1}' that requires type '{2}'."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationEndMappingInvalidForEntityType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationEndMappingInvalidForEntityType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "A function mapping for 'to' role {0} is not permitted because it is a foreign key association."
        /// </summary>
        internal static string Mapping_ModificationFunction_AssociationEndMappingForeignKeyAssociation(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ModificationFunction_AssociationEndMappingForeignKeyAssociation, p0);
        }

        /// <summary>
        ///     A string like "The conceptual side property '{0}' has already been mapped to a storage property with type '{1}'. If the conceptual side property is mapped to multiple properties in the storage model, make sure that all the properties in the storage model have the same type."
        /// </summary>
        internal static string Mapping_StoreTypeMismatch_ScalarPropertyMapping(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_StoreTypeMismatch_ScalarPropertyMapping, p0, p1);
        }

        /// <summary>
        ///     A string like "MakeColumnsDistinct flag can only be placed within a container that does not generate update views. Mark GenerateUpdateViews attribute to 'false' within EntityContainerMapping."
        /// </summary>
        internal static string Mapping_DistinctFlagInReadWriteContainer
        {
            get { return EntityRes.GetString(EntityRes.Mapping_DistinctFlagInReadWriteContainer); }
        }

        /// <summary>
        ///     A string like "The store provider did not return a valid EdmType for '{0}'."
        /// </summary>
        internal static string Mapping_ProviderReturnsNullType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_ProviderReturnsNullType, p0);
        }

        /// <summary>
        ///     A string like "The version of EdmItemCollection must match the version of StoreItemCollection."
        /// </summary>
        internal static string Mapping_DifferentEdmStoreVersion
        {
            get { return EntityRes.GetString(EntityRes.Mapping_DifferentEdmStoreVersion); }
        }

        /// <summary>
        ///     A string like "The version of the loaded mapping files must be the same as the version of loaded EdmItemCollection and StoreItemCollection."
        /// </summary>
        internal static string Mapping_DifferentMappingEdmStoreVersion
        {
            get { return EntityRes.GetString(EntityRes.Mapping_DifferentMappingEdmStoreVersion); }
        }

        /// <summary>
        ///     A string like "The storage function '{0}' does not exist."
        /// </summary>
        internal static string Mapping_FunctionImport_StoreFunctionDoesNotExist(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_StoreFunctionDoesNotExist, p0);
        }

        /// <summary>
        ///     A string like "The FunctionImport '{0}' does not exist in container '{1}'."
        /// </summary>
        internal static string Mapping_FunctionImport_FunctionImportDoesNotExist(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_FunctionImportDoesNotExist, p0, p1);
        }

        /// <summary>
        ///     A string like "The FunctionImport '{0}' has already been mapped."
        /// </summary>
        internal static string Mapping_FunctionImport_FunctionImportMappedMultipleTimes(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_FunctionImportMappedMultipleTimes, p0);
        }

        /// <summary>
        ///     A string like "The non-composable function import '{0}' is mapped to the composable store function '{1}'. Non-composable function imports can be mapped only to stored procedures."
        /// </summary>
        internal static string Mapping_FunctionImport_TargetFunctionMustBeNonComposable(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_TargetFunctionMustBeNonComposable, p0, p1);
        }

        /// <summary>
        ///     A string like "The composable function import '{0}' is mapped to the non-composable store function '{1}'. Composable function imports can be mapped only to composable table-valued store functions."
        /// </summary>
        internal static string Mapping_FunctionImport_TargetFunctionMustBeComposable(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_TargetFunctionMustBeComposable, p0, p1);
        }

        /// <summary>
        ///     A string like "Storage function has a parameter '{0}' but no corresponding parameter was found in the FunctionImport."
        /// </summary>
        internal static string Mapping_FunctionImport_TargetParameterHasNoCorrespondingImportParameter(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_TargetParameterHasNoCorrespondingImportParameter, p0);
        }

        /// <summary>
        ///     A string like "Import function has a parameter '{0}' but no corresponding parameter was found in the storage function."
        /// </summary>
        internal static string Mapping_FunctionImport_ImportParameterHasNoCorrespondingTargetParameter(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ImportParameterHasNoCorrespondingTargetParameter, p0);
        }

        /// <summary>
        ///     A string like "Parameter '{0}' has mode '{1}' in the storage function but mode '{2}' in the FunctionImport."
        /// </summary>
        internal static string Mapping_FunctionImport_IncompatibleParameterMode(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_IncompatibleParameterMode, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Parameter '{0}' has type '{1}' in the storage that is not compatible with type '{2}' declared for the FunctionImport."
        /// </summary>
        internal static string Mapping_FunctionImport_IncompatibleParameterType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_IncompatibleParameterType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The storage function parameter '{0}' of type '{1}' does not match the corresponding FunctionImport parameter of enumeration type '{2}' with underlying type '{3}'. The underlying type of the enumeration parameter for a function defined in the conceptual model must match the corresponding storage function parameter type."
        /// </summary>
        internal static string Mapping_FunctionImport_IncompatibleEnumParameterType(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_IncompatibleEnumParameterType, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "Rows affected parameter '{0}' does not exist in function '{1}'."
        /// </summary>
        internal static string Mapping_FunctionImport_RowsAffectedParameterDoesNotExist(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_RowsAffectedParameterDoesNotExist, p0, p1);
        }

        /// <summary>
        ///     A string like "Rows affected parameter '{0}' is of type '{1}'. Must be an integer numeric type."
        /// </summary>
        internal static string Mapping_FunctionImport_RowsAffectedParameterHasWrongType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_RowsAffectedParameterHasWrongType, p0, p1);
        }

        /// <summary>
        ///     A string like "Rows affected parameter '{0}' has mode '{1}'. Must have mode '{2}' or '{3}'."
        /// </summary>
        internal static string Mapping_FunctionImport_RowsAffectedParameterHasWrongMode(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_RowsAffectedParameterHasWrongMode, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "An {0} element can only be declared for a FunctionImport declaring an EntitySet. FunctionImport '{1}' does not declare an EntitySet."
        /// </summary>
        internal static string Mapping_FunctionImport_EntityTypeMappingForFunctionNotReturningEntitySet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_EntityTypeMappingForFunctionNotReturningEntitySet, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntityType '{0}' specified is not the declared type '{1}' nor a derivation of the type of the EntitySet '{2}' for FunctionImport '{3}'."
        /// </summary>
        internal static string Mapping_FunctionImport_InvalidContentEntityTypeForEntitySet(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_InvalidContentEntityTypeForEntitySet, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The condition value specified for {0} is not compatible with the type returned by the storage provider. Column name: '{1}', ResultType: '{2}'. "
        /// </summary>
        internal static string Mapping_FunctionImport_ConditionValueTypeMismatch(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ConditionValueTypeMismatch, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The type returned by the storage provider is not supported for type conditions. Column name: '{0}', ResultType: '{1}'."
        /// </summary>
        internal static string Mapping_FunctionImport_UnsupportedType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_UnsupportedType, p0, p1);
        }

        /// <summary>
        ///     A string like "The number of ResultMapping elements for the FunctionImport '{0}' does not match the number of specified ReturnType elements."
        /// </summary>
        internal static string Mapping_FunctionImport_ResultMappingCountDoesNotMatchResultCount(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ResultMappingCountDoesNotMatchResultCount, p0);
        }

        /// <summary>
        ///     A string like "Mapping of the function import '{0}' is not valid. Mapped type '{1}' is not compatible with the return type of the function import."
        /// </summary>
        internal static string Mapping_FunctionImport_ResultMapping_MappedTypeDoesNotMatchReturnType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ResultMapping_MappedTypeDoesNotMatchReturnType, p0, p1);
        }

        /// <summary>
        ///     A string like "Mapping of the function import '{0}' is not valid. ComplexTypeMapping is supported only for function imports returning a collection of ComplexType."
        /// </summary>
        internal static string Mapping_FunctionImport_ResultMapping_InvalidCTypeCTExpected(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ResultMapping_InvalidCTypeCTExpected, p0);
        }

        /// <summary>
        ///     A string like "Mapping of the function import '{0}' is not valid. EntityTypeMapping is supported only for function imports returning a collection of EntityType."
        /// </summary>
        internal static string Mapping_FunctionImport_ResultMapping_InvalidCTypeETExpected(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ResultMapping_InvalidCTypeETExpected, p0);
        }

        /// <summary>
        ///     A string like "Mapping of the function import '{0}' is not valid. Storage function return type is expected to be a collection of rows."
        /// </summary>
        internal static string Mapping_FunctionImport_ResultMapping_InvalidSType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ResultMapping_InvalidSType, p0);
        }

        /// <summary>
        ///     A string like "No mapping specified for the conceptual property '{0}' of type '{1}' in the result mapping of the function import '{2}'."
        /// </summary>
        internal static string Mapping_FunctionImport_PropertyNotMapped(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_PropertyNotMapped, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The return type '{0}' of the function import '{1}' is abstract and cannot be mapped implicitly."
        /// </summary>
        internal static string Mapping_FunctionImport_ImplicitMappingForAbstractReturnType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ImplicitMappingForAbstractReturnType, p0, p1);
        }

        /// <summary>
        ///     A string like "The function import '{0}' can be mapped only to a store function that returns rows with one column. The store function '{1}' returns rows with multiple columns."
        /// </summary>
        internal static string Mapping_FunctionImport_ScalarMappingToMulticolumnTVF(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ScalarMappingToMulticolumnTVF, p0, p1);
        }

        /// <summary>
        ///     A string like "The return type '{0}' of the function import '{1}' is not compatible with the return type '{2}' of the store function '{3}'."
        /// </summary>
        internal static string Mapping_FunctionImport_ScalarMappingTypeMismatch(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_ScalarMappingTypeMismatch, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The function import mapping cannot produce an entity of type '{0}'. Ensure that conditions unambiguously imply the type. See line(s) '{1}'."
        /// </summary>
        internal static string Mapping_FunctionImport_UnreachableType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_UnreachableType, p0, p1);
        }

        /// <summary>
        ///     A string like "The function import mapping cannot produce an entity from the '{0}' type hierarchy. Ensure that conditions unambiguously imply some type in the hierarchy. See line(s) '{1}'."
        /// </summary>
        internal static string Mapping_FunctionImport_UnreachableIsTypeOf(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_UnreachableIsTypeOf, p0, p1);
        }

        /// <summary>
        ///     A string like "Unable to resolve to a specific overload of the function '{0}'."
        /// </summary>
        internal static string Mapping_FunctionImport_FunctionAmbiguous(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_FunctionAmbiguous, p0);
        }

        /// <summary>
        ///     A string like "The key properties of all entity types returned by the function import '{0}' must be mapped to the same non-nullable columns returned by the storage function."
        /// </summary>
        internal static string Mapping_FunctionImport_CannotInferTargetFunctionKeys(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_FunctionImport_CannotInferTargetFunctionKeys, p0);
        }

        /// <summary>
        ///     A string like "An entity object cannot be referenced by multiple instances of IEntityChangeTracker."
        /// </summary>
        internal static string Entity_EntityCantHaveMultipleChangeTrackers
        {
            get { return EntityRes.GetString(EntityRes.Entity_EntityCantHaveMultipleChangeTrackers); }
        }

        /// <summary>
        ///     A string like "Nullable complex types are not supported. The complex property '{0}' must not allow nulls."
        /// </summary>
        internal static string ComplexObject_NullableComplexTypesNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.ComplexObject_NullableComplexTypesNotSupported, p0);
        }

        /// <summary>
        ///     A string like "This complex object is already attached to another object."
        /// </summary>
        internal static string ComplexObject_ComplexObjectAlreadyAttachedToParent
        {
            get { return EntityRes.GetString(EntityRes.ComplexObject_ComplexObjectAlreadyAttachedToParent); }
        }

        /// <summary>
        ///     A string like "The property '{0}' could not be reported as changing. This occurred because EntityComplexMemberChanging was called with a property name that is not a complex property. For more information, see the Entity Framework documentation."
        /// </summary>
        internal static string ComplexObject_ComplexChangeRequestedOnScalarProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.ComplexObject_ComplexChangeRequestedOnScalarProperty, p0);
        }

        /// <summary>
        ///     A string like "Property '{0}' is not a valid property on the object referenced by this ObjectStateEntry."
        /// </summary>
        internal static string ObjectStateEntry_SetModifiedOnInvalidProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_SetModifiedOnInvalidProperty, p0);
        }

        /// <summary>
        ///     A string like "This ObjectStateEntry does not have original values. Objects in an added or detached state cannot have original values. "
        /// </summary>
        internal static string ObjectStateEntry_OriginalValuesDoesNotExist
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_OriginalValuesDoesNotExist); }
        }

        /// <summary>
        ///     A string like "This ObjectStateEntry does not have current values. Objects in a deleted or detached state cannot have current values."
        /// </summary>
        internal static string ObjectStateEntry_CurrentValuesDoesNotExist
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CurrentValuesDoesNotExist); }
        }

        /// <summary>
        ///     A string like "The object is in a detached state. This operation cannot be performed on an ObjectStateEntry when the object is detached."
        /// </summary>
        internal static string ObjectStateEntry_InvalidState
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_InvalidState); }
        }

        /// <summary>
        ///     A string like "The property '{0}' is part of the object's key information and cannot be modified. "
        /// </summary>
        internal static string ObjectStateEntry_CannotModifyKeyProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_CannotModifyKeyProperty, p0);
        }

        /// <summary>
        ///     A string like "The ObjectStateEntry is a relationship entry. The current and original values of relationship entries cannot be modified."
        /// </summary>
        internal static string ObjectStateEntry_CantModifyRelationValues
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CantModifyRelationValues); }
        }

        /// <summary>
        ///     A string like "The ObjectStateEntry is a relationship entry. The state of relationship entries cannot be modified."
        /// </summary>
        internal static string ObjectStateEntry_CantModifyRelationState
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CantModifyRelationState); }
        }

        /// <summary>
        ///     A string like "The object is in a detached or deleted state. An ObjectStateEntry in this state cannot be modified."
        /// </summary>
        internal static string ObjectStateEntry_CantModifyDetachedDeletedEntries
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CantModifyDetachedDeletedEntries); }
        }

        /// <summary>
        ///     A string like "{0} cannot be called because the object is not in a modified or unchanged state."
        /// </summary>
        internal static string ObjectStateEntry_SetModifiedStates(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_SetModifiedStates, p0);
        }

        /// <summary>
        ///     A string like "The EntityKey property can only be set when the current value of the property is null."
        /// </summary>
        internal static string ObjectStateEntry_CantSetEntityKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CantSetEntityKey); }
        }

        /// <summary>
        ///     A string like "The ObjectStateEntry is a key entry and its current and original values are not accessible."
        /// </summary>
        internal static string ObjectStateEntry_CannotAccessKeyEntryValues
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CannotAccessKeyEntryValues); }
        }

        /// <summary>
        ///     A string like "The ObjectStateEntry is a key entry and its state cannot be modified."
        /// </summary>
        internal static string ObjectStateEntry_CannotModifyKeyEntryState
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CannotModifyKeyEntryState); }
        }

        /// <summary>
        ///     A string like "The ObjectStateEntry is a key entry. Delete cannot be called on key entries."
        /// </summary>
        internal static string ObjectStateEntry_CannotDeleteOnKeyEntry
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_CannotDeleteOnKeyEntry); }
        }

        /// <summary>
        ///     A string like "EntityMemberChanged or EntityComplexMemberChanged was called without first calling EntityMemberChanging or EntityComplexMemberChanging on the same change tracker with the same property name. For information about properly reporting changes, see the Entity Framework documentation. "
        /// </summary>
        internal static string ObjectStateEntry_EntityMemberChangedWithoutEntityMemberChanging
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_EntityMemberChangedWithoutEntityMemberChanging); }
        }

        /// <summary>
        ///     A string like "The property '{0}' does not have a valid entity mapping on the entity object. For more information, see the Entity Framework documentation."
        /// </summary>
        internal static string ObjectStateEntry_ChangeOnUnmappedProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_ChangeOnUnmappedProperty, p0);
        }

        /// <summary>
        ///     A string like "The property '{0}' does not have a valid entity mapping on the complex type. For more information, see the Entity Framework documentation."
        /// </summary>
        internal static string ObjectStateEntry_ChangeOnUnmappedComplexProperty(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_ChangeOnUnmappedComplexProperty, p0);
        }

        /// <summary>
        ///     A string like "The change cannot be tracked because the state of the object changed from '{0}' to '{1}' since the previous call to EntityMemberChanging or EntityComplexMemberChanging on the same change tracker with the same property name. For information about properly reporting changes, see the Entity Framework documentation. "
        /// </summary>
        internal static string ObjectStateEntry_ChangedInDifferentStateFromChanging(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_ChangedInDifferentStateFromChanging, p0, p1);
        }

        /// <summary>
        ///     A string like "The navigation property '{0}' on entity of type '{1}' must implement IEnumerable in order for Entity Framework to be able to track changes in collections."
        /// </summary>
        internal static string ObjectStateEntry_UnableToEnumerateCollection(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_UnableToEnumerateCollection, p0, p1);
        }

        /// <summary>
        ///     A string like "A RelationshipManager object cannot be returned for this ObjectStateEntry instance. Only an ObjectStateEntry that represents an entity has an associated RelationshipManager."
        /// </summary>
        internal static string ObjectStateEntry_RelationshipAndKeyEntriesDoNotHaveRelationshipManagers
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_RelationshipAndKeyEntriesDoNotHaveRelationshipManagers); }
        }

        /// <summary>
        ///     A string like "The value for the complex property could not be set. Complex properties must be set to an object that implements IExtendedDataRecord."
        /// </summary>
        internal static string ObjectStateEntry_InvalidTypeForComplexTypeProperty
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateEntry_InvalidTypeForComplexTypeProperty); }
        }

        /// <summary>
        ///     A string like "The entity of type '{0}' references the same complex object of type '{1}' more than once. Complex objects cannot be referenced multiple times by the same entity."
        /// </summary>
        internal static string ObjectStateEntry_ComplexObjectUsedMultipleTimes(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_ComplexObjectUsedMultipleTimes, p0, p1);
        }

        /// <summary>
        ///     A string like "The original value for the property '{0}' cannot be set because it is a complex property. Individual scalar properties can be set on a complex type if the type is first obtained as a OriginalValueRecord from the entity's original values."
        /// </summary>
        internal static string ObjectStateEntry_SetOriginalComplexProperties(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_SetOriginalComplexProperties, p0);
        }

        /// <summary>
        ///     A string like "The original value for the property '{0}' cannot be set to null because the '{1}' member on the entity type '{2}' is not nullable."
        /// </summary>
        internal static string ObjectStateEntry_NullOriginalValueForNonNullableProperty(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_NullOriginalValueForNonNullableProperty, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The original value for the property '{0}' cannot be set because the property is part of the entity's key."
        /// </summary>
        internal static string ObjectStateEntry_SetOriginalPrimaryKey(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateEntry_SetOriginalPrimaryKey, p0);
        }

        /// <summary>
        ///     A string like "The supplied EntityKey does not have a corresponding entry in the ObjectStateManager."
        /// </summary>
        internal static string ObjectStateManager_NoEntryExistForEntityKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_NoEntryExistForEntityKey); }
        }

        /// <summary>
        ///     A string like "The ObjectStateManager does not contain an ObjectStateEntry with a reference to an object of type '{0}'."
        /// </summary>
        internal static string ObjectStateManager_NoEntryExistsForObject(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateManager_NoEntryExistsForObject, p0);
        }

        /// <summary>
        ///     A string like "An object with a key that matches the key of the supplied object could not be found in the ObjectStateManager. Verify that the key values of the supplied object match the key values of the object to which changes must be applied."
        /// </summary>
        internal static string ObjectStateManager_EntityNotTracked
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_EntityNotTracked); }
        }

        /// <summary>
        ///     A string like "Objects in a detached state do not exist in the ObjectStateManager."
        /// </summary>
        internal static string ObjectStateManager_DetachedObjectStateEntriesDoesNotExistInObjectStateManager
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_DetachedObjectStateEntriesDoesNotExistInObjectStateManager); }
        }

        /// <summary>
        ///     A string like "An object with the same key already exists in the ObjectStateManager. The ObjectStateManager cannot track multiple objects with the same key."
        /// </summary>
        internal static string ObjectStateManager_ObjectStateManagerContainsThisEntityKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_ObjectStateManagerContainsThisEntityKey); }
        }

        /// <summary>
        ///     A string like "An object with the same key already exists in the ObjectStateManager. The existing object is in the {0} state. An object can only be added to the ObjectStateManager again if it is in the added state."
        /// </summary>
        internal static string ObjectStateManager_DoesnotAllowToReAddUnchangedOrModifiedOrDeletedEntity(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateManager_DoesnotAllowToReAddUnchangedOrModifiedOrDeletedEntity, p0);
        }

        /// <summary>
        ///     A string like "AcceptChanges cannot continue because the object's key values conflict with another object in the ObjectStateManager. Make sure that the key values are unique before calling AcceptChanges."
        /// </summary>
        internal static string ObjectStateManager_CannotFixUpKeyToExistingValues
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_CannotFixUpKeyToExistingValues); }
        }

        /// <summary>
        ///     A string like "The value of a property that is part of an object's key does not match the corresponding property value stored in the ObjectContext.  This can occur if properties that are part of the key return inconsistent or incorrect values or if DetectChanges is not called after changes are made to a property that is part of the key."
        /// </summary>
        internal static string ObjectStateManager_KeyPropertyDoesntMatchValueInKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_KeyPropertyDoesntMatchValueInKey); }
        }

        /// <summary>
        ///     A string like "The object cannot be attached because the value of a property that is a part of the EntityKey does not match the corresponding value in the EntityKey."
        /// </summary>
        internal static string ObjectStateManager_KeyPropertyDoesntMatchValueInKeyForAttach
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_KeyPropertyDoesntMatchValueInKeyForAttach); }
        }

        /// <summary>
        ///     A string like "The object's EntityKey value is not valid."
        /// </summary>
        internal static string ObjectStateManager_InvalidKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_InvalidKey); }
        }

        /// <summary>
        ///     A string like "EntityType '{0}' does not exist in the EntitySet '{1}'."
        /// </summary>
        internal static string ObjectStateManager_EntityTypeDoesnotMatchtoEntitySetType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectStateManager_EntityTypeDoesnotMatchtoEntitySetType, p0, p1);
        }

        /// <summary>
        ///     A string like "An object of type '{0}' must have a corresponding EntityKey value that is not null."
        /// </summary>
        internal static string ObjectStateManager_GetEntityKeyRequiresObjectToHaveAKey(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectStateManager_GetEntityKeyRequiresObjectToHaveAKey, p0);
        }

        /// <summary>
        ///     A string like "AcceptChanges cannot continue because the object's EntityKey value is null or is not a temporary key. This can happen when the EntityKey property is modified while the object is in an added state."
        /// </summary>
        internal static string ObjectStateManager_AcceptChangesEntityKeyIsNotValid
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_AcceptChangesEntityKeyIsNotValid); }
        }

        /// <summary>
        ///     A string like "The object cannot be added to the object context. The object's EntityKey has an ObjectStateEntry that indicates that the object is already participating in a different relationship."
        /// </summary>
        internal static string ObjectStateManager_EntityConflictsWithKeyEntry
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_EntityConflictsWithKeyEntry); }
        }

        /// <summary>
        ///     A string like "A RelationshipManager cannot be returned for this object. A RelationshipManager can only be returned for objects that are either tracked by the ObjectStateManager or that implement IEntityWithRelationships."
        /// </summary>
        internal static string ObjectStateManager_CannotGetRelationshipManagerForDetachedPocoEntity
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_CannotGetRelationshipManagerForDetachedPocoEntity); }
        }

        /// <summary>
        ///     A string like "Cannot change relationship's state to the state other than deleted or detached if the source or target entity is in the deleted state."
        /// </summary>
        internal static string ObjectStateManager_CannotChangeRelationshipStateEntityDeleted
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_CannotChangeRelationshipStateEntityDeleted); }
        }

        /// <summary>
        ///     A string like "Cannot change relationship's state to the state other than added or detached if the source or target entity is in the added state."
        /// </summary>
        internal static string ObjectStateManager_CannotChangeRelationshipStateEntityAdded
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_CannotChangeRelationshipStateEntityAdded); }
        }

        /// <summary>
        ///     A string like "Cannot change state of a relationship if one of the ends of the relationship is a KeyEntry."
        /// </summary>
        internal static string ObjectStateManager_CannotChangeRelationshipStateKeyEntry
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_CannotChangeRelationshipStateKeyEntry); }
        }

        /// <summary>
        ///     A string like "Conflicting changes to the role '{0}' of the relationship '{1}' have been detected."
        /// </summary>
        internal static string ObjectStateManager_ConflictingChangesOfRelationshipDetected(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectStateManager_ConflictingChangesOfRelationshipDetected, p0, p1);
        }

        /// <summary>
        ///     A string like "The ChangeRelationshipState method is not supported for relationships that are defined by using foreign-key values."
        /// </summary>
        internal static string ObjectStateManager_ChangeRelationshipStateNotSupportedForForeignKeyAssociations
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_ChangeRelationshipStateNotSupportedForForeignKeyAssociations); }
        }

        /// <summary>
        ///     A string like "The object state cannot be changed. This exception may result from one or more of the primary key properties being set to null. Non-Added objects cannot have null primary key values.  See inner exception for details."
        /// </summary>
        internal static string ObjectStateManager_ChangeStateFromAddedWithNullKeyIsInvalid
        {
            get { return EntityRes.GetString(EntityRes.ObjectStateManager_ChangeStateFromAddedWithNullKeyIsInvalid); }
        }

        /// <summary>
        ///     A string like "The following objects have not been refreshed because they were not found in the store: {0}."
        /// </summary>
        internal static string ObjectContext_ClientEntityRemovedFromStore(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_ClientEntityRemovedFromStore, p0);
        }

        /// <summary>
        ///     A string like "The refresh attempt has failed because an unexpected entity was returned by the data source."
        /// </summary>
        internal static string ObjectContext_StoreEntityNotPresentInClient
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_StoreEntityNotPresentInClient); }
        }

        /// <summary>
        ///     A string like "The supplied connection string is not valid, because it contains insufficient mapping or metadata information."
        /// </summary>
        internal static string ObjectContext_InvalidConnectionString
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_InvalidConnectionString); }
        }

        /// <summary>
        ///     A string like "The supplied connection is not valid because it contains insufficient mapping or metadata information."
        /// </summary>
        internal static string ObjectContext_InvalidConnection
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_InvalidConnection); }
        }

        /// <summary>
        ///     A string like "The DbDataAdapter returned from DbConnection.ProviderFactory.CreateDataAdapter() must implement IEntityDataAdapter."
        /// </summary>
        internal static string ObjectContext_InvalidDataAdapter
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_InvalidDataAdapter); }
        }

        /// <summary>
        ///     A string like "The specified default EntityContainer name '{0}' could not be found in the mapping and metadata information."
        /// </summary>
        internal static string ObjectContext_InvalidDefaultContainerName(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_InvalidDefaultContainerName, p0);
        }

        /// <summary>
        ///     A string like "The element at index {0} in the collection of objects to refresh is in the added state. Objects in this state cannot be refreshed."
        /// </summary>
        internal static string ObjectContext_NthElementInAddedState(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_NthElementInAddedState, p0);
        }

        /// <summary>
        ///     A string like "The element at index {0} in the collection of objects to refresh is a duplicate of an object that is already in the collection."
        /// </summary>
        internal static string ObjectContext_NthElementIsDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_NthElementIsDuplicate, p0);
        }

        /// <summary>
        ///     A string like "The element at index {0} in the collection of objects to refresh is null."
        /// </summary>
        internal static string ObjectContext_NthElementIsNull(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_NthElementIsNull, p0);
        }

        /// <summary>
        ///     A string like "The element at index {0} in the collection of objects to refresh has a null EntityKey property value or is not attached to this ObjectStateManager."
        /// </summary>
        internal static string ObjectContext_NthElementNotInObjectStateManager(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_NthElementNotInObjectStateManager, p0);
        }

        /// <summary>
        ///     A string like "An object with the specified EntityKey value could not be found."
        /// </summary>
        internal static string ObjectContext_ObjectNotFound
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_ObjectNotFound); }
        }

        /// <summary>
        ///     A string like "The object cannot be deleted because it was not found in the ObjectStateManager."
        /// </summary>
        internal static string ObjectContext_CannotDeleteEntityNotInObjectStateManager
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_CannotDeleteEntityNotInObjectStateManager); }
        }

        /// <summary>
        ///     A string like "The object cannot be detached because it is not attached to the ObjectStateManager."
        /// </summary>
        internal static string ObjectContext_CannotDetachEntityNotInObjectStateManager
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_CannotDetachEntityNotInObjectStateManager); }
        }

        /// <summary>
        ///     A string like "The EntitySet name '{0}' could not be found."
        /// </summary>
        internal static string ObjectContext_EntitySetNotFoundForName(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_EntitySetNotFoundForName, p0);
        }

        /// <summary>
        ///     A string like "The EntityContainer name '{0}' could not be found."
        /// </summary>
        internal static string ObjectContext_EntityContainerNotFoundForName(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_EntityContainerNotFoundForName, p0);
        }

        /// <summary>
        ///     A string like "The specified CommandTimeout value is not valid. It must be a positive number."
        /// </summary>
        internal static string ObjectContext_InvalidCommandTimeout
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_InvalidCommandTimeout); }
        }

        /// <summary>
        ///     A string like "Mapping and metadata information could not be found for EntityType '{0}'."
        /// </summary>
        internal static string ObjectContext_NoMappingForEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_NoMappingForEntityType, p0);
        }

        /// <summary>
        ///     A string like "The object cannot be attached because it is already in the object context. An object can only be reattached when it is in an unchanged state. "
        /// </summary>
        internal static string ObjectContext_EntityAlreadyExistsInObjectStateManager
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_EntityAlreadyExistsInObjectStateManager); }
        }

        /// <summary>
        ///     A string like "The EntitySet name '{0}.{1}' from the object's EntityKey does not match the expected EntitySet name, '{2}.{3}'."
        /// </summary>
        internal static string ObjectContext_InvalidEntitySetInKey(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_InvalidEntitySetInKey, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "An object with a null EntityKey value cannot be attached to an object context."
        /// </summary>
        internal static string ObjectContext_CannotAttachEntityWithoutKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_CannotAttachEntityWithoutKey); }
        }

        /// <summary>
        ///     A string like "An object with a temporary EntityKey value cannot be attached to an object context."
        /// </summary>
        internal static string ObjectContext_CannotAttachEntityWithTemporaryKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_CannotAttachEntityWithTemporaryKey); }
        }

        /// <summary>
        ///     A string like "The EntitySet name could not be determined. To attach an object, supply a valid EntitySet name and make sure that the object has a valid EntityKey."
        /// </summary>
        internal static string ObjectContext_EntitySetNameOrEntityKeyRequired
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_EntitySetNameOrEntityKeyRequired); }
        }

        /// <summary>
        ///     A string like "The type parameter '{0}' in ExecuteFunction is incompatible with the type '{1}' returned by the function. "
        /// </summary>
        internal static string ObjectContext_ExecuteFunctionTypeMismatch(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_ExecuteFunctionTypeMismatch, p0, p1);
        }

        /// <summary>
        ///     A string like "The stored procedure or function '{1}' returned the type '{0}'. ExecuteFunction only supports stored procedures and functions that return collections of entity objects or collections of complex objects. "
        /// </summary>
        internal static string ObjectContext_ExecuteFunctionCalledWithScalarFunction(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_ExecuteFunctionCalledWithScalarFunction, p0, p1);
        }

        /// <summary>
        ///     A string like "The stored procedure or function '{0}' does not have a return type. ExecuteFunction only supports stored procedures and functions that have a return type. "
        /// </summary>
        internal static string ObjectContext_ExecuteFunctionCalledWithNonQueryFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_ExecuteFunctionCalledWithNonQueryFunction, p0);
        }

        /// <summary>
        ///     A string like "The parameter at index {0} in the parameters array is null."
        /// </summary>
        internal static string ObjectContext_ExecuteFunctionCalledWithNullParameter(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_ExecuteFunctionCalledWithNullParameter, p0);
        }

        /// <summary>
        ///     A string like "The EntityContainer name could not be determined. The provided EntitySet name must be qualified by the EntityContainer name, such as 'EntityContainerName.EntitySetName', or the DefaultContainerName property must be set for the ObjectContext."
        /// </summary>
        internal static string ObjectContext_ContainerQualifiedEntitySetNameRequired
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_ContainerQualifiedEntitySetNameRequired); }
        }

        /// <summary>
        ///     A string like "The DefaultContainerName property has already been set for this ObjectContext. This property cannot be changed after it has been set. "
        /// </summary>
        internal static string ObjectContext_CannotSetDefaultContainerName
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_CannotSetDefaultContainerName); }
        }

        /// <summary>
        ///     A string like "The provided EntitySet name must be qualified by the EntityContainer name, such as 'EntityContainerName.EntitySetName', or the DefaultContainerName property must be set for the ObjectContext."
        /// </summary>
        internal static string ObjectContext_QualfiedEntitySetName
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_QualfiedEntitySetName); }
        }

        /// <summary>
        ///     A string like "The object in the ObjectContext is of type '{0}', but the modified object provided is of type '{1}'. The two objects must be of the same EntityType for changes to be applied. "
        /// </summary>
        internal static string ObjectContext_EntitiesHaveDifferentType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_EntitiesHaveDifferentType, p0, p1);
        }

        /// <summary>
        ///     A string like "The existing object in the ObjectContext is in the {0} state. Changes can only be applied when the existing object is in an unchanged or modified state."
        /// </summary>
        internal static string ObjectContext_EntityMustBeUnchangedOrModified(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_EntityMustBeUnchangedOrModified, p0);
        }

        /// <summary>
        ///     A string like "The existing object in the ObjectContext is in the {0} state. Original values can be changed when the existing object is in an unchanged, modified or deleted state."
        /// </summary>
        internal static string ObjectContext_EntityMustBeUnchangedOrModifiedOrDeleted(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_EntityMustBeUnchangedOrModifiedOrDeleted, p0);
        }

        /// <summary>
        ///     A string like "The changes to the database were committed successfully, but an error occurred while updating the object context. The ObjectContext might be in an inconsistent state. Inner exception message: {0}"
        /// </summary>
        internal static string ObjectContext_AcceptAllChangesFailure(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_AcceptAllChangesFailure, p0);
        }

        /// <summary>
        ///     A string like "The operation failed: The relationship could not be changed because one or more of the foreign-key properties is non-nullable. When a change is made to a relationship, the related foreign-key property is set to a null value. If the foreign-key does not support null values, a new relationship must be defined, the foreign-key property must be assigned another non-null value, or the unrelated object must be deleted."
        /// </summary>
        internal static string ObjectContext_CommitWithConceptualNull
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_CommitWithConceptualNull); }
        }

        /// <summary>
        ///     A string like "The EntitySet, '{0}', from the entity's EntityKey does not match the entity's type, '{1}'."
        /// </summary>
        internal static string ObjectContext_InvalidEntitySetOnEntity(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_InvalidEntitySetOnEntity, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified entity type, '{0}', does not match the type '{1}' from the EntitySet '{2}'."
        /// </summary>
        internal static string ObjectContext_InvalidObjectSetTypeForEntitySet(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_InvalidObjectSetTypeForEntitySet, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The operation could not be completed because the required metadata could not be found. Make sure that the connection used by the ObjectContext is open before attempting this operation."
        /// </summary>
        internal static string ObjectContext_RequiredMetadataNotAvailble
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_RequiredMetadataNotAvailble); }
        }

        /// <summary>
        ///     A string like "The metadata stored by the ObjectContext is different than the metadata stored by the ObjectContext's connection. This can happen if the connection string is changed after the ObjectContext is created."
        /// </summary>
        internal static string ObjectContext_MetadataHasChanged
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_MetadataHasChanged); }
        }

        /// <summary>
        ///     A string like "The EntitySet name '{0}.{1}' from the entity's EntityKey does not match the expected EntitySet name '{2}.{3}' from the '{4}' parameter."
        /// </summary>
        internal static string ObjectContext_InvalidEntitySetInKeyFromName(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_InvalidEntitySetInKeyFromName, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "The ObjectContext instance has been disposed and can no longer be used for operations that require a connection."
        /// </summary>
        internal static string ObjectContext_ObjectDisposed
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_ObjectDisposed); }
        }

        /// <summary>
        ///     A string like "Cannot explicitly load {0} for entities that are detached.  Objects loaded using the NoTracking merge option are always detached."
        /// </summary>
        internal static string ObjectContext_CannotExplicitlyLoadDetachedRelationships(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_CannotExplicitlyLoadDetachedRelationships, p0);
        }

        /// <summary>
        ///     A string like "Cannot load {0} using a context different than that with which the object was loaded."
        /// </summary>
        internal static string ObjectContext_CannotLoadReferencesUsingDifferentContext(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_CannotLoadReferencesUsingDifferentContext, p0);
        }

        /// <summary>
        ///     A string like "The selector expression for LoadProperty must be a MemberAccess for the property."
        /// </summary>
        internal static string ObjectContext_SelectorExpressionMustBeMemberAccess
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_SelectorExpressionMustBeMemberAccess); }
        }

        /// <summary>
        ///     A string like "The EntitySet could not be determined for the specified entity type '{0}' because there is more than one EntitySet defined for this type in the EntityContainer '{1}'. Use the overload of the CreateObjectSet<TEntity>() method that takes a string parameter if you want to use the TEntity type and a specific EntitySet."
        /// </summary>
        internal static string ObjectContext_MultipleEntitySetsFoundInSingleContainer(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_MultipleEntitySetsFoundInSingleContainer, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntitySet could not be determined for the specified entity type '{0}' because there is more than one EntitySet defined for this type in multiple EntityContainers in the metadata. Use the overload of the CreateObjectSet<TEntity>() method that takes a string parameter if you want to use the TEntity type and a specific EntitySet."
        /// </summary>
        internal static string ObjectContext_MultipleEntitySetsFoundInAllContainers(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_MultipleEntitySetsFoundInAllContainers, p0);
        }

        /// <summary>
        ///     A string like "There are no EntitySets defined for the specified entity type '{0}'. If '{0}' is a derived type, use the base type instead."
        /// </summary>
        internal static string ObjectContext_NoEntitySetFoundForType(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_NoEntitySetFoundForType, p0);
        }

        /// <summary>
        ///     A string like "The specified entity cannot be deleted from the ObjectSet because the entity is a member of the EntitySet '{0}.{1}' instead of the EntitySet '{2}.{3}' that is referenced by the ObjectSet. Use the DeleteObject method on the ObjectSet that contains the entity, or use the ObjectContext.DeleteObject method if you want to delete the entity without validating its EntitySet."
        /// </summary>
        internal static string ObjectContext_EntityNotInObjectSet_Delete(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_EntityNotInObjectSet_Delete, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The specified entity cannot be detached from the ObjectSet because the entity is a member of the EntitySet '{0}.{1}' instead of the EntitySet '{2}.{3}' that is referenced by the ObjectSet. Use the Detach method on the ObjectSet that contains the entity, or use the ObjectContext.Detach method if you want to delete the entity without validating its EntitySet."
        /// </summary>
        internal static string ObjectContext_EntityNotInObjectSet_Detach(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_EntityNotInObjectSet_Detach, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The EntityState value passed for the entity is not valid. The EntityState value must be one of the following: Added, Deleted, Detached, Modified, or Unchanged."
        /// </summary>
        internal static string ObjectContext_InvalidEntityState
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_InvalidEntityState); }
        }

        /// <summary>
        ///     A string like "The EntityState value passed for the relationship is not valid. The EntityState value must be one of the following: Added, Deleted, Detached, or Unchanged. Relationships cannot be set to the Modified state."
        /// </summary>
        internal static string ObjectContext_InvalidRelationshipState
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_InvalidRelationshipState); }
        }

        /// <summary>
        ///     A string like "An object that has a key that matches the key of the supplied object could not be found in the ObjectStateManager. Verify that the object to which changes must be applied is not in the Added state and that its key values match the key values of the supplied object."
        /// </summary>
        internal static string ObjectContext_EntityNotTrackedOrHasTempKey
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_EntityNotTrackedOrHasTempKey); }
        }

        /// <summary>
        ///     A string like "When executing a command, parameters must be exclusively database parameters or values."
        /// </summary>
        internal static string ObjectContext_ExecuteCommandWithMixOfDbParameterAndValues
        {
            get { return EntityRes.GetString(EntityRes.ObjectContext_ExecuteCommandWithMixOfDbParameterAndValues); }
        }

        /// <summary>
        ///     A string like "The specified EntitySet '{0}.{1}' does not contain results of type '{2}'."
        /// </summary>
        internal static string ObjectContext_InvalidEntitySetForStoreQuery(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_InvalidEntitySetForStoreQuery, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The result type '{0}' may not be abstract and must include a default constructor."
        /// </summary>
        internal static string ObjectContext_InvalidTypeForStoreQuery(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_InvalidTypeForStoreQuery, p0);
        }

        /// <summary>
        ///     A string like "The '{0}' column is mapped to multiple properties '{1}'. Ensure a separate column exists for each property."
        /// </summary>
        internal static string ObjectContext_TwoPropertiesMappedToSameColumn(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectContext_TwoPropertiesMappedToSameColumn, p0, p1);
        }

        /// <summary>
        ///     A string like "Attach is not a valid operation when the source object associated with this related end is in an added, deleted, or detached state. Objects loaded using the NoTracking merge option are always detached."
        /// </summary>
        internal static string RelatedEnd_InvalidOwnerStateForAttach
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_InvalidOwnerStateForAttach); }
        }

        /// <summary>
        ///     A string like "The object at index {0} in the specified collection of objects is null."
        /// </summary>
        internal static string RelatedEnd_InvalidNthElementNullForAttach(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_InvalidNthElementNullForAttach, p0);
        }

        /// <summary>
        ///     A string like "The object at index {0} in the specified collection of objects is not attached to the same ObjectContext as source object of this EntityCollection."
        /// </summary>
        internal static string RelatedEnd_InvalidNthElementContextForAttach(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_InvalidNthElementContextForAttach, p0);
        }

        /// <summary>
        ///     A string like "The object at index {0} in the specified collection of objects is in an added or deleted state. Relationships cannot be created for objects in this state."
        /// </summary>
        internal static string RelatedEnd_InvalidNthElementStateForAttach(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_InvalidNthElementStateForAttach, p0);
        }

        /// <summary>
        ///     A string like "The object being attached to the source object is not attached to the same ObjectContext as the source object."
        /// </summary>
        internal static string RelatedEnd_InvalidEntityContextForAttach
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_InvalidEntityContextForAttach); }
        }

        /// <summary>
        ///     A string like "The object being attached is in an added or deleted state. Relationships cannot be created for objects in this state."
        /// </summary>
        internal static string RelatedEnd_InvalidEntityStateForAttach
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_InvalidEntityStateForAttach); }
        }

        /// <summary>
        ///     A string like "The object could not be added to the EntityCollection or EntityReference. An object that is attached to an ObjectContext cannot be added to an EntityCollection or EntityReference that is not associated with a source object. "
        /// </summary>
        internal static string RelatedEnd_UnableToAddEntity
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_UnableToAddEntity); }
        }

        /// <summary>
        ///     A string like " The object could not be removed from the EntityCollection or EntityReference. An object that is attached to an ObjectContext cannot be removed from an EntityCollection or EntityReference that is not associated with a source object."
        /// </summary>
        internal static string RelatedEnd_UnableToRemoveEntity
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_UnableToRemoveEntity); }
        }

        /// <summary>
        ///     A string like "Adding a relationship with an entity which is in the Deleted state is not allowed."
        /// </summary>
        internal static string RelatedEnd_UnableToAddRelationshipWithDeletedEntity
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_UnableToAddRelationshipWithDeletedEntity); }
        }

        /// <summary>
        ///     A string like "The relationship being added conflicts with an existing relationship. Consider deleting the previous relationship and calling ObjectContext.DetectChanges."
        /// </summary>
        internal static string RelatedEnd_ConflictingChangeOfRelationshipDetected
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_ConflictingChangeOfRelationshipDetected); }
        }

        /// <summary>
        ///     A string like "Invalid relationship fixup detected in the navigation property '{0}' of the entity of the type '{1}'."
        /// </summary>
        internal static string RelatedEnd_InvalidRelationshipFixupDetected(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_InvalidRelationshipFixupDetected, p0, p1);
        }

        /// <summary>
        ///     A string like "The {0} object could not be serialized. This type of object cannot be serialized when the RelationshipManager belongs to an entity object that does not implement IEntityWithRelationships."
        /// </summary>
        internal static string RelatedEnd_CannotSerialize(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_CannotSerialize, p0);
        }

        /// <summary>
        ///     A string like "An item cannot be added to a fixed size Array of type '{0}'."
        /// </summary>
        internal static string RelatedEnd_CannotAddToFixedSizeArray(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_CannotAddToFixedSizeArray, p0);
        }

        /// <summary>
        ///     A string like "An item cannot be removed from a fixed size Array of type '{0}'."
        /// </summary>
        internal static string RelatedEnd_CannotRemoveFromFixedSizeArray(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_CannotRemoveFromFixedSizeArray, p0);
        }

        /// <summary>
        ///     A string like "This property cannot be set to a null value."
        /// </summary>
        internal static string Materializer_PropertyIsNotNullable
        {
            get { return EntityRes.GetString(EntityRes.Materializer_PropertyIsNotNullable); }
        }

        /// <summary>
        ///     A string like "The property '{0}' cannot be set to a null value."
        /// </summary>
        internal static string Materializer_PropertyIsNotNullableWithName(object p0)
        {
            return EntityRes.GetString(EntityRes.Materializer_PropertyIsNotNullableWithName, p0);
        }

        /// <summary>
        ///     A string like "The '{2}' property on '{1}' could not be set to a '{3}' value. You must set this property to a non-null value of type '{0}'. "
        /// </summary>
        internal static string Materializer_SetInvalidValue(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Materializer_SetInvalidValue, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The specified cast from a materialized '{0}' type to the '{1}' type is not valid."
        /// </summary>
        internal static string Materializer_InvalidCastReference(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Materializer_InvalidCastReference, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified cast from a materialized '{0}' type to a nullable '{1}' type is not valid."
        /// </summary>
        internal static string Materializer_InvalidCastNullable(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Materializer_InvalidCastNullable, p0, p1);
        }

        /// <summary>
        ///     A string like "The cast to value type '{0}' failed because the materialized value is null. Either the result type's generic parameter or the query must use a nullable type."
        /// </summary>
        internal static string Materializer_NullReferenceCast(object p0)
        {
            return EntityRes.GetString(EntityRes.Materializer_NullReferenceCast, p0);
        }

        /// <summary>
        ///     A string like "All objects in the EntitySet '{0}' must have unique primary keys. However, an instance of type '{1}' and an instance of type '{2}' both have the same primary key value, '{3}'. "
        /// </summary>
        internal static string Materializer_RecyclingEntity(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.Materializer_RecyclingEntity, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "An object with a key value '{0}' already exists in an added state. An object in this state cannot be merged."
        /// </summary>
        internal static string Materializer_AddedEntityAlreadyExists(object p0)
        {
            return EntityRes.GetString(EntityRes.Materializer_AddedEntityAlreadyExists, p0);
        }

        /// <summary>
        ///     A string like "The result of a query cannot be enumerated more than once."
        /// </summary>
        internal static string Materializer_CannotReEnumerateQueryResults
        {
            get { return EntityRes.GetString(EntityRes.Materializer_CannotReEnumerateQueryResults); }
        }

        /// <summary>
        ///     A string like "Only primitive types, entity types, and complex types can be materialized."
        /// </summary>
        internal static string Materializer_UnsupportedType
        {
            get { return EntityRes.GetString(EntityRes.Materializer_UnsupportedType); }
        }

        /// <summary>
        ///     A string like "The relationship '{0}' does not match any relationship defined in the conceptual model."
        /// </summary>
        internal static string Collections_NoRelationshipSetMatched(object p0)
        {
            return EntityRes.GetString(EntityRes.Collections_NoRelationshipSetMatched, p0);
        }

        /// <summary>
        ///     A string like "An EntityCollection of {0} objects could not be returned for role name '{1}' in relationship '{2}'. Make sure that the EdmRelationshipAttribute that defines this relationship has the correct RelationshipMultiplicity for this role name. For more information, see the Entity Framework documentation."
        /// </summary>
        internal static string Collections_ExpectedCollectionGotReference(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Collections_ExpectedCollectionGotReference, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The source query for this EntityCollection or EntityReference cannot be returned when the related object is in either an added state or a detached state and was not originally retrieved using the NoTracking merge option."
        /// </summary>
        internal static string Collections_InvalidEntityStateSource
        {
            get { return EntityRes.GetString(EntityRes.Collections_InvalidEntityStateSource); }
        }

        /// <summary>
        ///     A string like "The Load method cannot return the {0} when the related object is in a deleted state."
        /// </summary>
        internal static string Collections_InvalidEntityStateLoad(object p0)
        {
            return EntityRes.GetString(EntityRes.Collections_InvalidEntityStateLoad, p0);
        }

        /// <summary>
        ///     A string like "The RelatedEnd with role name '{0}' from relationship '{1}' has already been loaded. This can occur when using a NoTracking merge option. Try using a different merge option when querying for the related object."
        /// </summary>
        internal static string Collections_CannotFillTryDifferentMergeOption(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Collections_CannotFillTryDifferentMergeOption, p0, p1);
        }

        /// <summary>
        ///     A string like "A navigation property that returns an EntityCollection cannot be changed if the existing EntityCollection contains items that are not in the new EntityCollection."
        /// </summary>
        internal static string Collections_UnableToMergeCollections
        {
            get { return EntityRes.GetString(EntityRes.Collections_UnableToMergeCollections); }
        }

        /// <summary>
        ///     A string like "An EntityReference of type '{0}' could not be returned for role name '{1}' in relationship '{2}'. Make sure that the EdmRelationshipAttribute that defines this relationship has the correct RelationshipMultiplicity for this role name. For more information, see the Entity Framework documentation."
        /// </summary>
        internal static string EntityReference_ExpectedReferenceGotCollection(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EntityReference_ExpectedReferenceGotCollection, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Multiplicity constraint violated. The role '{0}' of the relationship '{1}' has multiplicity 1 or 0..1."
        /// </summary>
        internal static string EntityReference_CannotAddMoreThanOneEntityToEntityReference(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityReference_CannotAddMoreThanOneEntityToEntityReference, p0, p1);
        }

        /// <summary>
        ///     A string like "A relationship multiplicity constraint violation occurred: An EntityReference expected at least one related object, but the query returned no related objects from the data store."
        /// </summary>
        internal static string EntityReference_LessThanExpectedRelatedEntitiesFound
        {
            get { return EntityRes.GetString(EntityRes.EntityReference_LessThanExpectedRelatedEntitiesFound); }
        }

        /// <summary>
        ///     A string like "A relationship multiplicity constraint violation occurred: An EntityReference can have no more than one related object, but the query returned more than one related object. This is a non-recoverable error."
        /// </summary>
        internal static string EntityReference_MoreThanExpectedRelatedEntitiesFound
        {
            get { return EntityRes.GetString(EntityRes.EntityReference_MoreThanExpectedRelatedEntitiesFound); }
        }

        /// <summary>
        ///     A string like "A referential integrity constraint violation occurred: A primary key property that is a part of referential integrity constraint cannot be changed when the dependent object is Unchanged unless it is being set to the association's principal object. The principal object must be tracked and not marked for deletion."
        /// </summary>
        internal static string EntityReference_CannotChangeReferentialConstraintProperty
        {
            get { return EntityRes.GetString(EntityRes.EntityReference_CannotChangeReferentialConstraintProperty); }
        }

        /// <summary>
        ///     A string like "The EntityKey property cannot be set to EntityNotValidKey, NoEntitySetKey, or a temporary key."
        /// </summary>
        internal static string EntityReference_CannotSetSpecialKeys
        {
            get { return EntityRes.GetString(EntityRes.EntityReference_CannotSetSpecialKeys); }
        }

        /// <summary>
        ///     A string like "The object could not be added or attached because its EntityReference has an EntityKey property value that does not match the EntityKey for this object."
        /// </summary>
        internal static string EntityReference_EntityKeyValueMismatch
        {
            get { return EntityRes.GetString(EntityRes.EntityReference_EntityKeyValueMismatch); }
        }

        /// <summary>
        ///     A string like "At least one related end in the relationship could not be found."
        /// </summary>
        internal static string RelatedEnd_RelatedEndNotFound
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_RelatedEndNotFound); }
        }

        /// <summary>
        ///     A string like "The {0} could not be loaded because it is not attached to an ObjectContext."
        /// </summary>
        internal static string RelatedEnd_RelatedEndNotAttachedToContext(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_RelatedEndNotAttachedToContext, p0);
        }

        /// <summary>
        ///     A string like "When an object is returned with a NoTracking merge option, Load can only be called when the EntityCollection or EntityReference does not contain objects."
        /// </summary>
        internal static string RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd); }
        }

        /// <summary>
        ///     A string like "When an object is returned with a NoTracking merge option, Load cannot be called when the IsLoaded property is true."
        /// </summary>
        internal static string RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd); }
        }

        /// <summary>
        ///     A string like "An object of type '{0}' cannot be added, attached, or removed from an EntityCollection that contains objects of type '{1}'."
        /// </summary>
        internal static string RelatedEnd_InvalidContainedType_Collection(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_InvalidContainedType_Collection, p0, p1);
        }

        /// <summary>
        ///     A string like "An object of type '{0}' cannot be set or removed from the Value property of an EntityReference of type '{1}'."
        /// </summary>
        internal static string RelatedEnd_InvalidContainedType_Reference(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_InvalidContainedType_Reference, p0, p1);
        }

        /// <summary>
        ///     A string like "The object in the '{0}' role cannot be automatically added to the context because it was retrieved using the NoTracking merge option. Explicitly attach the entity to the ObjectContext before defining the relationship."
        /// </summary>
        internal static string RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities, p0);
        }

        /// <summary>
        ///     A string like "The relationship between the two objects cannot be defined because they are attached to different ObjectContext objects."
        /// </summary>
        internal static string RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts); }
        }

        /// <summary>
        ///     A string like "Related objects cannot be loaded using the {0} merge option. Relationships cannot be created when one object was retrieved using a NoTracking merge option and the other object was retrieved using a different merge option."
        /// </summary>
        internal static string RelatedEnd_MismatchedMergeOptionOnLoad(object p0)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_MismatchedMergeOptionOnLoad, p0);
        }

        /// <summary>
        ///     A string like "The relationship cannot be defined because the EntitySet name '{0}.{1}' is not valid for the role '{2}' in association set name '{3}.{4}'."
        /// </summary>
        internal static string RelatedEnd_EntitySetIsNotValidForRelationship(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.RelatedEnd_EntitySetIsNotValidForRelationship, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "Requested operation is not allowed when the owner of this RelatedEnd is null. RelatedEnd objects that were created with the default constructor should only be used as a container during serialization."
        /// </summary>
        internal static string RelatedEnd_OwnerIsNull
        {
            get { return EntityRes.GetString(EntityRes.RelatedEnd_OwnerIsNull); }
        }

        /// <summary>
        ///     A string like "A referential integrity constraints violation occurred: Not all of the property values that define referential integrity constraints could be retrieved from related entities."
        /// </summary>
        internal static string RelationshipManager_UnableToRetrieveReferentialConstraintProperties
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_UnableToRetrieveReferentialConstraintProperties); }
        }

        /// <summary>
        ///     A string like "A referential integrity constraint violation occurred: The property values that define the referential constraints are not consistent between principal and dependent objects in the relationship."
        /// </summary>
        internal static string RelationshipManager_InconsistentReferentialConstraintProperties
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_InconsistentReferentialConstraintProperties); }
        }

        /// <summary>
        ///     A string like "A circular relationship path has been detected while enforcing a referential integrity constraints. Referential integrity cannot be enforced on circular relationships."
        /// </summary>
        internal static string RelationshipManager_CircularRelationshipsWithReferentialConstraints
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_CircularRelationshipsWithReferentialConstraints); }
        }

        /// <summary>
        ///     A string like "Metadata information for the relationship '{0}' could not be retrieved. If mapping attributes are used, make sure that the EdmRelationshipAttribute for the relationship has been defined in the assembly.  When using convention-based mapping, metadata information for relationships between detached entities cannot be determined."
        /// </summary>
        internal static string RelationshipManager_UnableToFindRelationshipTypeInMetadata(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_UnableToFindRelationshipTypeInMetadata, p0);
        }

        /// <summary>
        ///     A string like "The relationship '{0}' does not contain the role '{1}'. Make sure that EdmRelationshipAttribute that defines this relationship has the correct role names. For more information, see the Entity Framework documentation."
        /// </summary>
        internal static string RelationshipManager_InvalidTargetRole(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_InvalidTargetRole, p0, p1);
        }

        /// <summary>
        ///     A string like "The requested operation could not be completed because the object implementing IEntityWithRelationships returned a null value from the RelationshipManager property."
        /// </summary>
        internal static string RelationshipManager_UnexpectedNull
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_UnexpectedNull); }
        }

        /// <summary>
        ///     A string like "The relationship manager supplied by the object implementing IEntityWithRelationships is not the expected relationship manager."
        /// </summary>
        internal static string RelationshipManager_InvalidRelationshipManagerOwner
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_InvalidRelationshipManagerOwner); }
        }

        /// <summary>
        ///     A string like "The relationship manager was defined with an owner of type '{0}', which is not compatible with the type '{1}' for the source role '{2}' in the specified relationship, '{3}'."
        /// </summary>
        internal static string RelationshipManager_OwnerIsNotSourceType(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_OwnerIsNotSourceType, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The operation could not be completed because the object to which the relationship manager belongs was attached to the ObjectContext before the relationship manager was instantiated."
        /// </summary>
        internal static string RelationshipManager_UnexpectedNullContext
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_UnexpectedNullContext); }
        }

        /// <summary>
        ///     A string like "The EntityReference has already been initialized. {0}"
        /// </summary>
        internal static string RelationshipManager_ReferenceAlreadyInitialized(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_ReferenceAlreadyInitialized, p0);
        }

        /// <summary>
        ///     A string like "The EntityReference could not be initialized, because the relationship manager for object to which the entity reference belongs is already attached to an ObjectContext. {0}"
        /// </summary>
        internal static string RelationshipManager_RelationshipManagerAttached(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_RelationshipManagerAttached, p0);
        }

        /// <summary>
        ///     A string like "InitializeRelatedReference should only be used to initialize a new EntityReference during deserialization of an entity object."
        /// </summary>
        internal static string RelationshipManager_InitializeIsForDeserialization
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_InitializeIsForDeserialization); }
        }

        /// <summary>
        ///     A string like "The EntityCollection has already been initialized. {0}"
        /// </summary>
        internal static string RelationshipManager_CollectionAlreadyInitialized(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_CollectionAlreadyInitialized, p0);
        }

        /// <summary>
        ///     A string like "The EntityCollection could not be initialized because the relationship manager for the object to which the EntityCollection belongs is already attached to an ObjectContext. {0}"
        /// </summary>
        internal static string RelationshipManager_CollectionRelationshipManagerAttached(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_CollectionRelationshipManagerAttached, p0);
        }

        /// <summary>
        ///     A string like "The InitializeRelatedCollection method should only be called to initialize a new EntityCollection during deserialization of an object graph."
        /// </summary>
        internal static string RelationshipManager_CollectionInitializeIsForDeserialization
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_CollectionInitializeIsForDeserialization); }
        }

        /// <summary>
        ///     A string like "The specified navigation property {0} could not be found."
        /// </summary>
        internal static string RelationshipManager_NavigationPropertyNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipManager_NavigationPropertyNotFound, p0);
        }

        /// <summary>
        ///     A string like "The RelatedEnd cannot be returned by this RelationshipManager. A RelatedEnd can only be returned by a RelationshipManager for objects that are either tracked by the ObjectStateManager or that implement IEntityWithRelationships."
        /// </summary>
        internal static string RelationshipManager_CannotGetRelatEndForDetachedPocoEntity
        {
            get { return EntityRes.GetString(EntityRes.RelationshipManager_CannotGetRelatEndForDetachedPocoEntity); }
        }

        /// <summary>
        ///     A string like "The object or data row on the data binding interface cannot be replaced."
        /// </summary>
        internal static string ObjectView_CannotReplacetheEntityorRow
        {
            get { return EntityRes.GetString(EntityRes.ObjectView_CannotReplacetheEntityorRow); }
        }

        /// <summary>
        ///     A string like "The index-based insert operation is not supported on this data binding interface."
        /// </summary>
        internal static string ObjectView_IndexBasedInsertIsNotSupported
        {
            get { return EntityRes.GetString(EntityRes.ObjectView_IndexBasedInsertIsNotSupported); }
        }

        /// <summary>
        ///     A string like "Updates cannot be performed on a read-only data binding interface."
        /// </summary>
        internal static string ObjectView_WriteOperationNotAllowedOnReadOnlyBindingList
        {
            get { return EntityRes.GetString(EntityRes.ObjectView_WriteOperationNotAllowedOnReadOnlyBindingList); }
        }

        /// <summary>
        ///     A string like "The IBindingList.AddNew method is not supported when binding to a collection of abstract types. You must instead use the IList.Add method."
        /// </summary>
        internal static string ObjectView_AddNewOperationNotAllowedOnAbstractBindingList
        {
            get { return EntityRes.GetString(EntityRes.ObjectView_AddNewOperationNotAllowedOnAbstractBindingList); }
        }

        /// <summary>
        ///     A string like "The object being added is of a type that is not compatible with the type of the bound collection."
        /// </summary>
        internal static string ObjectView_IncompatibleArgument
        {
            get { return EntityRes.GetString(EntityRes.ObjectView_IncompatibleArgument); }
        }

        /// <summary>
        ///     A string like "The object could not be added to the bound collection. The specific EntitySet for the object of type '{0}' could not be determined."
        /// </summary>
        internal static string ObjectView_CannotResolveTheEntitySet(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectView_CannotResolveTheEntitySet, p0);
        }

        /// <summary>
        ///     A string like "The class '{0}' has no parameterless constructor."
        /// </summary>
        internal static string CodeGen_ConstructorNoParameterless(object p0)
        {
            return EntityRes.GetString(EntityRes.CodeGen_ConstructorNoParameterless, p0);
        }

        /// <summary>
        ///     A string like "Properties are not supported on value types."
        /// </summary>
        internal static string CodeGen_PropertyDeclaringTypeIsValueType
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyDeclaringTypeIsValueType); }
        }

        /// <summary>
        ///     A string like "Properties with StrongNameIdentityPermissionAttribute applied are not supported."
        /// </summary>
        internal static string CodeGen_PropertyStrongNameIdentity
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyStrongNameIdentity); }
        }

        /// <summary>
        ///     A string like "The property has an unexpected return type or parameter."
        /// </summary>
        internal static string CodeGen_PropertyUnsupportedForm
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyUnsupportedForm); }
        }

        /// <summary>
        ///     A string like "The property uses an unsupported type."
        /// </summary>
        internal static string CodeGen_PropertyUnsupportedType
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyUnsupportedType); }
        }

        /// <summary>
        ///     A string like "Indexed properties are not supported."
        /// </summary>
        internal static string CodeGen_PropertyIsIndexed
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyIsIndexed); }
        }

        /// <summary>
        ///     A string like "Static properties are not supported."
        /// </summary>
        internal static string CodeGen_PropertyIsStatic
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyIsStatic); }
        }

        /// <summary>
        ///     A string like "The property getter does not exist."
        /// </summary>
        internal static string CodeGen_PropertyNoGetter
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyNoGetter); }
        }

        /// <summary>
        ///     A string like "The property setter does not exist."
        /// </summary>
        internal static string CodeGen_PropertyNoSetter
        {
            get { return EntityRes.GetString(EntityRes.CodeGen_PropertyNoSetter); }
        }

        /// <summary>
        ///     A string like "Unable to set field/property {0} on entity type {1}. See InnerException for details."
        /// </summary>
        internal static string PocoEntityWrapper_UnableToSetFieldOrProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PocoEntityWrapper_UnableToSetFieldOrProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The navigation property of type '{0}' is not a single implementation of '{1}'."
        /// </summary>
        internal static string PocoEntityWrapper_UnexpectedTypeForNavigationProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PocoEntityWrapper_UnexpectedTypeForNavigationProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The collection navigation property '{0}' of type '{1}' returned null. For a collection to be initialized automatically, it must be of type ICollection<T>, IList
        ///                                                                                                                                                                              <T>, ISet
        ///                                                                                                                                                                                  <T>or of a concrete type that implements ICollection
        ///                                                                                                                                                                                      <T>and has a parameterless constructor."
        /// </summary>
        internal static string PocoEntityWrapper_UnableToMaterializeArbitaryNavPropType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PocoEntityWrapper_UnableToMaterializeArbitaryNavPropType, p0, p1);
        }

        /// <summary>
        ///     A string like "General query error"
        /// </summary>
        internal static string GeneralQueryError
        {
            get { return EntityRes.GetString(EntityRes.GeneralQueryError); }
        }

        /// <summary>
        ///     A string like "aliased expression"
        /// </summary>
        internal static string CtxAlias
        {
            get { return EntityRes.GetString(EntityRes.CtxAlias); }
        }

        /// <summary>
        ///     A string like "aliased namespace import"
        /// </summary>
        internal static string CtxAliasedNamespaceImport
        {
            get { return EntityRes.GetString(EntityRes.CtxAliasedNamespaceImport); }
        }

        /// <summary>
        ///     A string like "logical AND expression"
        /// </summary>
        internal static string CtxAnd
        {
            get { return EntityRes.GetString(EntityRes.CtxAnd); }
        }

        /// <summary>
        ///     A string like "ANYELEMENT expression"
        /// </summary>
        internal static string CtxAnyElement
        {
            get { return EntityRes.GetString(EntityRes.CtxAnyElement); }
        }

        /// <summary>
        ///     A string like "APPLY clause"
        /// </summary>
        internal static string CtxApplyClause
        {
            get { return EntityRes.GetString(EntityRes.CtxApplyClause); }
        }

        /// <summary>
        ///     A string like "BETWEEN expression"
        /// </summary>
        internal static string CtxBetween
        {
            get { return EntityRes.GetString(EntityRes.CtxBetween); }
        }

        /// <summary>
        ///     A string like "CASE expression"
        /// </summary>
        internal static string CtxCase
        {
            get { return EntityRes.GetString(EntityRes.CtxCase); }
        }

        /// <summary>
        ///     A string like "CASE/ELSE expression"
        /// </summary>
        internal static string CtxCaseElse
        {
            get { return EntityRes.GetString(EntityRes.CtxCaseElse); }
        }

        /// <summary>
        ///     A string like "CASE/WHEN/THEN expression"
        /// </summary>
        internal static string CtxCaseWhenThen
        {
            get { return EntityRes.GetString(EntityRes.CtxCaseWhenThen); }
        }

        /// <summary>
        ///     A string like "CAST expression"
        /// </summary>
        internal static string CtxCast
        {
            get { return EntityRes.GetString(EntityRes.CtxCast); }
        }

        /// <summary>
        ///     A string like "collated ORDER BY clause item"
        /// </summary>
        internal static string CtxCollatedOrderByClauseItem
        {
            get { return EntityRes.GetString(EntityRes.CtxCollatedOrderByClauseItem); }
        }

        /// <summary>
        ///     A string like "collection type definition"
        /// </summary>
        internal static string CtxCollectionTypeDefinition
        {
            get { return EntityRes.GetString(EntityRes.CtxCollectionTypeDefinition); }
        }

        /// <summary>
        ///     A string like "command expression"
        /// </summary>
        internal static string CtxCommandExpression
        {
            get { return EntityRes.GetString(EntityRes.CtxCommandExpression); }
        }

        /// <summary>
        ///     A string like "CREATEREF expression"
        /// </summary>
        internal static string CtxCreateRef
        {
            get { return EntityRes.GetString(EntityRes.CtxCreateRef); }
        }

        /// <summary>
        ///     A string like "DEREF expression"
        /// </summary>
        internal static string CtxDeref
        {
            get { return EntityRes.GetString(EntityRes.CtxDeref); }
        }

        /// <summary>
        ///     A string like "division operation"
        /// </summary>
        internal static string CtxDivide
        {
            get { return EntityRes.GetString(EntityRes.CtxDivide); }
        }

        /// <summary>
        ///     A string like "ELEMENT expression"
        /// </summary>
        internal static string CtxElement
        {
            get { return EntityRes.GetString(EntityRes.CtxElement); }
        }

        /// <summary>
        ///     A string like "equals expression"
        /// </summary>
        internal static string CtxEquals
        {
            get { return EntityRes.GetString(EntityRes.CtxEquals); }
        }

        /// <summary>
        ///     A string like "escaped identifier"
        /// </summary>
        internal static string CtxEscapedIdentifier
        {
            get { return EntityRes.GetString(EntityRes.CtxEscapedIdentifier); }
        }

        /// <summary>
        ///     A string like "EXCEPT expression"
        /// </summary>
        internal static string CtxExcept
        {
            get { return EntityRes.GetString(EntityRes.CtxExcept); }
        }

        /// <summary>
        ///     A string like "EXISTS expression"
        /// </summary>
        internal static string CtxExists
        {
            get { return EntityRes.GetString(EntityRes.CtxExists); }
        }

        /// <summary>
        ///     A string like "expression list"
        /// </summary>
        internal static string CtxExpressionList
        {
            get { return EntityRes.GetString(EntityRes.CtxExpressionList); }
        }

        /// <summary>
        ///     A string like "FLATTEN expression"
        /// </summary>
        internal static string CtxFlatten
        {
            get { return EntityRes.GetString(EntityRes.CtxFlatten); }
        }

        /// <summary>
        ///     A string like "FROM/APPLY clause"
        /// </summary>
        internal static string CtxFromApplyClause
        {
            get { return EntityRes.GetString(EntityRes.CtxFromApplyClause); }
        }

        /// <summary>
        ///     A string like "FROM clause"
        /// </summary>
        internal static string CtxFromClause
        {
            get { return EntityRes.GetString(EntityRes.CtxFromClause); }
        }

        /// <summary>
        ///     A string like "FROM clause item"
        /// </summary>
        internal static string CtxFromClauseItem
        {
            get { return EntityRes.GetString(EntityRes.CtxFromClauseItem); }
        }

        /// <summary>
        ///     A string like "FROM clause list"
        /// </summary>
        internal static string CtxFromClauseList
        {
            get { return EntityRes.GetString(EntityRes.CtxFromClauseList); }
        }

        /// <summary>
        ///     A string like "FROM/JOIN clause"
        /// </summary>
        internal static string CtxFromJoinClause
        {
            get { return EntityRes.GetString(EntityRes.CtxFromJoinClause); }
        }

        /// <summary>
        ///     A string like "function '{0}()'"
        /// </summary>
        internal static string CtxFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.CtxFunction, p0);
        }

        /// <summary>
        ///     A string like "function definition"
        /// </summary>
        internal static string CtxFunctionDefinition
        {
            get { return EntityRes.GetString(EntityRes.CtxFunctionDefinition); }
        }

        /// <summary>
        ///     A string like "greater than expression"
        /// </summary>
        internal static string CtxGreaterThan
        {
            get { return EntityRes.GetString(EntityRes.CtxGreaterThan); }
        }

        /// <summary>
        ///     A string like "greater than or equals expression"
        /// </summary>
        internal static string CtxGreaterThanEqual
        {
            get { return EntityRes.GetString(EntityRes.CtxGreaterThanEqual); }
        }

        /// <summary>
        ///     A string like "GROUP BY clause"
        /// </summary>
        internal static string CtxGroupByClause
        {
            get { return EntityRes.GetString(EntityRes.CtxGroupByClause); }
        }

        /// <summary>
        ///     A string like "GROUPPARTITION expression"
        /// </summary>
        internal static string CtxGroupPartition
        {
            get { return EntityRes.GetString(EntityRes.CtxGroupPartition); }
        }

        /// <summary>
        ///     A string like "HAVING predicate"
        /// </summary>
        internal static string CtxHavingClause
        {
            get { return EntityRes.GetString(EntityRes.CtxHavingClause); }
        }

        /// <summary>
        ///     A string like "identifier"
        /// </summary>
        internal static string CtxIdentifier
        {
            get { return EntityRes.GetString(EntityRes.CtxIdentifier); }
        }

        /// <summary>
        ///     A string like "IN set expression"
        /// </summary>
        internal static string CtxIn
        {
            get { return EntityRes.GetString(EntityRes.CtxIn); }
        }

        /// <summary>
        ///     A string like "INTERSECT expression"
        /// </summary>
        internal static string CtxIntersect
        {
            get { return EntityRes.GetString(EntityRes.CtxIntersect); }
        }

        /// <summary>
        ///     A string like "IS NOT NULL expression"
        /// </summary>
        internal static string CtxIsNotNull
        {
            get { return EntityRes.GetString(EntityRes.CtxIsNotNull); }
        }

        /// <summary>
        ///     A string like "IS NOT OF expression"
        /// </summary>
        internal static string CtxIsNotOf
        {
            get { return EntityRes.GetString(EntityRes.CtxIsNotOf); }
        }

        /// <summary>
        ///     A string like "IS NULL expression"
        /// </summary>
        internal static string CtxIsNull
        {
            get { return EntityRes.GetString(EntityRes.CtxIsNull); }
        }

        /// <summary>
        ///     A string like "IS OF expression"
        /// </summary>
        internal static string CtxIsOf
        {
            get { return EntityRes.GetString(EntityRes.CtxIsOf); }
        }

        /// <summary>
        ///     A string like "JOIN clause"
        /// </summary>
        internal static string CtxJoinClause
        {
            get { return EntityRes.GetString(EntityRes.CtxJoinClause); }
        }

        /// <summary>
        ///     A string like "JOIN/ON clause"
        /// </summary>
        internal static string CtxJoinOnClause
        {
            get { return EntityRes.GetString(EntityRes.CtxJoinOnClause); }
        }

        /// <summary>
        ///     A string like "KEY expression"
        /// </summary>
        internal static string CtxKey
        {
            get { return EntityRes.GetString(EntityRes.CtxKey); }
        }

        /// <summary>
        ///     A string like "less than expression"
        /// </summary>
        internal static string CtxLessThan
        {
            get { return EntityRes.GetString(EntityRes.CtxLessThan); }
        }

        /// <summary>
        ///     A string like "less than or equals expression"
        /// </summary>
        internal static string CtxLessThanEqual
        {
            get { return EntityRes.GetString(EntityRes.CtxLessThanEqual); }
        }

        /// <summary>
        ///     A string like "LIKE expression"
        /// </summary>
        internal static string CtxLike
        {
            get { return EntityRes.GetString(EntityRes.CtxLike); }
        }

        /// <summary>
        ///     A string like "ORDER BY/LIMIT sub-clause"
        /// </summary>
        internal static string CtxLimitSubClause
        {
            get { return EntityRes.GetString(EntityRes.CtxLimitSubClause); }
        }

        /// <summary>
        ///     A string like "constant literal"
        /// </summary>
        internal static string CtxLiteral
        {
            get { return EntityRes.GetString(EntityRes.CtxLiteral); }
        }

        /// <summary>
        ///     A string like "member access expression"
        /// </summary>
        internal static string CtxMemberAccess
        {
            get { return EntityRes.GetString(EntityRes.CtxMemberAccess); }
        }

        /// <summary>
        ///     A string like "function, method or type constructor"
        /// </summary>
        internal static string CtxMethod
        {
            get { return EntityRes.GetString(EntityRes.CtxMethod); }
        }

        /// <summary>
        ///     A string like "subtraction operation"
        /// </summary>
        internal static string CtxMinus
        {
            get { return EntityRes.GetString(EntityRes.CtxMinus); }
        }

        /// <summary>
        ///     A string like "modulus operation"
        /// </summary>
        internal static string CtxModulus
        {
            get { return EntityRes.GetString(EntityRes.CtxModulus); }
        }

        /// <summary>
        ///     A string like "multiplication operation"
        /// </summary>
        internal static string CtxMultiply
        {
            get { return EntityRes.GetString(EntityRes.CtxMultiply); }
        }

        /// <summary>
        ///     A string like "MULTISET constructor"
        /// </summary>
        internal static string CtxMultisetCtor
        {
            get { return EntityRes.GetString(EntityRes.CtxMultisetCtor); }
        }

        /// <summary>
        ///     A string like "namespace import"
        /// </summary>
        internal static string CtxNamespaceImport
        {
            get { return EntityRes.GetString(EntityRes.CtxNamespaceImport); }
        }

        /// <summary>
        ///     A string like "namespace import list"
        /// </summary>
        internal static string CtxNamespaceImportList
        {
            get { return EntityRes.GetString(EntityRes.CtxNamespaceImportList); }
        }

        /// <summary>
        ///     A string like "NAVIGATE expression"
        /// </summary>
        internal static string CtxNavigate
        {
            get { return EntityRes.GetString(EntityRes.CtxNavigate); }
        }

        /// <summary>
        ///     A string like "logical NOT expression"
        /// </summary>
        internal static string CtxNot
        {
            get { return EntityRes.GetString(EntityRes.CtxNot); }
        }

        /// <summary>
        ///     A string like "NOT BETWEEN expression"
        /// </summary>
        internal static string CtxNotBetween
        {
            get { return EntityRes.GetString(EntityRes.CtxNotBetween); }
        }

        /// <summary>
        ///     A string like "not equals expression"
        /// </summary>
        internal static string CtxNotEqual
        {
            get { return EntityRes.GetString(EntityRes.CtxNotEqual); }
        }

        /// <summary>
        ///     A string like "NOT IN set expression"
        /// </summary>
        internal static string CtxNotIn
        {
            get { return EntityRes.GetString(EntityRes.CtxNotIn); }
        }

        /// <summary>
        ///     A string like "NOT LIKE expression"
        /// </summary>
        internal static string CtxNotLike
        {
            get { return EntityRes.GetString(EntityRes.CtxNotLike); }
        }

        /// <summary>
        ///     A string like "NULL literal"
        /// </summary>
        internal static string CtxNullLiteral
        {
            get { return EntityRes.GetString(EntityRes.CtxNullLiteral); }
        }

        /// <summary>
        ///     A string like "OFTYPE expression"
        /// </summary>
        internal static string CtxOfType
        {
            get { return EntityRes.GetString(EntityRes.CtxOfType); }
        }

        /// <summary>
        ///     A string like "OFTYPE ONLY expression"
        /// </summary>
        internal static string CtxOfTypeOnly
        {
            get { return EntityRes.GetString(EntityRes.CtxOfTypeOnly); }
        }

        /// <summary>
        ///     A string like "logical OR expression"
        /// </summary>
        internal static string CtxOr
        {
            get { return EntityRes.GetString(EntityRes.CtxOr); }
        }

        /// <summary>
        ///     A string like "ORDER BY clause"
        /// </summary>
        internal static string CtxOrderByClause
        {
            get { return EntityRes.GetString(EntityRes.CtxOrderByClause); }
        }

        /// <summary>
        ///     A string like "ORDER BY clause item"
        /// </summary>
        internal static string CtxOrderByClauseItem
        {
            get { return EntityRes.GetString(EntityRes.CtxOrderByClauseItem); }
        }

        /// <summary>
        ///     A string like "OVERLAPS expression"
        /// </summary>
        internal static string CtxOverlaps
        {
            get { return EntityRes.GetString(EntityRes.CtxOverlaps); }
        }

        /// <summary>
        ///     A string like "parenthesized expression"
        /// </summary>
        internal static string CtxParen
        {
            get { return EntityRes.GetString(EntityRes.CtxParen); }
        }

        /// <summary>
        ///     A string like "addition operation"
        /// </summary>
        internal static string CtxPlus
        {
            get { return EntityRes.GetString(EntityRes.CtxPlus); }
        }

        /// <summary>
        ///     A string like "type name with type specification arguments"
        /// </summary>
        internal static string CtxTypeNameWithTypeSpec
        {
            get { return EntityRes.GetString(EntityRes.CtxTypeNameWithTypeSpec); }
        }

        /// <summary>
        ///     A string like "query expression"
        /// </summary>
        internal static string CtxQueryExpression
        {
            get { return EntityRes.GetString(EntityRes.CtxQueryExpression); }
        }

        /// <summary>
        ///     A string like "query statement"
        /// </summary>
        internal static string CtxQueryStatement
        {
            get { return EntityRes.GetString(EntityRes.CtxQueryStatement); }
        }

        /// <summary>
        ///     A string like "REF expression"
        /// </summary>
        internal static string CtxRef
        {
            get { return EntityRes.GetString(EntityRes.CtxRef); }
        }

        /// <summary>
        ///     A string like "reference type definition"
        /// </summary>
        internal static string CtxRefTypeDefinition
        {
            get { return EntityRes.GetString(EntityRes.CtxRefTypeDefinition); }
        }

        /// <summary>
        ///     A string like "RELATIONSHIP expression"
        /// </summary>
        internal static string CtxRelationship
        {
            get { return EntityRes.GetString(EntityRes.CtxRelationship); }
        }

        /// <summary>
        ///     A string like "RELATIONSHIP expression list"
        /// </summary>
        internal static string CtxRelationshipList
        {
            get { return EntityRes.GetString(EntityRes.CtxRelationshipList); }
        }

        /// <summary>
        ///     A string like "ROW constructor"
        /// </summary>
        internal static string CtxRowCtor
        {
            get { return EntityRes.GetString(EntityRes.CtxRowCtor); }
        }

        /// <summary>
        ///     A string like "row type definition"
        /// </summary>
        internal static string CtxRowTypeDefinition
        {
            get { return EntityRes.GetString(EntityRes.CtxRowTypeDefinition); }
        }

        /// <summary>
        ///     A string like "SELECT clause"
        /// </summary>
        internal static string CtxSelectRowClause
        {
            get { return EntityRes.GetString(EntityRes.CtxSelectRowClause); }
        }

        /// <summary>
        ///     A string like "SELECT VALUE clause"
        /// </summary>
        internal static string CtxSelectValueClause
        {
            get { return EntityRes.GetString(EntityRes.CtxSelectValueClause); }
        }

        /// <summary>
        ///     A string like "SET expression"
        /// </summary>
        internal static string CtxSet
        {
            get { return EntityRes.GetString(EntityRes.CtxSet); }
        }

        /// <summary>
        ///     A string like "simple identifier"
        /// </summary>
        internal static string CtxSimpleIdentifier
        {
            get { return EntityRes.GetString(EntityRes.CtxSimpleIdentifier); }
        }

        /// <summary>
        ///     A string like "ORDER BY/SKIP sub-clause"
        /// </summary>
        internal static string CtxSkipSubClause
        {
            get { return EntityRes.GetString(EntityRes.CtxSkipSubClause); }
        }

        /// <summary>
        ///     A string like "TOP sub-clause"
        /// </summary>
        internal static string CtxTopSubClause
        {
            get { return EntityRes.GetString(EntityRes.CtxTopSubClause); }
        }

        /// <summary>
        ///     A string like "TREAT expression"
        /// </summary>
        internal static string CtxTreat
        {
            get { return EntityRes.GetString(EntityRes.CtxTreat); }
        }

        /// <summary>
        ///     A string like "type '{0}' constructor"
        /// </summary>
        internal static string CtxTypeCtor(object p0)
        {
            return EntityRes.GetString(EntityRes.CtxTypeCtor, p0);
        }

        /// <summary>
        ///     A string like "type name"
        /// </summary>
        internal static string CtxTypeName
        {
            get { return EntityRes.GetString(EntityRes.CtxTypeName); }
        }

        /// <summary>
        ///     A string like "unary minus operation"
        /// </summary>
        internal static string CtxUnaryMinus
        {
            get { return EntityRes.GetString(EntityRes.CtxUnaryMinus); }
        }

        /// <summary>
        ///     A string like "unary plus operation"
        /// </summary>
        internal static string CtxUnaryPlus
        {
            get { return EntityRes.GetString(EntityRes.CtxUnaryPlus); }
        }

        /// <summary>
        ///     A string like "UNION expression"
        /// </summary>
        internal static string CtxUnion
        {
            get { return EntityRes.GetString(EntityRes.CtxUnion); }
        }

        /// <summary>
        ///     A string like "UNION ALL expression"
        /// </summary>
        internal static string CtxUnionAll
        {
            get { return EntityRes.GetString(EntityRes.CtxUnionAll); }
        }

        /// <summary>
        ///     A string like "WHERE predicate"
        /// </summary>
        internal static string CtxWhereClause
        {
            get { return EntityRes.GetString(EntityRes.CtxWhereClause); }
        }

        /// <summary>
        ///     A string like "Cannot convert literal '{0}' to '{1}'. Numeric literal specification is not valid."
        /// </summary>
        internal static string CannotConvertNumericLiteral(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.CannotConvertNumericLiteral, p0, p1);
        }

        /// <summary>
        ///     A string like "The query syntax is not valid."
        /// </summary>
        internal static string GenericSyntaxError
        {
            get { return EntityRes.GetString(EntityRes.GenericSyntaxError); }
        }

        /// <summary>
        ///     A string like "in the current FROM clause"
        /// </summary>
        internal static string InFromClause
        {
            get { return EntityRes.GetString(EntityRes.InFromClause); }
        }

        /// <summary>
        ///     A string like "in GROUP BY clause"
        /// </summary>
        internal static string InGroupClause
        {
            get { return EntityRes.GetString(EntityRes.InGroupClause); }
        }

        /// <summary>
        ///     A string like "as a column name in ROW constructor"
        /// </summary>
        internal static string InRowCtor
        {
            get { return EntityRes.GetString(EntityRes.InRowCtor); }
        }

        /// <summary>
        ///     A string like "in the SELECT projection list"
        /// </summary>
        internal static string InSelectProjectionList
        {
            get { return EntityRes.GetString(EntityRes.InSelectProjectionList); }
        }

        /// <summary>
        ///     A string like "'{0}' is a reserved keyword and cannot be used as an alias, unless it is escaped."
        /// </summary>
        internal static string InvalidAliasName(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidAliasName, p0);
        }

        /// <summary>
        ///     A string like "Escaped identifiers cannot be empty."
        /// </summary>
        internal static string InvalidEmptyIdentifier
        {
            get { return EntityRes.GetString(EntityRes.InvalidEmptyIdentifier); }
        }

        /// <summary>
        ///     A string like "The query text consists only of comments and/or white space."
        /// </summary>
        internal static string InvalidEmptyQuery
        {
            get { return EntityRes.GetString(EntityRes.InvalidEmptyQuery); }
        }

        /// <summary>
        ///     A string like "The query text is empty or consists only of white space."
        /// </summary>
        internal static string InvalidEmptyQueryTextArgument
        {
            get { return EntityRes.GetString(EntityRes.InvalidEmptyQueryTextArgument); }
        }

        /// <summary>
        ///     A string like "The escaped identifier '{0}' is not valid."
        /// </summary>
        internal static string InvalidEscapedIdentifier(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEscapedIdentifier, p0);
        }

        /// <summary>
        ///     A string like "The escaped identifier '{0}' has a mismatch of opening ('[') and closing (']') delimiters."
        /// </summary>
        internal static string InvalidEscapedIdentifierUnbalanced(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEscapedIdentifierUnbalanced, p0);
        }

        /// <summary>
        ///     A string like "The operator symbol is not valid."
        /// </summary>
        internal static string InvalidOperatorSymbol
        {
            get { return EntityRes.GetString(EntityRes.InvalidOperatorSymbol); }
        }

        /// <summary>
        ///     A string like "The punctuation symbol is not valid."
        /// </summary>
        internal static string InvalidPunctuatorSymbol
        {
            get { return EntityRes.GetString(EntityRes.InvalidPunctuatorSymbol); }
        }

        /// <summary>
        ///     A string like "The simple identifier '{0}' is not valid."
        /// </summary>
        internal static string InvalidSimpleIdentifier(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidSimpleIdentifier, p0);
        }

        /// <summary>
        ///     A string like "The simple identifier '{0}' must contain basic Latin characters only. To use UNICODE characters, use an escaped identifier."
        /// </summary>
        internal static string InvalidSimpleIdentifierNonASCII(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidSimpleIdentifierNonASCII, p0);
        }

        /// <summary>
        ///     A string like "collection"
        /// </summary>
        internal static string LocalizedCollection
        {
            get { return EntityRes.GetString(EntityRes.LocalizedCollection); }
        }

        /// <summary>
        ///     A string like "column"
        /// </summary>
        internal static string LocalizedColumn
        {
            get { return EntityRes.GetString(EntityRes.LocalizedColumn); }
        }

        /// <summary>
        ///     A string like "complex"
        /// </summary>
        internal static string LocalizedComplex
        {
            get { return EntityRes.GetString(EntityRes.LocalizedComplex); }
        }

        /// <summary>
        ///     A string like "entity"
        /// </summary>
        internal static string LocalizedEntity
        {
            get { return EntityRes.GetString(EntityRes.LocalizedEntity); }
        }

        /// <summary>
        ///     A string like "entity container"
        /// </summary>
        internal static string LocalizedEntityContainerExpression
        {
            get { return EntityRes.GetString(EntityRes.LocalizedEntityContainerExpression); }
        }

        /// <summary>
        ///     A string like "function"
        /// </summary>
        internal static string LocalizedFunction
        {
            get { return EntityRes.GetString(EntityRes.LocalizedFunction); }
        }

        /// <summary>
        ///     A string like "query inline function"
        /// </summary>
        internal static string LocalizedInlineFunction
        {
            get { return EntityRes.GetString(EntityRes.LocalizedInlineFunction); }
        }

        /// <summary>
        ///     A string like "keyword"
        /// </summary>
        internal static string LocalizedKeyword
        {
            get { return EntityRes.GetString(EntityRes.LocalizedKeyword); }
        }

        /// <summary>
        ///     A string like "left"
        /// </summary>
        internal static string LocalizedLeft
        {
            get { return EntityRes.GetString(EntityRes.LocalizedLeft); }
        }

        /// <summary>
        ///     A string like "line"
        /// </summary>
        internal static string LocalizedLine
        {
            get { return EntityRes.GetString(EntityRes.LocalizedLine); }
        }

        /// <summary>
        ///     A string like "namespace, type or function"
        /// </summary>
        internal static string LocalizedMetadataMemberExpression
        {
            get { return EntityRes.GetString(EntityRes.LocalizedMetadataMemberExpression); }
        }

        /// <summary>
        ///     A string like "namespace"
        /// </summary>
        internal static string LocalizedNamespace
        {
            get { return EntityRes.GetString(EntityRes.LocalizedNamespace); }
        }

        /// <summary>
        ///     A string like "Near"
        /// </summary>
        internal static string LocalizedNear
        {
            get { return EntityRes.GetString(EntityRes.LocalizedNear); }
        }

        /// <summary>
        ///     A string like "primitive"
        /// </summary>
        internal static string LocalizedPrimitive
        {
            get { return EntityRes.GetString(EntityRes.LocalizedPrimitive); }
        }

        /// <summary>
        ///     A string like "reference"
        /// </summary>
        internal static string LocalizedReference
        {
            get { return EntityRes.GetString(EntityRes.LocalizedReference); }
        }

        /// <summary>
        ///     A string like "right"
        /// </summary>
        internal static string LocalizedRight
        {
            get { return EntityRes.GetString(EntityRes.LocalizedRight); }
        }

        /// <summary>
        ///     A string like "row"
        /// </summary>
        internal static string LocalizedRow
        {
            get { return EntityRes.GetString(EntityRes.LocalizedRow); }
        }

        /// <summary>
        ///     A string like "term"
        /// </summary>
        internal static string LocalizedTerm
        {
            get { return EntityRes.GetString(EntityRes.LocalizedTerm); }
        }

        /// <summary>
        ///     A string like "type"
        /// </summary>
        internal static string LocalizedType
        {
            get { return EntityRes.GetString(EntityRes.LocalizedType); }
        }

        /// <summary>
        ///     A string like "enum member"
        /// </summary>
        internal static string LocalizedEnumMember
        {
            get { return EntityRes.GetString(EntityRes.LocalizedEnumMember); }
        }

        /// <summary>
        ///     A string like "value expression"
        /// </summary>
        internal static string LocalizedValueExpression
        {
            get { return EntityRes.GetString(EntityRes.LocalizedValueExpression); }
        }

        /// <summary>
        ///     A string like "The alias '{0}' was already used."
        /// </summary>
        internal static string AliasNameAlreadyUsed(object p0)
        {
            return EntityRes.GetString(EntityRes.AliasNameAlreadyUsed, p0);
        }

        /// <summary>
        ///     A string like "The function call cannot be resolved, because one or more passed arguments match more than one function overload."
        /// </summary>
        internal static string AmbiguousFunctionArguments
        {
            get { return EntityRes.GetString(EntityRes.AmbiguousFunctionArguments); }
        }

        /// <summary>
        ///     A string like "The name '{0}' is ambiguous. '{0}' is defined in both the '{1}' namespace and the '{2}' namespace. To disambiguate, either use a fully qualified name or define a namespace alias."
        /// </summary>
        internal static string AmbiguousMetadataMemberName(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.AmbiguousMetadataMemberName, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The argument types '{0}' and '{1}' are incompatible for this operation."
        /// </summary>
        internal static string ArgumentTypesAreIncompatible(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ArgumentTypesAreIncompatible, p0, p1);
        }

        /// <summary>
        ///     A string like "The upper and lower limits of the BETWEEN expression cannot be un-typed nulls."
        /// </summary>
        internal static string BetweenLimitsCannotBeUntypedNulls
        {
            get { return EntityRes.GetString(EntityRes.BetweenLimitsCannotBeUntypedNulls); }
        }

        /// <summary>
        ///     A string like "The BETWEEN lower limit type '{0}' is not compatible with the upper limit type '{1}'."
        /// </summary>
        internal static string BetweenLimitsTypesAreNotCompatible(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.BetweenLimitsTypesAreNotCompatible, p0, p1);
        }

        /// <summary>
        ///     A string like "The BETWEEN lower limit type '{0}' is not order-comparable with the upper limit type '{1}'."
        /// </summary>
        internal static string BetweenLimitsTypesAreNotOrderComparable(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.BetweenLimitsTypesAreNotOrderComparable, p0, p1);
        }

        /// <summary>
        ///     A string like "The BETWEEN value type '{0}' is not order-comparable with the limits common type '{1}'."
        /// </summary>
        internal static string BetweenValueIsNotOrderComparable(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.BetweenValueIsNotOrderComparable, p0, p1);
        }

        /// <summary>
        ///     A string like "Cannot create an empty multiset."
        /// </summary>
        internal static string CannotCreateEmptyMultiset
        {
            get { return EntityRes.GetString(EntityRes.CannotCreateEmptyMultiset); }
        }

        /// <summary>
        ///     A string like "A multiset of un-typed NULLs is not valid."
        /// </summary>
        internal static string CannotCreateMultisetofNulls
        {
            get { return EntityRes.GetString(EntityRes.CannotCreateMultisetofNulls); }
        }

        /// <summary>
        ///     A string like "'{0}' cannot be instantiated because it is defined as an abstract type."
        /// </summary>
        internal static string CannotInstantiateAbstractType(object p0)
        {
            return EntityRes.GetString(EntityRes.CannotInstantiateAbstractType, p0);
        }

        /// <summary>
        ///     A string like "'{0}' cannot be resolved into a valid type or function."
        /// </summary>
        internal static string CannotResolveNameToTypeOrFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.CannotResolveNameToTypeOrFunction, p0);
        }

        /// <summary>
        ///     A string like "There is no underlying support for the '+' operation on strings in the current provider."
        /// </summary>
        internal static string ConcatBuiltinNotSupported
        {
            get { return EntityRes.GetString(EntityRes.ConcatBuiltinNotSupported); }
        }

        /// <summary>
        ///     A string like "'{0}' could not be resolved in the current scope or context. Make sure that all referenced variables are in scope, that required schemas are loaded, and that namespaces are referenced correctly."
        /// </summary>
        internal static string CouldNotResolveIdentifier(object p0)
        {
            return EntityRes.GetString(EntityRes.CouldNotResolveIdentifier, p0);
        }

        /// <summary>
        ///     A string like "The CREATEREF type '{0}' is not a sub-type or super-type of the EntitySet EntityType '{1}'."
        /// </summary>
        internal static string CreateRefTypeIdentifierMustBeASubOrSuperType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.CreateRefTypeIdentifierMustBeASubOrSuperType, p0, p1);
        }

        /// <summary>
        ///     A string like "The CREATEREF type must specify an EntityType. The type specification '{0}' represents '{1}'."
        /// </summary>
        internal static string CreateRefTypeIdentifierMustSpecifyAnEntityType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.CreateRefTypeIdentifierMustSpecifyAnEntityType, p0, p1);
        }

        /// <summary>
        ///     A string like "The DEREF argument must be a reference type. The passed argument is a '{0}' type."
        /// </summary>
        internal static string DeRefArgIsNotOfRefType(object p0)
        {
            return EntityRes.GetString(EntityRes.DeRefArgIsNotOfRefType, p0);
        }

        /// <summary>
        ///     A string like "The inline function '{0}' with the same parameters already exists. Make sure that function overloads are not ambiguous."
        /// </summary>
        internal static string DuplicatedInlineFunctionOverload(object p0)
        {
            return EntityRes.GetString(EntityRes.DuplicatedInlineFunctionOverload, p0);
        }

        /// <summary>
        ///     A string like "The ELEMENT operator is not supported in this version of Entity Framework. It is reserved for future use."
        /// </summary>
        internal static string ElementOperatorIsNotSupported
        {
            get { return EntityRes.GetString(EntityRes.ElementOperatorIsNotSupported); }
        }

        /// <summary>
        ///     A string like "The entity set or function import '{0}' is not defined in the entity container '{1}'."
        /// </summary>
        internal static string MemberDoesNotBelongToEntityContainer(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MemberDoesNotBelongToEntityContainer, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified expression cannot be NULL."
        /// </summary>
        internal static string ExpressionCannotBeNull
        {
            get { return EntityRes.GetString(EntityRes.ExpressionCannotBeNull); }
        }

        /// <summary>
        ///     A string like "The OFTYPE collection element type must refer to an EntityType. The passed type is {0} '{1}'."
        /// </summary>
        internal static string OfTypeExpressionElementTypeMustBeEntityType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.OfTypeExpressionElementTypeMustBeEntityType, p0, p1);
        }

        /// <summary>
        ///     A string like "The OFTYPE collection element type must refer to a nominal type. The passed type is {0} '{1}'."
        /// </summary>
        internal static string OfTypeExpressionElementTypeMustBeNominalType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.OfTypeExpressionElementTypeMustBeNominalType, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified expression must be of CollectionType."
        /// </summary>
        internal static string ExpressionMustBeCollection
        {
            get { return EntityRes.GetString(EntityRes.ExpressionMustBeCollection); }
        }

        /// <summary>
        ///     A string like "The specified expression must be of numeric type."
        /// </summary>
        internal static string ExpressionMustBeNumericType
        {
            get { return EntityRes.GetString(EntityRes.ExpressionMustBeNumericType); }
        }

        /// <summary>
        ///     A string like "The specified expression must be of Boolean type."
        /// </summary>
        internal static string ExpressionTypeMustBeBoolean
        {
            get { return EntityRes.GetString(EntityRes.ExpressionTypeMustBeBoolean); }
        }

        /// <summary>
        ///     A string like "The specified expression type must be equal-comparable."
        /// </summary>
        internal static string ExpressionTypeMustBeEqualComparable
        {
            get { return EntityRes.GetString(EntityRes.ExpressionTypeMustBeEqualComparable); }
        }

        /// <summary>
        ///     A string like "{0} must refer to an EntityType. The passed type is {1} '{2}'."
        /// </summary>
        internal static string ExpressionTypeMustBeEntityType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ExpressionTypeMustBeEntityType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "{0} must refer to a nominal type. The passed type is {1} '{2}'."
        /// </summary>
        internal static string ExpressionTypeMustBeNominalType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ExpressionTypeMustBeNominalType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The specified expression cannot be of CollectionType."
        /// </summary>
        internal static string ExpressionTypeMustNotBeCollection
        {
            get { return EntityRes.GetString(EntityRes.ExpressionTypeMustNotBeCollection); }
        }

        /// <summary>
        ///     A string like "The expression in the CREATEREF operator is not a valid EntitySet."
        /// </summary>
        internal static string ExprIsNotValidEntitySetForCreateRef
        {
            get { return EntityRes.GetString(EntityRes.ExprIsNotValidEntitySetForCreateRef); }
        }

        /// <summary>
        ///     A string like "Could not resolve the aggregate function '{0}' in this context."
        /// </summary>
        internal static string FailedToResolveAggregateFunction(object p0)
        {
            return EntityRes.GetString(EntityRes.FailedToResolveAggregateFunction, p0);
        }

        /// <summary>
        ///     A string like "A '{0}' exception occurred while processing the query. See the inner exception."
        /// </summary>
        internal static string GeneralExceptionAsQueryInnerException(object p0)
        {
            return EntityRes.GetString(EntityRes.GeneralExceptionAsQueryInnerException, p0);
        }

        /// <summary>
        ///     A string like "The GROUP BY clause key expression type must be equal-comparable."
        /// </summary>
        internal static string GroupingKeysMustBeEqualComparable
        {
            get { return EntityRes.GetString(EntityRes.GroupingKeysMustBeEqualComparable); }
        }

        /// <summary>
        ///     A string like "The GROUPPARTITION operator is allowed only in the context of a query expression."
        /// </summary>
        internal static string GroupPartitionOutOfContext
        {
            get { return EntityRes.GetString(EntityRes.GroupPartitionOutOfContext); }
        }

        /// <summary>
        ///     A string like "The HAVING clause must be preceded by a GROUP BY clause."
        /// </summary>
        internal static string HavingRequiresGroupClause
        {
            get { return EntityRes.GetString(EntityRes.HavingRequiresGroupClause); }
        }

        /// <summary>
        ///     A string like "The CREATEREF key expression type is not compatible with the EntityKey element type."
        /// </summary>
        internal static string ImcompatibleCreateRefKeyElementType
        {
            get { return EntityRes.GetString(EntityRes.ImcompatibleCreateRefKeyElementType); }
        }

        /// <summary>
        ///     A string like "The CREATEREF key expression is not compatible with the EntityKey structure."
        /// </summary>
        internal static string ImcompatibleCreateRefKeyType
        {
            get { return EntityRes.GetString(EntityRes.ImcompatibleCreateRefKeyType); }
        }

        /// <summary>
        ///     A string like "The INNER JOIN expression must have an ON predicate."
        /// </summary>
        internal static string InnerJoinMustHaveOnPredicate
        {
            get { return EntityRes.GetString(EntityRes.InnerJoinMustHaveOnPredicate); }
        }

        /// <summary>
        ///     A string like "The type '{0}' is not supported in the UNION expression."
        /// </summary>
        internal static string InvalidAssociationTypeForUnion(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidAssociationTypeForUnion, p0);
        }

        /// <summary>
        ///     A string like "The THEN/ELSE expression types are not compatible."
        /// </summary>
        internal static string InvalidCaseResultTypes
        {
            get { return EntityRes.GetString(EntityRes.InvalidCaseResultTypes); }
        }

        /// <summary>
        ///     A string like "The CASE/WHEN/THEN expression is not valid, because all resulting expressions are un-typed."
        /// </summary>
        internal static string InvalidCaseWhenThenNullType
        {
            get { return EntityRes.GetString(EntityRes.InvalidCaseWhenThenNullType); }
        }

        /// <summary>
        ///     A string like "The CAST expression is not valid. There is no valid conversion from type '{0}' to type '{1}'."
        /// </summary>
        internal static string InvalidCast(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidCast, p0, p1);
        }

        /// <summary>
        ///     A string like "The CAST argument expression must be of a scalar type."
        /// </summary>
        internal static string InvalidCastExpressionType
        {
            get { return EntityRes.GetString(EntityRes.InvalidCastExpressionType); }
        }

        /// <summary>
        ///     A string like "The CAST type argument must be of a scalar type."
        /// </summary>
        internal static string InvalidCastType
        {
            get { return EntityRes.GetString(EntityRes.InvalidCastType); }
        }

        /// <summary>
        ///     A string like "The complex member '{0}' in type '{1}' and the complex member '{2}' in type '{3}' are incompatible because they have a different number of members."
        /// </summary>
        internal static string InvalidComplexType(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.InvalidComplexType, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The CREATEREF key expression must be of row type."
        /// </summary>
        internal static string InvalidCreateRefKeyType
        {
            get { return EntityRes.GetString(EntityRes.InvalidCreateRefKeyType); }
        }

        /// <summary>
        ///     A string like "The argument type '{0}' is not compatible with the property '{1}' of formal type '{2}'."
        /// </summary>
        internal static string InvalidCtorArgumentType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidCtorArgumentType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "It is not valid to use the type constructor on type '{0}'. This type must have one of the following constructors: Entity, ComplexType, or RelationType."
        /// </summary>
        internal static string InvalidCtorUseOnType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidCtorUseOnType, p0);
        }

        /// <summary>
        ///     A string like "The DateTimeOffset literal '{0}' exceeds the range of DateTimeOffset values."
        /// </summary>
        internal static string InvalidDateTimeOffsetLiteral(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidDateTimeOffsetLiteral, p0);
        }

        /// <summary>
        ///     A string like "The day '{0}' is not valid in DateTime literal '{1}'."
        /// </summary>
        internal static string InvalidDay(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidDay, p0, p1);
        }

        /// <summary>
        ///     A string like "The day '{0}' is not valid for the month '{1}' in DateTime literal '{2}'."
        /// </summary>
        internal static string InvalidDayInMonth(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidDayInMonth, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "'{0}' is not a member of type '{1}'. Type '{1}' is the result of dereferencing an expression of type '{2}'."
        /// </summary>
        internal static string InvalidDeRefProperty(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidDeRefProperty, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The DISTINCT/ALL argument is not valid in type constructors."
        /// </summary>
        internal static string InvalidDistinctArgumentInCtor
        {
            get { return EntityRes.GetString(EntityRes.InvalidDistinctArgumentInCtor); }
        }

        /// <summary>
        ///     A string like "The DISTINCT/ALL argument is only valid for group aggregate functions."
        /// </summary>
        internal static string InvalidDistinctArgumentInNonAggFunction
        {
            get { return EntityRes.GetString(EntityRes.InvalidDistinctArgumentInNonAggFunction); }
        }

        /// <summary>
        ///     A string like "The EntityType objects '{0}' and '{1}' are incompatible because they do not share a common super-type."
        /// </summary>
        internal static string InvalidEntityRootTypeArgument(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidEntityRootTypeArgument, p0, p1);
        }

        /// <summary>
        ///     A string like "The entity '{0}' in type '{1}' and the entity '{2}' in type '{3}' are incompatible because they do not share a common super-type."
        /// </summary>
        internal static string InvalidEntityTypeArgument(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.InvalidEntityTypeArgument, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The expression has been classified as a {0}; a {1} was expected."
        /// </summary>
        internal static string InvalidExpressionResolutionClass(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidExpressionResolutionClass, p0, p1);
        }

        /// <summary>
        ///     A string like "The FLATTEN argument must be a collection of collections."
        /// </summary>
        internal static string InvalidFlattenArgument
        {
            get { return EntityRes.GetString(EntityRes.InvalidFlattenArgument); }
        }

        /// <summary>
        ///     A string like "The identifier '{0}' is not valid because it is not contained either in an aggregate function or in the GROUP BY clause."
        /// </summary>
        internal static string InvalidGroupIdentifierReference(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidGroupIdentifierReference, p0);
        }

        /// <summary>
        ///     A string like "Hour '{0}' is not valid in DateTime literal '{1}'."
        /// </summary>
        internal static string InvalidHour(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidHour, p0, p1);
        }

        /// <summary>
        ///     A string like "The 'from' end could not be inferred in the relationship '{0}'."
        /// </summary>
        internal static string InvalidImplicitRelationshipFromEnd(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidImplicitRelationshipFromEnd, p0);
        }

        /// <summary>
        ///     A string like "The 'to' end could not be inferred in the relationship '{0}'."
        /// </summary>
        internal static string InvalidImplicitRelationshipToEnd(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidImplicitRelationshipToEnd, p0);
        }

        /// <summary>
        ///     A string like "The element type '{0}' and the CollectionType '{1}' are not compatible. The IN expression only supports entity, scalar and reference types. "
        /// </summary>
        internal static string InvalidInExprArgs(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidInExprArgs, p0, p1);
        }

        /// <summary>
        ///     A string like "Left correlation is not allowed in the JOIN clause."
        /// </summary>
        internal static string InvalidJoinLeftCorrelation
        {
            get { return EntityRes.GetString(EntityRes.InvalidJoinLeftCorrelation); }
        }

        /// <summary>
        ///     A string like "The KEY argument expression must be of reference type. The passed type is '{0}'."
        /// </summary>
        internal static string InvalidKeyArgument(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidKeyArgument, p0);
        }

        /// <summary>
        ///     A string like "COLLATE can only be used with sort keys of string type. The passed type is '{0}'."
        /// </summary>
        internal static string InvalidKeyTypeForCollation(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidKeyTypeForCollation, p0);
        }

        /// <summary>
        ///     A string like "The {0} literal value '{1}' is not valid."
        /// </summary>
        internal static string InvalidLiteralFormat(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidLiteralFormat, p0, p1);
        }

        /// <summary>
        ///     A string like "A namespace, type, or function name must be a single name or any number of names separated by dots."
        /// </summary>
        internal static string InvalidMetadataMemberName
        {
            get { return EntityRes.GetString(EntityRes.InvalidMetadataMemberName); }
        }

        /// <summary>
        ///     A string like "Minute '{0}' is not valid in DateTime literal '{1}'."
        /// </summary>
        internal static string InvalidMinute(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMinute, p0, p1);
        }

        /// <summary>
        ///     A string like "The WITH RELATIONSHIP clause is only supported when defining read-only view queries."
        /// </summary>
        internal static string InvalidModeForWithRelationshipClause
        {
            get { return EntityRes.GetString(EntityRes.InvalidModeForWithRelationshipClause); }
        }

        /// <summary>
        ///     A string like "Month '{0}' is not valid in DateTime literal '{1}'."
        /// </summary>
        internal static string InvalidMonth(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMonth, p0, p1);
        }

        /// <summary>
        ///     A string like "The namespace alias is not valid."
        /// </summary>
        internal static string InvalidNamespaceAlias
        {
            get { return EntityRes.GetString(EntityRes.InvalidNamespaceAlias); }
        }

        /// <summary>
        ///     A string like "Un-typed NULL arguments are not valid in arithmetic expressions."
        /// </summary>
        internal static string InvalidNullArithmetic
        {
            get { return EntityRes.GetString(EntityRes.InvalidNullArithmetic); }
        }

        /// <summary>
        ///     A string like "Un-typed NULL arguments are not valid in comparison expressions."
        /// </summary>
        internal static string InvalidNullComparison
        {
            get { return EntityRes.GetString(EntityRes.InvalidNullComparison); }
        }

        /// <summary>
        ///     A string like "The non-nullable member '{0}' of type '{1}' cannot be initialized with a NULL value."
        /// </summary>
        internal static string InvalidNullLiteralForNonNullableMember(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidNullLiteralForNonNullableMember, p0, p1);
        }

        /// <summary>
        ///     A string like "The command parameter syntax '@{0}' is not valid."
        /// </summary>
        internal static string InvalidParameterFormat(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidParameterFormat, p0);
        }

        /// <summary>
        ///     A string like "{0} member '{1}' and {2} member '{3}' are incompatible because they do not have a common type."
        /// </summary>
        internal static string InvalidPlaceholderRootTypeArgument(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.InvalidPlaceholderRootTypeArgument, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "{0} member '{1}' in type '{2}' and {3} member '{4}' in type '{5}' are incompatible because they do not have a common type."
        /// </summary>
        internal static string InvalidPlaceholderTypeArgument(object p0, object p1, object p2, object p3, object p4, object p5)
        {
            return EntityRes.GetString(EntityRes.InvalidPlaceholderTypeArgument, p0, p1, p2, p3, p4, p5);
        }

        /// <summary>
        ///     A string like "The ON predicate is not allowed in the CROSS JOIN clause."
        /// </summary>
        internal static string InvalidPredicateForCrossJoin
        {
            get { return EntityRes.GetString(EntityRes.InvalidPredicateForCrossJoin); }
        }

        /// <summary>
        ///     A string like "'{0}' is not a valid member of the '{1}' relationship. "
        /// </summary>
        internal static string InvalidRelationshipMember(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidRelationshipMember, p0, p1);
        }

        /// <summary>
        ///     A string like "'{0}' has been resolved as a {1}; a {2} was expected."
        /// </summary>
        internal static string InvalidMetadataMemberClassResolution(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidMetadataMemberClassResolution, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Complex type '{0}' and complex type '{1}' are incompatible because they have different number of members."
        /// </summary>
        internal static string InvalidRootComplexType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidRootComplexType, p0, p1);
        }

        /// <summary>
        ///     A string like "Row type '{0}' and row type '{1}' are incompatible because they have a different number of columns."
        /// </summary>
        internal static string InvalidRootRowType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidRootRowType, p0, p1);
        }

        /// <summary>
        ///     A string like "Row member '{0}' in type '{1}' and row member '{2}' in type '{3}' are incompatible because they have a different number of columns."
        /// </summary>
        internal static string InvalidRowType(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.InvalidRowType, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "Second '{0}' is not valid in DateTime literal '{1}'."
        /// </summary>
        internal static string InvalidSecond(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidSecond, p0, p1);
        }

        /// <summary>
        ///     A string like "The SELECT VALUE expression cannot be aliased in this context. SELECT VALUE expression can be aliased only when ORDER BY is specified."
        /// </summary>
        internal static string InvalidSelectValueAliasedExpression
        {
            get { return EntityRes.GetString(EntityRes.InvalidSelectValueAliasedExpression); }
        }

        /// <summary>
        ///     A string like "SELECT VALUE can have only one expression in the projection list."
        /// </summary>
        internal static string InvalidSelectValueList
        {
            get { return EntityRes.GetString(EntityRes.InvalidSelectValueList); }
        }

        /// <summary>
        ///     A string like "The WITH RELATIONSHIP clause is only supported for entity type constructors."
        /// </summary>
        internal static string InvalidTypeForWithRelationshipClause
        {
            get { return EntityRes.GetString(EntityRes.InvalidTypeForWithRelationshipClause); }
        }

        /// <summary>
        ///     A string like "The '{0}' argument must be of CollectionType."
        /// </summary>
        internal static string InvalidUnarySetOpArgument(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidUnarySetOpArgument, p0);
        }

        /// <summary>
        ///     A string like "The unsigned type '{0}' cannot be promoted to a signed type."
        /// </summary>
        internal static string InvalidUnsignedTypeForUnaryMinusOperation(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidUnsignedTypeForUnaryMinusOperation, p0);
        }

        /// <summary>
        ///     A string like "Year '{0}' is not valid in DateTime literal '{1}'."
        /// </summary>
        internal static string InvalidYear(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidYear, p0, p1);
        }

        /// <summary>
        ///     A string like "The multiplicity '{1}' is not valid for the relationship end '{0}'."
        /// </summary>
        internal static string InvalidWithRelationshipTargetEndMultiplicity(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidWithRelationshipTargetEndMultiplicity, p0, p1);
        }

        /// <summary>
        ///     A string like "The query is not valid because it contains the association type '{0}', which cannot be projected."
        /// </summary>
        internal static string InvalidQueryResultType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidQueryResultType, p0);
        }

        /// <summary>
        ///     A string like "The IS [NOT] NULL expression must be of entity, reference, enumeration or primitive type."
        /// </summary>
        internal static string IsNullInvalidType
        {
            get { return EntityRes.GetString(EntityRes.IsNullInvalidType); }
        }

        /// <summary>
        ///     A string like "The key expression '{0}' must have at least one reference to the immediate input scope."
        /// </summary>
        internal static string KeyMustBeCorrelated(object p0)
        {
            return EntityRes.GetString(EntityRes.KeyMustBeCorrelated, p0);
        }

        /// <summary>
        ///     A string like "The left argument of the set expression must be of CollectionType."
        /// </summary>
        internal static string LeftSetExpressionArgsMustBeCollection
        {
            get { return EntityRes.GetString(EntityRes.LeftSetExpressionArgsMustBeCollection); }
        }

        /// <summary>
        ///     A string like "LIKE arguments must be of string type."
        /// </summary>
        internal static string LikeArgMustBeStringType
        {
            get { return EntityRes.GetString(EntityRes.LikeArgMustBeStringType); }
        }

        /// <summary>
        ///     A string like "There is no EDM type that corresponds to the literal type '{0}'."
        /// </summary>
        internal static string LiteralTypeNotFoundInMetadata(object p0)
        {
            return EntityRes.GetString(EntityRes.LiteralTypeNotFoundInMetadata, p0);
        }

        /// <summary>
        ///     A string like "The specified literal has a malformed single quote payload."
        /// </summary>
        internal static string MalformedSingleQuotePayload
        {
            get { return EntityRes.GetString(EntityRes.MalformedSingleQuotePayload); }
        }

        /// <summary>
        ///     A string like "The specified literal has a malformed string literal payload."
        /// </summary>
        internal static string MalformedStringLiteralPayload
        {
            get { return EntityRes.GetString(EntityRes.MalformedStringLiteralPayload); }
        }

        /// <summary>
        ///     A string like "Method invocation is not supported."
        /// </summary>
        internal static string MethodInvocationNotSupported
        {
            get { return EntityRes.GetString(EntityRes.MethodInvocationNotSupported); }
        }

        /// <summary>
        ///     A string like "The parameter '{0}' was defined more than once in the parameter collection."
        /// </summary>
        internal static string MultipleDefinitionsOfParameter(object p0)
        {
            return EntityRes.GetString(EntityRes.MultipleDefinitionsOfParameter, p0);
        }

        /// <summary>
        ///     A string like "The variable '{0}' was defined more than once in the variable collection."
        /// </summary>
        internal static string MultipleDefinitionsOfVariable(object p0)
        {
            return EntityRes.GetString(EntityRes.MultipleDefinitionsOfVariable, p0);
        }

        /// <summary>
        ///     A string like "Multiset element types are incompatible."
        /// </summary>
        internal static string MultisetElemsAreNotTypeCompatible
        {
            get { return EntityRes.GetString(EntityRes.MultisetElemsAreNotTypeCompatible); }
        }

        /// <summary>
        ///     A string like "The namespace alias '{0}' was used in a previous USING directive."
        /// </summary>
        internal static string NamespaceAliasAlreadyUsed(object p0)
        {
            return EntityRes.GetString(EntityRes.NamespaceAliasAlreadyUsed, p0);
        }

        /// <summary>
        ///     A string like "The namespace '{0}' was already imported."
        /// </summary>
        internal static string NamespaceAlreadyImported(object p0)
        {
            return EntityRes.GetString(EntityRes.NamespaceAlreadyImported, p0);
        }

        /// <summary>
        ///     A string like "The nested aggregate {0} cannot be used inside of the aggregate {1}."
        /// </summary>
        internal static string NestedAggregateCannotBeUsedInAggregate(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NestedAggregateCannotBeUsedInAggregate, p0, p1);
        }

        /// <summary>
        ///     A string like "No overload of aggregate function '{0}.{1}' is compatible with argument types in '{2}'."
        /// </summary>
        internal static string NoAggrFunctionOverloadMatch(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.NoAggrFunctionOverloadMatch, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "No overload of canonical aggregate function '{0}.{1}' is compatible with the argument types in '{2}'. Consult provider-specific function documentation for store functions with similar functionality."
        /// </summary>
        internal static string NoCanonicalAggrFunctionOverloadMatch(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.NoCanonicalAggrFunctionOverloadMatch, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "No overload of canonical function '{0}.{1}' is compatible with the argument types in '{2}'. Consult provider-specific function documentation for potential store functions with similar functionality."
        /// </summary>
        internal static string NoCanonicalFunctionOverloadMatch(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.NoCanonicalFunctionOverloadMatch, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "No overload of function '{0}.{1}' is compatible with the argument types in '{2}'."
        /// </summary>
        internal static string NoFunctionOverloadMatch(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.NoFunctionOverloadMatch, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "'{0}' is not a member of '{1}'. To extract a property of a collection element, use a sub-query to iterate over the collection."
        /// </summary>
        internal static string NotAMemberOfCollection(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NotAMemberOfCollection, p0, p1);
        }

        /// <summary>
        ///     A string like "'{0}' is not a member of type '{1}' in the currently loaded schemas."
        /// </summary>
        internal static string NotAMemberOfType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NotAMemberOfType, p0, p1);
        }

        /// <summary>
        ///     A string like "Type '{0}' is neither a sub-type nor a super-type of '{1}'."
        /// </summary>
        internal static string NotASuperOrSubType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NotASuperOrSubType, p0, p1);
        }

        /// <summary>
        ///     A string like "A NULL literal cannot be promoted to a CollectionType."
        /// </summary>
        internal static string NullLiteralCannotBePromotedToCollectionOfNulls
        {
            get { return EntityRes.GetString(EntityRes.NullLiteralCannotBePromotedToCollectionOfNulls); }
        }

        /// <summary>
        ///     A string like "The type constructor argument '{0}' is missing."
        /// </summary>
        internal static string NumberOfTypeCtorIsLessThenFormalSpec(object p0)
        {
            return EntityRes.GetString(EntityRes.NumberOfTypeCtorIsLessThenFormalSpec, p0);
        }

        /// <summary>
        ///     A string like "The number of arguments passed to the type '{0}' constructor exceeds its formal specification."
        /// </summary>
        internal static string NumberOfTypeCtorIsMoreThenFormalSpec(object p0)
        {
            return EntityRes.GetString(EntityRes.NumberOfTypeCtorIsMoreThenFormalSpec, p0);
        }

        /// <summary>
        ///     A string like "The ORDER BY sort key(s) type must be order-comparable."
        /// </summary>
        internal static string OrderByKeyIsNotOrderComparable
        {
            get { return EntityRes.GetString(EntityRes.OrderByKeyIsNotOrderComparable); }
        }

        /// <summary>
        ///     A string like "The OFTYPE ONLY type argument is not valid because '{0}' is an abstract type."
        /// </summary>
        internal static string OfTypeOnlyTypeArgumentCannotBeAbstract(object p0)
        {
            return EntityRes.GetString(EntityRes.OfTypeOnlyTypeArgumentCannotBeAbstract, p0);
        }

        /// <summary>
        ///     A string like "The command parameter '{0}' of type '{1}' is not supported."
        /// </summary>
        internal static string ParameterTypeNotSupported(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ParameterTypeNotSupported, p0, p1);
        }

        /// <summary>
        ///     A string like "The command parameter '{0}' was not defined."
        /// </summary>
        internal static string ParameterWasNotDefined(object p0)
        {
            return EntityRes.GetString(EntityRes.ParameterWasNotDefined, p0);
        }

        /// <summary>
        ///     A string like "The {0} expression type must be promotable to an Edm.Int64 type. The passed type is '{1}'."
        /// </summary>
        internal static string PlaceholderExpressionMustBeCompatibleWithEdm64(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PlaceholderExpressionMustBeCompatibleWithEdm64, p0, p1);
        }

        /// <summary>
        ///     A string like "The {0} expression must be a command parameter or an integral numeric literal."
        /// </summary>
        internal static string PlaceholderExpressionMustBeConstant(object p0)
        {
            return EntityRes.GetString(EntityRes.PlaceholderExpressionMustBeConstant, p0);
        }

        /// <summary>
        ///     A string like "The {0} expression value must be greater than or equal to zero."
        /// </summary>
        internal static string PlaceholderExpressionMustBeGreaterThanOrEqualToZero(object p0)
        {
            return EntityRes.GetString(EntityRes.PlaceholderExpressionMustBeGreaterThanOrEqualToZero, p0);
        }

        /// <summary>
        ///     A string like "The {0} operand of {1} is not valid because its type '{2}' cannot be compared for equality. Only primitive, enumeration, entity, row, and reference types can be compared for equality."
        /// </summary>
        internal static string PlaceholderSetArgTypeIsNotEqualComparable(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.PlaceholderSetArgTypeIsNotEqualComparable, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The left expression must be of numeric or string type."
        /// </summary>
        internal static string PlusLeftExpressionInvalidType
        {
            get { return EntityRes.GetString(EntityRes.PlusLeftExpressionInvalidType); }
        }

        /// <summary>
        ///     A string like "The right expression must be of numeric or string type."
        /// </summary>
        internal static string PlusRightExpressionInvalidType
        {
            get { return EntityRes.GetString(EntityRes.PlusRightExpressionInvalidType); }
        }

        /// <summary>
        ///     A string like "The precision '{0}' must be greater than the scale '{1}'.  "
        /// </summary>
        internal static string PrecisionMustBeGreaterThanScale(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.PrecisionMustBeGreaterThanScale, p0, p1);
        }

        /// <summary>
        ///     A string like "The REF argument must be of EntityType. The passed type is '{0}'."
        /// </summary>
        internal static string RefArgIsNotOfEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.RefArgIsNotOfEntityType, p0);
        }

        /// <summary>
        ///     A string like "The REF argument must specify an EntityType. The type specification '{0}' represents '{1}'."
        /// </summary>
        internal static string RefTypeIdentifierMustSpecifyAnEntityType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.RefTypeIdentifierMustSpecifyAnEntityType, p0, p1);
        }

        /// <summary>
        ///     A string like "The related end expression must be of reference type."
        /// </summary>
        internal static string RelatedEndExprTypeMustBeReference
        {
            get { return EntityRes.GetString(EntityRes.RelatedEndExprTypeMustBeReference); }
        }

        /// <summary>
        ///     A string like "The related end expression type '{0}' must be promotable to the 'to' end type '{1}'."
        /// </summary>
        internal static string RelatedEndExprTypeMustBePromotoableToToEnd(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.RelatedEndExprTypeMustBePromotoableToToEnd, p0, p1);
        }

        /// <summary>
        ///     A string like "The 'from' end of the relationship is ambiguous in this context."
        /// </summary>
        internal static string RelationshipFromEndIsAmbiguos
        {
            get { return EntityRes.GetString(EntityRes.RelationshipFromEndIsAmbiguos); }
        }

        /// <summary>
        ///     A string like "The specified type '{0}' must be a relationship type."
        /// </summary>
        internal static string RelationshipTypeExpected(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipTypeExpected, p0);
        }

        /// <summary>
        ///     A string like "The 'to' end of the relationship is ambiguous in this context."
        /// </summary>
        internal static string RelationshipToEndIsAmbiguos
        {
            get { return EntityRes.GetString(EntityRes.RelationshipToEndIsAmbiguos); }
        }

        /// <summary>
        ///     A string like "The target end '{0}' must be unique."
        /// </summary>
        internal static string RelationshipTargetMustBeUnique(object p0)
        {
            return EntityRes.GetString(EntityRes.RelationshipTargetMustBeUnique, p0);
        }

        /// <summary>
        ///     A string like "The resulting expression of the query cannot be un-typed NULL."
        /// </summary>
        internal static string ResultingExpressionTypeCannotBeNull
        {
            get { return EntityRes.GetString(EntityRes.ResultingExpressionTypeCannotBeNull); }
        }

        /// <summary>
        ///     A string like "The right argument of the set expression must be of CollectionType."
        /// </summary>
        internal static string RightSetExpressionArgsMustBeCollection
        {
            get { return EntityRes.GetString(EntityRes.RightSetExpressionArgsMustBeCollection); }
        }

        /// <summary>
        ///     A string like "The ROW constructor cannot have un-typed NULL columns."
        /// </summary>
        internal static string RowCtorElementCannotBeNull
        {
            get { return EntityRes.GetString(EntityRes.RowCtorElementCannotBeNull); }
        }

        /// <summary>
        ///     A string like "The projection expression type must be equal-comparable when used with DISTINCT."
        /// </summary>
        internal static string SelectDistinctMustBeEqualComparable
        {
            get { return EntityRes.GetString(EntityRes.SelectDistinctMustBeEqualComparable); }
        }

        /// <summary>
        ///     A string like "The relationship source type '{0}' must be promotable to the 'from' end type '{1}'."
        /// </summary>
        internal static string SourceTypeMustBePromotoableToFromEndRelationType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.SourceTypeMustBePromotoableToFromEndRelationType, p0, p1);
        }

        /// <summary>
        ///     A string like "The TOP and LIMIT sub-clauses cannot be used together in the same query expression."
        /// </summary>
        internal static string TopAndLimitCannotCoexist
        {
            get { return EntityRes.GetString(EntityRes.TopAndLimitCannotCoexist); }
        }

        /// <summary>
        ///     A string like "The TOP and SKIP sub-clauses cannot be used together in the same query expression. Use LIMIT instead of TOP."
        /// </summary>
        internal static string TopAndSkipCannotCoexist
        {
            get { return EntityRes.GetString(EntityRes.TopAndSkipCannotCoexist); }
        }

        /// <summary>
        ///     A string like "'{0}' does not support type specification."
        /// </summary>
        internal static string TypeDoesNotSupportSpec(object p0)
        {
            return EntityRes.GetString(EntityRes.TypeDoesNotSupportSpec, p0);
        }

        /// <summary>
        ///     A string like "'{0}' does not support '{1}' specification."
        /// </summary>
        internal static string TypeDoesNotSupportFacet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.TypeDoesNotSupportFacet, p0, p1);
        }

        /// <summary>
        ///     A string like "The type specification has an incorrect number of arguments. The '{0}' type has {1} parameters."
        /// </summary>
        internal static string TypeArgumentCountMismatch(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.TypeArgumentCountMismatch, p0, p1);
        }

        /// <summary>
        ///     A string like "The type specification argument must be a constant literal."
        /// </summary>
        internal static string TypeArgumentMustBeLiteral
        {
            get { return EntityRes.GetString(EntityRes.TypeArgumentMustBeLiteral); }
        }

        /// <summary>
        ///     A string like "'{0}' is less than the minimum supported value."
        /// </summary>
        internal static string TypeArgumentBelowMin(object p0)
        {
            return EntityRes.GetString(EntityRes.TypeArgumentBelowMin, p0);
        }

        /// <summary>
        ///     A string like "'{0}' is greater than the maximum supported value."
        /// </summary>
        internal static string TypeArgumentExceedsMax(object p0)
        {
            return EntityRes.GetString(EntityRes.TypeArgumentExceedsMax, p0);
        }

        /// <summary>
        ///     A string like "The type argument is not a valid constant literal, or is outside of the expected range."
        /// </summary>
        internal static string TypeArgumentIsNotValid
        {
            get { return EntityRes.GetString(EntityRes.TypeArgumentIsNotValid); }
        }

        /// <summary>
        ///     A string like "{0} member '{1}' and {2} member '{3}' are not compatible for this operation, because they are not the same kind of type."
        /// </summary>
        internal static string TypeKindMismatch(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.TypeKindMismatch, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The expression type must be EntityType, ComplexType, or ReferenceType"
        /// </summary>
        internal static string TypeMustBeInheritableType
        {
            get { return EntityRes.GetString(EntityRes.TypeMustBeInheritableType); }
        }

        /// <summary>
        ///     A string like "The '{0}' type argument must specify an EntityType. The passed type is {1} '{2}'."
        /// </summary>
        internal static string TypeMustBeEntityType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.TypeMustBeEntityType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The '{0}' type argument must specify a nominal type, The passed type is {1} '{2}'."
        /// </summary>
        internal static string TypeMustBeNominalType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.TypeMustBeNominalType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Type '{0}' could not be found. Make sure that the required schemas are loaded and that the namespaces are imported correctly."
        /// </summary>
        internal static string TypeNameNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.TypeNameNotFound, p0);
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The group variable must be present in one of the existing scopes."
        /// </summary>
        internal static string GroupVarNotFoundInScope
        {
            get { return EntityRes.GetString(EntityRes.GroupVarNotFoundInScope); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The argument type for the aggregate function is not valid."
        /// </summary>
        internal static string InvalidArgumentTypeForAggregateFunction
        {
            get { return EntityRes.GetString(EntityRes.InvalidArgumentTypeForAggregateFunction); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The save point is not valid."
        /// </summary>
        internal static string InvalidSavePoint
        {
            get { return EntityRes.GetString(EntityRes.InvalidSavePoint); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The scope index is not valid."
        /// </summary>
        internal static string InvalidScopeIndex
        {
            get { return EntityRes.GetString(EntityRes.InvalidScopeIndex); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The literal type '{0}' is not supported."
        /// </summary>
        internal static string LiteralTypeNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.LiteralTypeNotSupported, p0);
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The parser found an error and cannot continue."
        /// </summary>
        internal static string ParserFatalError
        {
            get { return EntityRes.GetString(EntityRes.ParserFatalError); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The input stream is not valid."
        /// </summary>
        internal static string ParserInputError
        {
            get { return EntityRes.GetString(EntityRes.ParserInputError); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: There was a stack overflow in the query parser."
        /// </summary>
        internal static string StackOverflowInParser
        {
            get { return EntityRes.GetString(EntityRes.StackOverflowInParser); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The abstract syntax tree expression is not a valid command expression type."
        /// </summary>
        internal static string UnknownAstCommandExpression
        {
            get { return EntityRes.GetString(EntityRes.UnknownAstCommandExpression); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The abstract syntax tree expression has an unknown type."
        /// </summary>
        internal static string UnknownAstExpressionType
        {
            get { return EntityRes.GetString(EntityRes.UnknownAstExpressionType); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The specified built-in abstract syntax tree expression type is unknown. "
        /// </summary>
        internal static string UnknownBuiltInAstExpressionType
        {
            get { return EntityRes.GetString(EntityRes.UnknownBuiltInAstExpressionType); }
        }

        /// <summary>
        ///     A string like "INTERNAL ERROR: The expression resolution has an unknown class '{0}'."
        /// </summary>
        internal static string UnknownExpressionResolutionClass(object p0)
        {
            return EntityRes.GetString(EntityRes.UnknownExpressionResolutionClass, p0);
        }

        /// <summary>
        ///     A string like "The expression '{0}' is of an unsupported type. "
        /// </summary>
        internal static string Cqt_General_UnsupportedExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_General_UnsupportedExpression, p0);
        }

        /// <summary>
        ///     A string like "The specified type is not polymorphic: '{0}'. "
        /// </summary>
        internal static string Cqt_General_PolymorphicTypeRequired(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_General_PolymorphicTypeRequired, p0);
        }

        /// <summary>
        ///     A string like "{0} requires an expression argument with a polymorphic result type that is compatible with the type argument."
        /// </summary>
        internal static string Cqt_General_PolymorphicArgRequired(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_General_PolymorphicArgRequired, p0);
        }

        /// <summary>
        ///     A string like "The specified metadata cannot be used because it is not read-only."
        /// </summary>
        internal static string Cqt_General_MetadataNotReadOnly
        {
            get { return EntityRes.GetString(EntityRes.Cqt_General_MetadataNotReadOnly); }
        }

        /// <summary>
        ///     A string like "The current provider does not support any type that is compatible with Edm.Boolean."
        /// </summary>
        internal static string Cqt_General_NoProviderBooleanType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_General_NoProviderBooleanType); }
        }

        /// <summary>
        ///     A string like "The current provider does not support any type that is compatible with Edm.Int32."
        /// </summary>
        internal static string Cqt_General_NoProviderIntegerType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_General_NoProviderIntegerType); }
        }

        /// <summary>
        ///     A string like "The current provider does not support any type that is compatible with Edm.String."
        /// </summary>
        internal static string Cqt_General_NoProviderStringType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_General_NoProviderStringType); }
        }

        /// <summary>
        ///     A string like "The specified member is not associated with the same MetadataWorkspace or data space as the command tree."
        /// </summary>
        internal static string Cqt_Metadata_EdmMemberIncorrectSpace
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_EdmMemberIncorrectSpace); }
        }

        /// <summary>
        ///     A string like "The specified EntitySet is not valid because its EntityContainer property has a value of null."
        /// </summary>
        internal static string Cqt_Metadata_EntitySetEntityContainerNull
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_EntitySetEntityContainerNull); }
        }

        /// <summary>
        ///     A string like "The specified EntitySet is not associated with the same MetadataWorkspace or data model  as the command tree."
        /// </summary>
        internal static string Cqt_Metadata_EntitySetIncorrectSpace
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_EntitySetIncorrectSpace); }
        }

        /// <summary>
        ///     A string like "The specified EntityType is not valid because its KeyMembers property has a value of null."
        /// </summary>
        internal static string Cqt_Metadata_EntityTypeNullKeyMembersInvalid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_EntityTypeNullKeyMembersInvalid); }
        }

        /// <summary>
        ///     A string like "The specified EntityType is not valid because its KeyMembers collection is empty."
        /// </summary>
        internal static string Cqt_Metadata_EntityTypeEmptyKeyMembersInvalid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_EntityTypeEmptyKeyMembersInvalid); }
        }

        /// <summary>
        ///     A string like "The specified function is not valid because its ReturnParameter property has a value of null."
        /// </summary>
        internal static string Cqt_Metadata_FunctionReturnParameterNull
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_FunctionReturnParameterNull); }
        }

        /// <summary>
        ///     A string like "The specified function is not associated with the same MetadataWorkspace or data space as the command tree."
        /// </summary>
        internal static string Cqt_Metadata_FunctionIncorrectSpace
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_FunctionIncorrectSpace); }
        }

        /// <summary>
        ///     A string like "The specified function parameter is not associated with the same MetadataWorkspace or data model as the command tree."
        /// </summary>
        internal static string Cqt_Metadata_FunctionParameterIncorrectSpace
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_FunctionParameterIncorrectSpace); }
        }

        /// <summary>
        ///     A string like "The specified type is not associated with the same MetadataWorkspace or data model as the command tree."
        /// </summary>
        internal static string Cqt_Metadata_TypeUsageIncorrectSpace
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Metadata_TypeUsageIncorrectSpace); }
        }

        /// <summary>
        ///     A string like "The specified command tree is not valid."
        /// </summary>
        internal static string Cqt_Exceptions_InvalidCommandTree
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Exceptions_InvalidCommandTree); }
        }

        /// <summary>
        ///     A string like "An empty list is not a valid value for this argument."
        /// </summary>
        internal static string Cqt_Util_CheckListEmptyInvalid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Util_CheckListEmptyInvalid); }
        }

        /// <summary>
        ///     A string like "The name '{2}' was specified twice, at index {0} and index {1}. Duplicate names are not allowed."
        /// </summary>
        internal static string Cqt_Util_CheckListDuplicateName(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Cqt_Util_CheckListDuplicateName, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The ResultType of the specified expression is not compatible with the required type. The expression ResultType is '{0}' but the required type is '{1}'. "
        /// </summary>
        internal static string Cqt_ExpressionLink_TypeMismatch(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_ExpressionLink_TypeMismatch, p0, p1);
        }

        /// <summary>
        ///     A string like "The expression list has an incorrect number of elements."
        /// </summary>
        internal static string Cqt_ExpressionList_IncorrectElementCount
        {
            get { return EntityRes.GetString(EntityRes.Cqt_ExpressionList_IncorrectElementCount); }
        }

        /// <summary>
        ///     A string like "The EntityContainer '{0}' was not found in the destination MetadataWorkspace. "
        /// </summary>
        internal static string Cqt_Copier_EntityContainerNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Copier_EntityContainerNotFound, p0);
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}.{1}' was not found in the destination MetadataWorkspace. "
        /// </summary>
        internal static string Cqt_Copier_EntitySetNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_Copier_EntitySetNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The function '{0}' was not found in the destination MetadataWorkspace."
        /// </summary>
        internal static string Cqt_Copier_FunctionNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Copier_FunctionNotFound, p0);
        }

        /// <summary>
        ///     A string like "A property named '{0}' is not declared by the type '{1}' from the destination MetadataWorkspace. "
        /// </summary>
        internal static string Cqt_Copier_PropertyNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_Copier_PropertyNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "A navigation property named '{0}' is not declared by the type '{1}' from the destination MetadataWorkspace. "
        /// </summary>
        internal static string Cqt_Copier_NavPropertyNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_Copier_NavPropertyNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "A relationship end named '{0}' is not declared by the relationship type '{1}' from the destination MetadataWorkspace."
        /// </summary>
        internal static string Cqt_Copier_EndNotFound(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_Copier_EndNotFound, p0, p1);
        }

        /// <summary>
        ///     A string like "The destination MetadataWorkspace does not contain the type '{0}'."
        /// </summary>
        internal static string Cqt_Copier_TypeNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Copier_TypeNotFound, p0);
        }

        /// <summary>
        ///     A string like "The DataSpace is not valid."
        /// </summary>
        internal static string Cqt_CommandTree_InvalidDataSpace
        {
            get { return EntityRes.GetString(EntityRes.Cqt_CommandTree_InvalidDataSpace); }
        }

        /// <summary>
        ///     A string like "The specified parameter name is not valid: '{0}'."
        /// </summary>
        internal static string Cqt_CommandTree_InvalidParameterName(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_CommandTree_InvalidParameterName, p0);
        }

        /// <summary>
        ///     A string like "The specified expression contains multiple references to the parameter '{0}' that have different result types."
        /// </summary>
        internal static string Cqt_Validator_InvalidIncompatibleParameterReferences(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Validator_InvalidIncompatibleParameterReferences, p0);
        }

        /// <summary>
        ///     A string like "The specified expression contains {0} metadata from a workspace other than the target workspace."
        /// </summary>
        internal static string Cqt_Validator_InvalidOtherWorkspaceMetadata(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Validator_InvalidOtherWorkspaceMetadata, p0);
        }

        /// <summary>
        ///     A string like "The specified expression contains {0} metadata from a data space other than the target, '{1}'."
        /// </summary>
        internal static string Cqt_Validator_InvalidIncorrectDataSpaceMetadata(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_Validator_InvalidIncorrectDataSpaceMetadata, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified element expressions cannot be contained by the same collection because no common element type can be inferred from their ResultTypes."
        /// </summary>
        internal static string Cqt_Factory_NewCollectionInvalidCommonType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Factory_NewCollectionInvalidCommonType); }
        }

        /// <summary>
        ///     A string like "No property with the name '{0}' is declared by the type '{1}'."
        /// </summary>
        internal static string Cqt_Factory_NoSuchProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_Factory_NoSuchProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "The specified relationship type does not define an end with the specified name"
        /// </summary>
        internal static string Cqt_Factory_NoSuchRelationEnd
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Factory_NoSuchRelationEnd); }
        }

        /// <summary>
        ///     A string like "The specified relationship ends are not defined by the same relationship type."
        /// </summary>
        internal static string Cqt_Factory_IncompatibleRelationEnds
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Factory_IncompatibleRelationEnds); }
        }

        /// <summary>
        ///     A string like "The method result type '{0}' is not supported for this method argument. A method that produces an instance of a DbExpression-derived type or an anonymous type with DbExpression-derived properties is required."
        /// </summary>
        internal static string Cqt_Factory_MethodResultTypeNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Factory_MethodResultTypeNotSupported, p0);
        }

        /// <summary>
        ///     A string like "The specified aggregate function is not valid."
        /// </summary>
        internal static string Cqt_Aggregate_InvalidFunction
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Aggregate_InvalidFunction); }
        }

        /// <summary>
        ///     A string like "DbExpressionBinding requires an input expression with a collection ResultType."
        /// </summary>
        internal static string Cqt_Binding_CollectionRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Binding_CollectionRequired); }
        }

        /// <summary>
        ///     A string like "The specified variable name is not valid. Variable names cannot be empty."
        /// </summary>
        internal static string Cqt_Binding_VariableNameNotValid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Binding_VariableNameNotValid); }
        }

        /// <summary>
        ///     A string like "DbGroupExpressionBinding requires an input expression with a collection ResultType."
        /// </summary>
        internal static string Cqt_GroupBinding_CollectionRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_GroupBinding_CollectionRequired); }
        }

        /// <summary>
        ///     A string like "The specified group variable name is not valid. Group variable names cannot be empty."
        /// </summary>
        internal static string Cqt_GroupBinding_GroupVariableNameNotValid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_GroupBinding_GroupVariableNameNotValid); }
        }

        /// <summary>
        ///     A string like "{0} requires arguments with compatible collection ResultTypes."
        /// </summary>
        internal static string Cqt_Binary_CollectionsRequired(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Binary_CollectionsRequired, p0);
        }

        /// <summary>
        ///     A string like "{0} requires a collection argument."
        /// </summary>
        internal static string Cqt_Unary_CollectionRequired(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Unary_CollectionRequired, p0);
        }

        /// <summary>
        ///     A string like "DbAndExpression requires arguments with a common Boolean type."
        /// </summary>
        internal static string Cqt_And_BooleanArgumentsRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_And_BooleanArgumentsRequired); }
        }

        /// <summary>
        ///     A string like "DbApplyExpression input and apply arguments cannot have the same variable name."
        /// </summary>
        internal static string Cqt_Apply_DuplicateVariableNames
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Apply_DuplicateVariableNames); }
        }

        /// <summary>
        ///     A string like "DbArithmeticExpression arguments must have a numeric common type."
        /// </summary>
        internal static string Cqt_Arithmetic_NumericCommonType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Arithmetic_NumericCommonType); }
        }

        /// <summary>
        ///     A string like "The unsigned type '{0}' cannot be promoted to a signed type."
        /// </summary>
        internal static string Cqt_Arithmetic_InvalidUnsignedTypeForUnaryMinus(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Arithmetic_InvalidUnsignedTypeForUnaryMinus, p0);
        }

        /// <summary>
        ///     A string like "DbCaseExpression requires an equal number of 'When' and 'Then' expressions."
        /// </summary>
        internal static string Cqt_Case_WhensMustEqualThens
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Case_WhensMustEqualThens); }
        }

        /// <summary>
        ///     A string like "A valid ResultType could not be inferred from the ResultTypes of the specified 'Then' expressions."
        /// </summary>
        internal static string Cqt_Case_InvalidResultType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Case_InvalidResultType); }
        }

        /// <summary>
        ///     A string like "The requested cast is not allowed: from type '{0}' to type '{1}'."
        /// </summary>
        internal static string Cqt_Cast_InvalidCast(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_Cast_InvalidCast, p0, p1);
        }

        /// <summary>
        ///     A string like "DbComparisonExpression requires arguments with comparable types."
        /// </summary>
        internal static string Cqt_Comparison_ComparableRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Comparison_ComparableRequired); }
        }

        /// <summary>
        ///     A string like "The specified value is not an instance of a valid constant type."
        /// </summary>
        internal static string Cqt_Constant_InvalidType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Constant_InvalidType); }
        }

        /// <summary>
        ///     A string like "The specified value is not an instance of type '{0}'."
        /// </summary>
        internal static string Cqt_Constant_InvalidValueForType(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Constant_InvalidValueForType, p0);
        }

        /// <summary>
        ///     A string like "Only enumeration or primitive types may be used as constant value types. DbConstantExpression cannot be created using an instance of type '{0}'."
        /// </summary>
        internal static string Cqt_Constant_InvalidConstantType(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Constant_InvalidConstantType, p0);
        }

        /// <summary>
        ///     A string like "The type '{0}' does not match the EDM enumeration type '{1}' or its underlying type '{2}'."
        /// </summary>
        internal static string Cqt_Constant_ClrEnumTypeDoesNotMatchEdmEnumType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Cqt_Constant_ClrEnumTypeDoesNotMatchEdmEnumType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The 'Distinct' operation cannot be applied to the collection ResultType of the specified argument."
        /// </summary>
        internal static string Cqt_Distinct_InvalidCollection
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Distinct_InvalidCollection); }
        }

        /// <summary>
        ///     A string like "DbDerefExpression requires an argument of a reference type."
        /// </summary>
        internal static string Cqt_DeRef_RefRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_DeRef_RefRequired); }
        }

        /// <summary>
        ///     A string like "When unwrapSingleProperty is specified the argument expression must have the following ResultType: a CollectionType with a structured element type that declares exactly one property. "
        /// </summary>
        internal static string Cqt_Element_InvalidArgumentForUnwrapSingleProperty
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Element_InvalidArgumentForUnwrapSingleProperty); }
        }

        /// <summary>
        ///     A string like "Function metadata used in DbFunctionExpression cannot have a void return type."
        /// </summary>
        internal static string Cqt_Function_VoidResultInvalid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Function_VoidResultInvalid); }
        }

        /// <summary>
        ///     A string like "Function metadata used in DbFunctionExpression must allow composition. Non-composable functions or functions that include command text are not allowed in expressions. Such functions can only be executed independently."
        /// </summary>
        internal static string Cqt_Function_NonComposableInExpression
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Function_NonComposableInExpression); }
        }

        /// <summary>
        ///     A string like "Function metadata used in DbFunctionExpression cannot include command text."
        /// </summary>
        internal static string Cqt_Function_CommandTextInExpression
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Function_CommandTextInExpression); }
        }

        /// <summary>
        ///     A string like "No function named 'Edm.{0}' having the specified argument types was found."
        /// </summary>
        internal static string Cqt_Function_CanonicalFunction_NotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Function_CanonicalFunction_NotFound, p0);
        }

        /// <summary>
        ///     A string like "The specified argument result types matched more than one overload of the function 'Edm.{0}'."
        /// </summary>
        internal static string Cqt_Function_CanonicalFunction_AmbiguousMatch(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Function_CanonicalFunction_AmbiguousMatch, p0);
        }

        /// <summary>
        ///     A string like "DbEntityRefExpression requires an argument of an EntityType."
        /// </summary>
        internal static string Cqt_GetEntityRef_EntityRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_GetEntityRef_EntityRequired); }
        }

        /// <summary>
        ///     A string like "DbRefKeyExpression requires an argument of a reference type."
        /// </summary>
        internal static string Cqt_GetRefKey_RefRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_GetRefKey_RefRequired); }
        }

        /// <summary>
        ///     A string like "At least one group key or aggregate is required."
        /// </summary>
        internal static string Cqt_GroupBy_AtLeastOneKeyOrAggregate
        {
            get { return EntityRes.GetString(EntityRes.Cqt_GroupBy_AtLeastOneKeyOrAggregate); }
        }

        /// <summary>
        ///     A string like "The specified group key is not valid because equality comparison cannot be performed on its ResultType: '{0}'."
        /// </summary>
        internal static string Cqt_GroupBy_KeyNotEqualityComparable(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_GroupBy_KeyNotEqualityComparable, p0);
        }

        /// <summary>
        ///     A string like "An aggregate named '{0}' cannot be used because the specified group keys include a key with the same name."
        /// </summary>
        internal static string Cqt_GroupBy_AggregateColumnExistsAsGroupColumn(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_GroupBy_AggregateColumnExistsAsGroupColumn, p0);
        }

        /// <summary>
        ///     A string like "At most one DbGroupAggregate can be specified in the list of aggregates of a DbGroupByExpression."
        /// </summary>
        internal static string Cqt_GroupBy_MoreThanOneGroupAggregate
        {
            get { return EntityRes.GetString(EntityRes.Cqt_GroupBy_MoreThanOneGroupAggregate); }
        }

        /// <summary>
        ///     A string like "DbCrossJoinExpression requires at least two inputs."
        /// </summary>
        internal static string Cqt_CrossJoin_AtLeastTwoInputs
        {
            get { return EntityRes.GetString(EntityRes.Cqt_CrossJoin_AtLeastTwoInputs); }
        }

        /// <summary>
        ///     A string like "The specified DbCrossJoinExpression inputs contain expression bindings with a duplicate variable name, '{2}'. The first occurrence is at index {0}, the second is at index {1}. "
        /// </summary>
        internal static string Cqt_CrossJoin_DuplicateVariableNames(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Cqt_CrossJoin_DuplicateVariableNames, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The argument to DbIsNullExpression cannot have a CollectionType of a ResultType."
        /// </summary>
        internal static string Cqt_IsNull_CollectionNotAllowed
        {
            get { return EntityRes.GetString(EntityRes.Cqt_IsNull_CollectionNotAllowed); }
        }

        /// <summary>
        ///     A string like "The argument to DbIsNullExpression must refer to a primitive, enumeration or reference type."
        /// </summary>
        internal static string Cqt_IsNull_InvalidType
        {
            get { return EntityRes.GetString(EntityRes.Cqt_IsNull_InvalidType); }
        }

        /// <summary>
        ///     A string like "A collection of '{0}' is not a valid argument for {1}."
        /// </summary>
        internal static string Cqt_InvalidTypeForSetOperation(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Cqt_InvalidTypeForSetOperation, p0, p1);
        }

        /// <summary>
        ///     A string like "The left and right arguments of a DbJoinExpression cannot have the same variable name."
        /// </summary>
        internal static string Cqt_Join_DuplicateVariableNames
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Join_DuplicateVariableNames); }
        }

        /// <summary>
        ///     A string like "Limit must be a DbConstantExpression or a DbParameterReferenceExpression."
        /// </summary>
        internal static string Cqt_Limit_ConstantOrParameterRefRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Limit_ConstantOrParameterRefRequired); }
        }

        /// <summary>
        ///     A string like "Limit must have an integer ResultType."
        /// </summary>
        internal static string Cqt_Limit_IntegerRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Limit_IntegerRequired); }
        }

        /// <summary>
        ///     A string like "Limit must have a non-negative value."
        /// </summary>
        internal static string Cqt_Limit_NonNegativeLimitRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Limit_NonNegativeLimitRequired); }
        }

        /// <summary>
        ///     A string like "A CollectionType is required."
        /// </summary>
        internal static string Cqt_NewInstance_CollectionTypeRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_NewInstance_CollectionTypeRequired); }
        }

        /// <summary>
        ///     A string like "A collection, entity or row type is required."
        /// </summary>
        internal static string Cqt_NewInstance_StructuralTypeRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_NewInstance_StructuralTypeRequired); }
        }

        /// <summary>
        ///     A string like "DbNewInstanceExpression cannot create an instance of the memberless type '{0}'."
        /// </summary>
        internal static string Cqt_NewInstance_CannotInstantiateMemberlessType(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_NewInstance_CannotInstantiateMemberlessType, p0);
        }

        /// <summary>
        ///     A string like "DbNewInstanceExpression cannot create an instance of the abstract type '{0}'."
        /// </summary>
        internal static string Cqt_NewInstance_CannotInstantiateAbstractType(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_NewInstance_CannotInstantiateAbstractType, p0);
        }

        /// <summary>
        ///     A string like "The specified related entity is not compatible with this new instance constructor. The constructed instance is not an instance of the EntityType required by the source end of the related entity."
        /// </summary>
        internal static string Cqt_NewInstance_IncompatibleRelatedEntity_SourceTypeNotValid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_NewInstance_IncompatibleRelatedEntity_SourceTypeNotValid); }
        }

        /// <summary>
        ///     A string like "DbNotExpression requires an argument with a Boolean type."
        /// </summary>
        internal static string Cqt_Not_BooleanArgumentRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Not_BooleanArgumentRequired); }
        }

        /// <summary>
        ///     A string like "DbOrExpression requires arguments with a common Boolean type."
        /// </summary>
        internal static string Cqt_Or_BooleanArgumentsRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Or_BooleanArgumentsRequired); }
        }

        /// <summary>
        ///     A string like "An Instance property of type DbExpression is required for an instance property."
        /// </summary>
        internal static string Cqt_Property_InstanceRequiredForInstance
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Property_InstanceRequiredForInstance); }
        }

        /// <summary>
        ///     A string like "DbRefExpression requires an EntityType from the same hierarchy as the EntityType of the referenced EntitySet."
        /// </summary>
        internal static string Cqt_Ref_PolymorphicArgRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Ref_PolymorphicArgRequired); }
        }

        /// <summary>
        ///     A string like "The specified target relationship End is not declared by the same relationship type as the specified source relationship End."
        /// </summary>
        internal static string Cqt_RelatedEntityRef_TargetEndFromDifferentRelationship
        {
            get { return EntityRes.GetString(EntityRes.Cqt_RelatedEntityRef_TargetEndFromDifferentRelationship); }
        }

        /// <summary>
        ///     A string like "A target relationship End with multiplicity of 'One' or 'ZeroOrOne' is required for this argument."
        /// </summary>
        internal static string Cqt_RelatedEntityRef_TargetEndMustBeAtMostOne
        {
            get { return EntityRes.GetString(EntityRes.Cqt_RelatedEntityRef_TargetEndMustBeAtMostOne); }
        }

        /// <summary>
        ///     A string like "The specified target relationship End is the same as the source relationship End."
        /// </summary>
        internal static string Cqt_RelatedEntityRef_TargetEndSameAsSourceEnd
        {
            get { return EntityRes.GetString(EntityRes.Cqt_RelatedEntityRef_TargetEndSameAsSourceEnd); }
        }

        /// <summary>
        ///     A string like "The target entity reference expression must have a reference ResultType."
        /// </summary>
        internal static string Cqt_RelatedEntityRef_TargetEntityNotRef
        {
            get { return EntityRes.GetString(EntityRes.Cqt_RelatedEntityRef_TargetEntityNotRef); }
        }

        /// <summary>
        ///     A string like "The specified target entity reference expression is not valid because it does not produce a reference to an entity of the same type or of a subtype of the EntityType referred to by the specified target End."
        /// </summary>
        internal static string Cqt_RelatedEntityRef_TargetEntityNotCompatible
        {
            get { return EntityRes.GetString(EntityRes.Cqt_RelatedEntityRef_TargetEntityNotCompatible); }
        }

        /// <summary>
        ///     A string like "Navigating composition relationships is not supported."
        /// </summary>
        internal static string Cqt_RelNav_NoCompositions
        {
            get { return EntityRes.GetString(EntityRes.Cqt_RelNav_NoCompositions); }
        }

        /// <summary>
        ///     A string like "The specified navigation requires a navigation source of a type that is compatible with '{0}'."
        /// </summary>
        internal static string Cqt_RelNav_WrongSourceType(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_RelNav_WrongSourceType, p0);
        }

        /// <summary>
        ///     A string like "Count must be a DbConstantExpression or a DbParameterReferenceExpression."
        /// </summary>
        internal static string Cqt_Skip_ConstantOrParameterRefRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Skip_ConstantOrParameterRefRequired); }
        }

        /// <summary>
        ///     A string like "Count must have an integer ResultType."
        /// </summary>
        internal static string Cqt_Skip_IntegerRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Skip_IntegerRequired); }
        }

        /// <summary>
        ///     A string like "Count must have a non-negative value."
        /// </summary>
        internal static string Cqt_Skip_NonNegativeCountRequired
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Skip_NonNegativeCountRequired); }
        }

        /// <summary>
        ///     A string like "Collation specifiers cannot be empty or consist only of white-space characters."
        /// </summary>
        internal static string Cqt_Sort_EmptyCollationInvalid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Sort_EmptyCollationInvalid); }
        }

        /// <summary>
        ///     A string like "A collation specifier is only valid for a sort key with a string ResultType."
        /// </summary>
        internal static string Cqt_Sort_NonStringCollationInvalid
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Sort_NonStringCollationInvalid); }
        }

        /// <summary>
        ///     A string like "DbSortClause expressions must have a type that is order comparable."
        /// </summary>
        internal static string Cqt_Sort_OrderComparable
        {
            get { return EntityRes.GetString(EntityRes.Cqt_Sort_OrderComparable); }
        }

        /// <summary>
        ///     A string like "An error occurred while preparing definition of the function '{0}'. See the inner exception for details."
        /// </summary>
        internal static string Cqt_UDF_FunctionDefinitionGenerationFailed(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_UDF_FunctionDefinitionGenerationFailed, p0);
        }

        /// <summary>
        ///     A string like "Definition of the function '{0}' contains a direct or indirect reference to itself. Recursive function definitions are not supported."
        /// </summary>
        internal static string Cqt_UDF_FunctionDefinitionWithCircularReference(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_UDF_FunctionDefinitionWithCircularReference, p0);
        }

        /// <summary>
        ///     A string like "The result type '{0}' specified in the declaration of the function '{1}' does not match the result type '{2}' of the function definition."
        /// </summary>
        internal static string Cqt_UDF_FunctionDefinitionResultTypeMismatch(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Cqt_UDF_FunctionDefinitionResultTypeMismatch, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The function '{0}' has no defining expression. A user-defined function needs a defining expression for successful execution."
        /// </summary>
        internal static string Cqt_UDF_FunctionHasNoDefinition(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_UDF_FunctionHasNoDefinition, p0);
        }

        /// <summary>
        ///     A string like "The referenced variable '{0}' is not defined in the current scope."
        /// </summary>
        internal static string Cqt_Validator_VarRefInvalid(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Validator_VarRefInvalid, p0);
        }

        /// <summary>
        ///     A string like "The ResultType of the referenced variable '{0}' does not match the type specified in this variable reference expression."
        /// </summary>
        internal static string Cqt_Validator_VarRefTypeMismatch(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_Validator_VarRefTypeMismatch, p0);
        }

        /// <summary>
        ///     A string like "The specified Op is of an unsupported type: {0}"
        /// </summary>
        internal static string Iqt_General_UnsupportedOp(object p0)
        {
            return EntityRes.GetString(EntityRes.Iqt_General_UnsupportedOp, p0);
        }

        /// <summary>
        ///     A string like "AggregateOp encountered outside of GroupBy method."
        /// </summary>
        internal static string Iqt_CTGen_UnexpectedAggregate
        {
            get { return EntityRes.GetString(EntityRes.Iqt_CTGen_UnexpectedAggregate); }
        }

        /// <summary>
        ///     A string like "Unexpected VarDefListOp"
        /// </summary>
        internal static string Iqt_CTGen_UnexpectedVarDefList
        {
            get { return EntityRes.GetString(EntityRes.Iqt_CTGen_UnexpectedVarDefList); }
        }

        /// <summary>
        ///     A string like "Unexpected VarDefOp"
        /// </summary>
        internal static string Iqt_CTGen_UnexpectedVarDef
        {
            get { return EntityRes.GetString(EntityRes.Iqt_CTGen_UnexpectedVarDef); }
        }

        /// <summary>
        ///     A string like "The CommandBehavior.SequentialAccess property must be specified for this command object."
        /// </summary>
        internal static string ADP_MustUseSequentialAccess
        {
            get { return EntityRes.GetString(EntityRes.ADP_MustUseSequentialAccess); }
        }

        /// <summary>
        ///     A string like "The ADO.NET Data Provider you are using does not support canonical command trees."
        /// </summary>
        internal static string ADP_ProviderDoesNotSupportCommandTrees
        {
            get { return EntityRes.GetString(EntityRes.ADP_ProviderDoesNotSupportCommandTrees); }
        }

        /// <summary>
        ///     A string like "The attempted operation is not valid. The data reader is closed."
        /// </summary>
        internal static string ADP_ClosedDataReaderError
        {
            get { return EntityRes.GetString(EntityRes.ADP_ClosedDataReaderError); }
        }

        /// <summary>
        ///     A string like "Calling '{0}' when the data reader is closed is not a valid operation."
        /// </summary>
        internal static string ADP_DataReaderClosed(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_DataReaderClosed, p0);
        }

        /// <summary>
        ///     A string like "The attempted operation is not valid. The nested data reader has been implicitly closed because its parent data reader has been read or closed."
        /// </summary>
        internal static string ADP_ImplicitlyClosedDataReaderError
        {
            get { return EntityRes.GetString(EntityRes.ADP_ImplicitlyClosedDataReaderError); }
        }

        /// <summary>
        ///     A string like "There was an attempt to read, but no data was present."
        /// </summary>
        internal static string ADP_NoData
        {
            get { return EntityRes.GetString(EntityRes.ADP_NoData); }
        }

        /// <summary>
        ///     A string like "The GetSchemaTable method is not supported."
        /// </summary>
        internal static string ADP_GetSchemaTableIsNotSupported
        {
            get { return EntityRes.GetString(EntityRes.ADP_GetSchemaTableIsNotSupported); }
        }

        /// <summary>
        ///     A string like "The data reader has more than one field. Multiple fields are not valid for EDM primitive or enumeration types."
        /// </summary>
        internal static string ADP_InvalidDataReaderFieldCountForScalarType
        {
            get { return EntityRes.GetString(EntityRes.ADP_InvalidDataReaderFieldCountForScalarType); }
        }

        /// <summary>
        ///     A string like "The data reader is incompatible with the specified '{0}'. A member of the type, '{1}', does not have a corresponding column in the data reader with the same name."
        /// </summary>
        internal static string ADP_InvalidDataReaderMissingColumnForType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidDataReaderMissingColumnForType, p0, p1);
        }

        /// <summary>
        ///     A string like "The data reader is incompatible with the function mapping '{1}'. The column with the name '{0}' does not exist."
        /// </summary>
        internal static string ADP_InvalidDataReaderMissingDiscriminatorColumn(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidDataReaderMissingDiscriminatorColumn, p0, p1);
        }

        /// <summary>
        ///     A string like "The data reader is incompatible with the specified function mapping, and the type of a row could not be determined for the type mapping."
        /// </summary>
        internal static string ADP_InvalidDataReaderUnableToDetermineType
        {
            get { return EntityRes.GetString(EntityRes.ADP_InvalidDataReaderUnableToDetermineType); }
        }

        /// <summary>
        ///     A string like "Cannot create a value for property '{0}' of type '{1}'. Only properties of primitive or enumeration types are supported."
        /// </summary>
        internal static string ADP_InvalidDataReaderUnableToMaterializeNonScalarType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidDataReaderUnableToMaterializeNonScalarType, p0, p1);
        }

        /// <summary>
        ///     A string like "The query attempted to call '{0}' over a nested query, but '{0}' did not have the appropriate keys."
        /// </summary>
        internal static string ADP_KeysRequiredForJoinOverNest(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_KeysRequiredForJoinOverNest, p0);
        }

        /// <summary>
        ///     A string like "The nested query does not have the appropriate keys."
        /// </summary>
        internal static string ADP_KeysRequiredForNesting
        {
            get { return EntityRes.GetString(EntityRes.ADP_KeysRequiredForNesting); }
        }

        /// <summary>
        ///     A string like "The nested query is not supported. Operation1='{0}' Operation2='{1}'"
        /// </summary>
        internal static string ADP_NestingNotSupported(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_NestingNotSupported, p0, p1);
        }

        /// <summary>
        ///     A string like "No query mapping view exists for the specified set '{0}.{1}'."
        /// </summary>
        internal static string ADP_NoQueryMappingView(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_NoQueryMappingView, p0, p1);
        }

        /// <summary>
        ///     A string like "Internal .NET Framework Data Provider error {0}."
        /// </summary>
        internal static string ADP_InternalProviderError(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_InternalProviderError, p0);
        }

        /// <summary>
        ///     A string like "The {0} enumeration value, {1}, is not valid."
        /// </summary>
        internal static string ADP_InvalidEnumerationValue(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidEnumerationValue, p0, p1);
        }

        /// <summary>
        ///     A string like "Buffer offset '{1}' plus the bytes available '{0}' is greater than the length of the passed in buffer."
        /// </summary>
        internal static string ADP_InvalidBufferSizeOrIndex(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidBufferSizeOrIndex, p0, p1);
        }

        /// <summary>
        ///     A string like "Data length '{0}' is less than 0."
        /// </summary>
        internal static string ADP_InvalidDataLength(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidDataLength, p0);
        }

        /// <summary>
        ///     A string like "The parameter data type of {0} is not valid."
        /// </summary>
        internal static string ADP_InvalidDataType(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidDataType, p0);
        }

        /// <summary>
        ///     A string like "Destination buffer is not valid (size of {0}) offset: {1}"
        /// </summary>
        internal static string ADP_InvalidDestinationBufferIndex(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidDestinationBufferIndex, p0, p1);
        }

        /// <summary>
        ///     A string like "Source buffer is not valid (size of {0}) offset: {1}"
        /// </summary>
        internal static string ADP_InvalidSourceBufferIndex(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidSourceBufferIndex, p0, p1);
        }

        /// <summary>
        ///     A string like "At dataOffset '{0}' {2} attempt is not valid.  With CommandBehavior.SequentialAccess, you may only read from dataOffset '{1}' or greater."
        /// </summary>
        internal static string ADP_NonSequentialChunkAccess(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ADP_NonSequentialChunkAccess, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Attempt to read from column ordinal '{0}' is not valid.  With CommandBehavior.SequentialAccess, you may only read from column ordinal '{1}' or greater."
        /// </summary>
        internal static string ADP_NonSequentialColumnAccess(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_NonSequentialColumnAccess, p0, p1);
        }

        /// <summary>
        ///     A string like "Unable to handle an unknown TypeCode {0} returned by Type {1}."
        /// </summary>
        internal static string ADP_UnknownDataTypeCode(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ADP_UnknownDataTypeCode, p0, p1);
        }

        /// <summary>
        ///     A string like "Data"
        /// </summary>
        internal static string DataCategory_Data
        {
            get { return EntityRes.GetString(EntityRes.DataCategory_Data); }
        }

        /// <summary>
        ///     A string like "Input, output, or bidirectional parameter."
        /// </summary>
        internal static string DbParameter_Direction
        {
            get { return EntityRes.GetString(EntityRes.DbParameter_Direction); }
        }

        /// <summary>
        ///     A string like "Size of variable length data types (string & arrays)."
        /// </summary>
        internal static string DbParameter_Size
        {
            get { return EntityRes.GetString(EntityRes.DbParameter_Size); }
        }

        /// <summary>
        ///     A string like "Update"
        /// </summary>
        internal static string DataCategory_Update
        {
            get { return EntityRes.GetString(EntityRes.DataCategory_Update); }
        }

        /// <summary>
        ///     A string like "When used by a DataAdapter.Update, the source column name that is used to find the DataSetColumn name in the ColumnMappings. This is to copy a value between the parameter and a data row."
        /// </summary>
        internal static string DbParameter_SourceColumn
        {
            get { return EntityRes.GetString(EntityRes.DbParameter_SourceColumn); }
        }

        /// <summary>
        ///     A string like "When used by a DataAdapter.Update (UpdateCommand only), the version of the DataRow value that is used to update the data source."
        /// </summary>
        internal static string DbParameter_SourceVersion
        {
            get { return EntityRes.GetString(EntityRes.DbParameter_SourceVersion); }
        }

        /// <summary>
        ///     A string like "The element in the collection parameter '{0}' cannot be null."
        /// </summary>
        internal static string ADP_CollectionParameterElementIsNull(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_CollectionParameterElementIsNull, p0);
        }

        /// <summary>
        ///     A string like "The element in the collection parameter '{0}' cannot be null or empty."
        /// </summary>
        internal static string ADP_CollectionParameterElementIsNullOrEmpty(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_CollectionParameterElementIsNullOrEmpty, p0);
        }

        /// <summary>
        ///     A string like "An EntityParameter with ParameterName '{0}' is not contained by this EntityParameterCollection."
        /// </summary>
        internal static string EntityParameterCollectionInvalidParameterName(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityParameterCollectionInvalidParameterName, p0);
        }

        /// <summary>
        ///     A string like "Invalid index {0} for this EntityParameterCollection with {1} elements."
        /// </summary>
        internal static string EntityParameterCollectionInvalidIndex(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityParameterCollectionInvalidIndex, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntityParameterCollection only accepts non-null EntityParameter type objects, not objects of type {0}."
        /// </summary>
        internal static string InvalidEntityParameterType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEntityParameterType, p0);
        }

        /// <summary>
        ///     A string like "The EntityParameter is already contained by another EntityParameterCollection."
        /// </summary>
        internal static string EntityParameterContainedByAnotherCollection
        {
            get { return EntityRes.GetString(EntityRes.EntityParameterContainedByAnotherCollection); }
        }

        /// <summary>
        ///     A string like "The EntityParameterCollection only accepts non-null EntityParameter type objects."
        /// </summary>
        internal static string EntityParameterNull
        {
            get { return EntityRes.GetString(EntityRes.EntityParameterNull); }
        }

        /// <summary>
        ///     A string like "Attempted to remove an EntityParameter that is not contained by this EntityParameterCollection."
        /// </summary>
        internal static string EntityParameterCollectionRemoveInvalidObject
        {
            get { return EntityRes.GetString(EntityRes.EntityParameterCollectionRemoveInvalidObject); }
        }

        /// <summary>
        ///     A string like "Format of the initialization string does not conform to specification starting at index {0}."
        /// </summary>
        internal static string ADP_ConnectionStringSyntax(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_ConnectionStringSyntax, p0);
        }

        /// <summary>
        ///     A string like "Expansion of |DataDirectory| failed while processing the connection string. Ensure that |DataDirectory| is set to a valid fully-qualified path."
        /// </summary>
        internal static string ExpandingDataDirectoryFailed
        {
            get { return EntityRes.GetString(EntityRes.ExpandingDataDirectoryFailed); }
        }

        /// <summary>
        ///     A string like "The DataDirectory substitute is not a string."
        /// </summary>
        internal static string ADP_InvalidDataDirectory
        {
            get { return EntityRes.GetString(EntityRes.ADP_InvalidDataDirectory); }
        }

        /// <summary>
        ///     A string like "Invalid usage of escape delimiters '[' or ']'."
        /// </summary>
        internal static string ADP_InvalidMultipartNameDelimiterUsage
        {
            get { return EntityRes.GetString(EntityRes.ADP_InvalidMultipartNameDelimiterUsage); }
        }

        /// <summary>
        ///     A string like "Invalid parameter Size value '{0}'. The value must be greater than or equal to 0."
        /// </summary>
        internal static string ADP_InvalidSizeValue(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_InvalidSizeValue, p0);
        }

        /// <summary>
        ///     A string like "Keyword not supported: '{0}'."
        /// </summary>
        internal static string ADP_KeywordNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_KeywordNotSupported, p0);
        }

        /// <summary>
        ///     A string like "Facet '{0}' must not be specified for type '{1}'."
        /// </summary>
        internal static string ConstantFacetSpecifiedInSchema(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ConstantFacetSpecifiedInSchema, p0, p1);
        }

        /// <summary>
        ///     A string like "Annotation '{0}' is already defined in '{1}'."
        /// </summary>
        internal static string DuplicateAnnotation(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DuplicateAnnotation, p0, p1);
        }

        /// <summary>
        ///     A string like "{0} does not contain a schema definition, or the XmlReader provided started at the end of the file."
        /// </summary>
        internal static string EmptyFile(object p0)
        {
            return EntityRes.GetString(EntityRes.EmptyFile, p0);
        }

        /// <summary>
        ///     A string like "The source XmlReader does not contain a schema definition or started at the end of the file."
        /// </summary>
        internal static string EmptySchemaTextReader
        {
            get { return EntityRes.GetString(EntityRes.EmptySchemaTextReader); }
        }

        /// <summary>
        ///     A string like "{0} is not valid."
        /// </summary>
        internal static string EmptyName(object p0)
        {
            return EntityRes.GetString(EntityRes.EmptyName, p0);
        }

        /// <summary>
        ///     A string like "{1} ({0}) is not valid."
        /// </summary>
        internal static string InvalidName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidName, p0, p1);
        }

        /// <summary>
        ///     A string like "The name is missing or not valid."
        /// </summary>
        internal static string MissingName
        {
            get { return EntityRes.GetString(EntityRes.MissingName); }
        }

        /// <summary>
        ///     A string like "Unrecognized schema attribute: {0}."
        /// </summary>
        internal static string UnexpectedXmlAttribute(object p0)
        {
            return EntityRes.GetString(EntityRes.UnexpectedXmlAttribute, p0);
        }

        /// <summary>
        ///     A string like "Unrecognized schema element: {0}."
        /// </summary>
        internal static string UnexpectedXmlElement(object p0)
        {
            return EntityRes.GetString(EntityRes.UnexpectedXmlElement, p0);
        }

        /// <summary>
        ///     A string like "The current schema element does not support text ({0})."
        /// </summary>
        internal static string TextNotAllowed(object p0)
        {
            return EntityRes.GetString(EntityRes.TextNotAllowed, p0);
        }

        /// <summary>
        ///     A string like "Unexpected XmlNode type: {0}."
        /// </summary>
        internal static string UnexpectedXmlNodeType(object p0)
        {
            return EntityRes.GetString(EntityRes.UnexpectedXmlNodeType, p0);
        }

        /// <summary>
        ///     A string like "Malformed XML. Element starting at ({0},{1}) has no closing tag."
        /// </summary>
        internal static string MalformedXml(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MalformedXml, p0, p1);
        }

        /// <summary>
        ///     A string like "{1} value ({0}) was not understood."
        /// </summary>
        internal static string ValueNotUnderstood(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ValueNotUnderstood, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntityContainer name must be unique. An EntityContainer with the name '{0}' is already defined."
        /// </summary>
        internal static string EntityContainerAlreadyExists(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityContainerAlreadyExists, p0);
        }

        /// <summary>
        ///     A string like "Each type name in a schema must be unique. Type name '{0}' was already defined."
        /// </summary>
        internal static string TypeNameAlreadyDefinedDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.TypeNameAlreadyDefinedDuplicate, p0);
        }

        /// <summary>
        ///     A string like "Each property name in a type must be unique. Property name '{0}' was already defined."
        /// </summary>
        internal static string PropertyNameAlreadyDefinedDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.PropertyNameAlreadyDefinedDuplicate, p0);
        }

        /// <summary>
        ///     A string like "Each member name in an EntityContainer must be unique. The member '{0}' is already defined in EntityContainer '{1}'. Because EntityContainer '{2}' extends EntityContainer '{1}', you cannot have a member with the same name in EntityContainer '{2}'."
        /// </summary>
        internal static string DuplicateMemberNameInExtendedEntityContainer(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DuplicateMemberNameInExtendedEntityContainer, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Each member name in an EntityContainer must be unique. A member with name '{0}' is already defined."
        /// </summary>
        internal static string DuplicateEntityContainerMemberName(object p0)
        {
            return EntityRes.GetString(EntityRes.DuplicateEntityContainerMemberName, p0);
        }

        /// <summary>
        ///     A string like "{0} property is not valid. A type is already defined for this property."
        /// </summary>
        internal static string PropertyTypeAlreadyDefined(object p0)
        {
            return EntityRes.GetString(EntityRes.PropertyTypeAlreadyDefined, p0);
        }

        /// <summary>
        ///     A string like "MaxLength '{0}' is not valid. Length must be between '{1}' and '{2}' for '{3}' type."
        /// </summary>
        internal static string InvalidSize(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.InvalidSize, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "SRID '{0}' is not valid. Its value must be between '{1}' and '{2}' for '{3}' type."
        /// </summary>
        internal static string InvalidSystemReferenceId(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.InvalidSystemReferenceId, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "Unknown namespace or alias ({0})."
        /// </summary>
        internal static string BadNamespaceOrAlias(object p0)
        {
            return EntityRes.GetString(EntityRes.BadNamespaceOrAlias, p0);
        }

        /// <summary>
        ///     A string like "Schema must specify a value for the Namespace attribute."
        /// </summary>
        internal static string MissingNamespaceAttribute
        {
            get { return EntityRes.GetString(EntityRes.MissingNamespaceAttribute); }
        }

        /// <summary>
        ///     A string like "BaseType ({0}) is not valid. The BaseType for {1} must be a structured type."
        /// </summary>
        internal static string InvalidBaseTypeForStructuredType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidBaseTypeForStructuredType, p0, p1);
        }

        /// <summary>
        ///     A string like "A property cannot be of type {0}. The property type must be an inline type, a scalar type, or an enumeration type."
        /// </summary>
        internal static string InvalidPropertyType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidPropertyType, p0);
        }

        /// <summary>
        ///     A string like "BaseType ({0}) is not valid. The BaseType for {1} must be another EntityType."
        /// </summary>
        internal static string InvalidBaseTypeForItemType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidBaseTypeForItemType, p0, p1);
        }

        /// <summary>
        ///     A string like "BaseType ({0}) is not valid. The BaseType for {1} must be another ComplexType."
        /// </summary>
        internal static string InvalidBaseTypeForNestedType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidBaseTypeForNestedType, p0, p1);
        }

        /// <summary>
        ///     A string like "Default values are allowed only for non-spatial primitive types."
        /// </summary>
        internal static string DefaultNotAllowed
        {
            get { return EntityRes.GetString(EntityRes.DefaultNotAllowed); }
        }

        /// <summary>
        ///     A string like "{0} facet isn't allowed for properties of type {1}."
        /// </summary>
        internal static string FacetNotAllowed(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.FacetNotAllowed, p0, p1);
        }

        /// <summary>
        ///     A string like "Facet '{0}' must be specified for '{1}' typed properties."
        /// </summary>
        internal static string RequiredFacetMissing(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.RequiredFacetMissing, p0, p1);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid for Binary. Value must be of form 0x123 where 123 stands for a non-empty sequence of hex digits."
        /// </summary>
        internal static string InvalidDefaultBinaryWithNoMaxLength(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultBinaryWithNoMaxLength, p0);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid. Expected an integer between {1} and {2}."
        /// </summary>
        internal static string InvalidDefaultIntegral(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultIntegral, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid for DateTime. The value must be in the form '{1}'."
        /// </summary>
        internal static string InvalidDefaultDateTime(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultDateTime, p0, p1);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid for Time. The value must be in the form '{1}'."
        /// </summary>
        internal static string InvalidDefaultTime(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultTime, p0, p1);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid for DateTimeOffset. The value must be in the form '{1}'."
        /// </summary>
        internal static string InvalidDefaultDateTimeOffset(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultDateTimeOffset, p0, p1);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not compatible with the facets specified for Decimal. The value must be a decimal number with scale less than or equal to {1} and precision less than or equal to {2}."
        /// </summary>
        internal static string InvalidDefaultDecimal(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultDecimal, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid. The value must be a floating point number between {1} and {2}."
        /// </summary>
        internal static string InvalidDefaultFloatingPoint(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultFloatingPoint, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid for GUID. The value must be enclosed in single quotes in the form 'dddddddd-dddd-dddd-dddd-dddddddddddd'."
        /// </summary>
        internal static string InvalidDefaultGuid(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultGuid, p0);
        }

        /// <summary>
        ///     A string like "Default value ({0}) is not valid for Boolean. The value must be true or false."
        /// </summary>
        internal static string InvalidDefaultBoolean(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidDefaultBoolean, p0);
        }

        /// <summary>
        ///     A string like "A member named {0} cannot be defined in class {1}. It is defined in ancestor class {2}."
        /// </summary>
        internal static string DuplicateMemberName(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DuplicateMemberName, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "error"
        /// </summary>
        internal static string GeneratorErrorSeverityError
        {
            get { return EntityRes.GetString(EntityRes.GeneratorErrorSeverityError); }
        }

        /// <summary>
        ///     A string like "warning"
        /// </summary>
        internal static string GeneratorErrorSeverityWarning
        {
            get { return EntityRes.GetString(EntityRes.GeneratorErrorSeverityWarning); }
        }

        /// <summary>
        ///     A string like "unknown"
        /// </summary>
        internal static string GeneratorErrorSeverityUnknown
        {
            get { return EntityRes.GetString(EntityRes.GeneratorErrorSeverityUnknown); }
        }

        /// <summary>
        ///     A string like "<File Unknown>"
        /// </summary>
        internal static string SourceUriUnknown
        {
            get { return EntityRes.GetString(EntityRes.SourceUriUnknown); }
        }

        /// <summary>
        ///     A string like "Precision and Scale combination is not valid. Precision ({0}) must be greater than or equal to Scale ({1})."
        /// </summary>
        internal static string BadPrecisionAndScale(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.BadPrecisionAndScale, p0, p1);
        }

        /// <summary>
        ///     A string like "No schema encountered with '{0}' namespace. Make sure the namespace is correct or the schema defining the namespace is specified."
        /// </summary>
        internal static string InvalidNamespaceInUsing(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidNamespaceInUsing, p0);
        }

        /// <summary>
        ///     A string like "NavigationProperty is not valid. {0} is not a Relationship."
        /// </summary>
        internal static string BadNavigationPropertyRelationshipNotRelationship(object p0)
        {
            return EntityRes.GetString(EntityRes.BadNavigationPropertyRelationshipNotRelationship, p0);
        }

        /// <summary>
        ///     A string like "NavigationProperty is not valid. The FromRole and ToRole are the same."
        /// </summary>
        internal static string BadNavigationPropertyRolesCannotBeTheSame
        {
            get { return EntityRes.GetString(EntityRes.BadNavigationPropertyRolesCannotBeTheSame); }
        }

        /// <summary>
        ///     A string like "NavigationProperty is not valid. The role {0} is not defined in Relationship {1}."
        /// </summary>
        internal static string BadNavigationPropertyUndefinedRole(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.BadNavigationPropertyUndefinedRole, p0, p1);
        }

        /// <summary>
        ///     A string like "NavigationProperty '{0}' is not valid. Type '{1}' of FromRole '{2}' in AssociationType '{3}' must exactly match with the type '{4}' on which this NavigationProperty is declared on."
        /// </summary>
        internal static string BadNavigationPropertyBadFromRoleType(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.BadNavigationPropertyBadFromRoleType, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "Name {0} cannot be used in type {1}. Member names cannot be the same as their enclosing type."
        /// </summary>
        internal static string InvalidMemberNameMatchesTypeName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMemberNameMatchesTypeName, p0, p1);
        }

        /// <summary>
        ///     A string like "Key usage is not valid. {0} cannot define keys because one of its base classes ({1}) defines keys."
        /// </summary>
        internal static string InvalidKeyKeyDefinedInBaseClass(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidKeyKeyDefinedInBaseClass, p0, p1);
        }

        /// <summary>
        ///     A string like "Key Part: '{0}' for type {1} is not valid. All parts of the key must be non nullable."
        /// </summary>
        internal static string InvalidKeyNullablePart(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidKeyNullablePart, p0, p1);
        }

        /// <summary>
        ///     A string like "Key: {0} is not valid. {1} is not a valid property name."
        /// </summary>
        internal static string InvalidKeyNoProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidKeyNoProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "EntityType '{0}' has no key defined. Define the key for this EntityType."
        /// </summary>
        internal static string KeyMissingOnEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.KeyMissingOnEntityType, p0);
        }

        /// <summary>
        ///     A string like "Documentation content is not valid. The Documentation element can only contain Summary and LongDescription elements."
        /// </summary>
        internal static string InvalidDocumentationBothTextAndStructure
        {
            get { return EntityRes.GetString(EntityRes.InvalidDocumentationBothTextAndStructure); }
        }

        /// <summary>
        ///     A string like "Value {0} is not valid. Expected a non-negative value."
        /// </summary>
        internal static string ArgumentOutOfRangeExpectedPostiveNumber(object p0)
        {
            return EntityRes.GetString(EntityRes.ArgumentOutOfRangeExpectedPostiveNumber, p0);
        }

        /// <summary>
        ///     A string like "{0} is out of range."
        /// </summary>
        internal static string ArgumentOutOfRange(object p0)
        {
            return EntityRes.GetString(EntityRes.ArgumentOutOfRange, p0);
        }

        /// <summary>
        ///     A string like "URI {0} is not acceptable. URIs must be absolute or specify a file."
        /// </summary>
        internal static string UnacceptableUri(object p0)
        {
            return EntityRes.GetString(EntityRes.UnacceptableUri, p0);
        }

        /// <summary>
        ///     A string like "Element of unexpected type {0} was found at index {1}."
        /// </summary>
        internal static string UnexpectedTypeInCollection(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.UnexpectedTypeInCollection, p0, p1);
        }

        /// <summary>
        ///     A string like "All elements in a schema must be contained in the Schema element."
        /// </summary>
        internal static string AllElementsMustBeInSchema
        {
            get { return EntityRes.GetString(EntityRes.AllElementsMustBeInSchema); }
        }

        /// <summary>
        ///     A string like "Each alias in a schema must be unique. Alias '{0}' was already used in this schema."
        /// </summary>
        internal static string AliasNameIsAlreadyDefined(object p0)
        {
            return EntityRes.GetString(EntityRes.AliasNameIsAlreadyDefined, p0);
        }

        /// <summary>
        ///     A string like "The namespace '{0}' is a system namespace and is implicitly referred by every schema. You cannot specify an explicit reference to this namespace."
        /// </summary>
        internal static string NeedNotUseSystemNamespaceInUsing(object p0)
        {
            return EntityRes.GetString(EntityRes.NeedNotUseSystemNamespaceInUsing, p0);
        }

        /// <summary>
        ///     A string like "'{0}' is a system namespace and cannot be used as an Alias. Use some other Alias."
        /// </summary>
        internal static string CannotUseSystemNamespaceAsAlias(object p0)
        {
            return EntityRes.GetString(EntityRes.CannotUseSystemNamespaceAsAlias, p0);
        }

        /// <summary>
        ///     A string like "The EntitySet {0} is based on type {1} that has no keys defined."
        /// </summary>
        internal static string EntitySetTypeHasNoKeys(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntitySetTypeHasNoKeys, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' has both a Table or Schema attribute and a DefiningQuery element. The Table and Schema attributes on EntitySet are mutually exclusive with the DefiningQuery element. Use only the Table and Schema attributes or the DefiningQuery element."
        /// </summary>
        internal static string TableAndSchemaAreMutuallyExclusiveWithDefiningQuery(object p0)
        {
            return EntityRes.GetString(EntityRes.TableAndSchemaAreMutuallyExclusiveWithDefiningQuery, p0);
        }

        /// <summary>
        ///     A string like "The element {1} in namespace {0} was unexpected for the root element. The expected Schema in one of the following namespaces: {2}."
        /// </summary>
        internal static string UnexpectedRootElement(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.UnexpectedRootElement, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The element {1} was unexpected for the root element. The expected Schema in one of the following namespaces: {2}."
        /// </summary>
        internal static string UnexpectedRootElementNoNamespace(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.UnexpectedRootElementNoNamespace, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Each parameter name in a function must be unique. The parameter name '{0}' was already defined."
        /// </summary>
        internal static string ParameterNameAlreadyDefinedDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.ParameterNameAlreadyDefinedDuplicate, p0);
        }

        /// <summary>
        ///     A string like "Type '{0}' is not valid in function '{1}'. The function must have return type and parameters expressed in primitive types."
        /// </summary>
        internal static string FunctionWithNonPrimitiveTypeNotSupported(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.FunctionWithNonPrimitiveTypeNotSupported, p0, p1);
        }

        /// <summary>
        ///     A string like "Type '{0}' is not valid in function '{1}'. The function must have return type and parameters expressed in conceptual side primitive types."
        /// </summary>
        internal static string FunctionWithNonEdmPrimitiveTypeNotSupported(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.FunctionWithNonEdmPrimitiveTypeNotSupported, p0, p1);
        }

        /// <summary>
        ///     A string like "Return type is not valid in FunctionImport '{0}'. The FunctionImport must return a collection of scalar values or a collection of entities."
        /// </summary>
        internal static string FunctionImportWithUnsupportedReturnTypeV1(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportWithUnsupportedReturnTypeV1, p0);
        }

        /// <summary>
        ///     A string like "Return type is not valid in FunctionImport '{0}'. The FunctionImport must return Scalar, Entity, or ComplexType."
        /// </summary>
        internal static string FunctionImportWithUnsupportedReturnTypeV1_1(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportWithUnsupportedReturnTypeV1_1, p0);
        }

        /// <summary>
        ///     A string like "Return type is not valid in FunctionImport '{0}'. The FunctionImport can have no return type or return a collection of scalar values, a collection of complex types or a collection of entities."
        /// </summary>
        internal static string FunctionImportWithUnsupportedReturnTypeV2(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportWithUnsupportedReturnTypeV2, p0);
        }

        /// <summary>
        ///     A string like "EntitySet '{0}' is not valid in FunctionImport '{1}'. Unable to find an EntitySet with the name."
        /// </summary>
        internal static string FunctionImportUnknownEntitySet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.FunctionImportUnknownEntitySet, p0, p1);
        }

        /// <summary>
        ///     A string like "FunctionImport '{0}' returns entities but does not specify an EntitySet."
        /// </summary>
        internal static string FunctionImportReturnEntitiesButDoesNotSpecifyEntitySet(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportReturnEntitiesButDoesNotSpecifyEntitySet, p0);
        }

        /// <summary>
        ///     A string like "The function import '{0}' returns entities of type '{1}' that cannot exist in the declared EntitySet '{2}'."
        /// </summary>
        internal static string FunctionImportEntityTypeDoesNotMatchEntitySet(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.FunctionImportEntityTypeDoesNotMatchEntitySet, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The function import '{0}' specifies an entity set but does not return entities."
        /// </summary>
        internal static string FunctionImportSpecifiesEntitySetButNotEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportSpecifiesEntitySetButNotEntityType, p0);
        }

        /// <summary>
        ///     A string like "The function import '{0}' specifies an entity set and an entity set path. A function import may only specify one of these values but not both."
        /// </summary>
        internal static string FunctionImportEntitySetAndEntitySetPathDeclared(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportEntitySetAndEntitySetPathDeclared, p0);
        }

        /// <summary>
        ///     A string like "The function import '{0}' is declared as composable and side-effecting. A function import can be either composable or side-effecting, but not both."
        /// </summary>
        internal static string FunctionImportComposableAndSideEffectingNotAllowed(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportComposableAndSideEffectingNotAllowed, p0);
        }

        /// <summary>
        ///     A string like "The function import '{0}' has a parameter of a collection or reference type. Parameters of a collection or reference type are not allowed in function imports."
        /// </summary>
        internal static string FunctionImportCollectionAndRefParametersNotAllowed(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportCollectionAndRefParametersNotAllowed, p0);
        }

        /// <summary>
        ///     A string like "The function import '{0}' has a non-nullable parameter. Only nullable parameters are allowed in function imports."
        /// </summary>
        internal static string FunctionImportNonNullableParametersNotAllowed(object p0)
        {
            return EntityRes.GetString(EntityRes.FunctionImportNonNullableParametersNotAllowed, p0);
        }

        /// <summary>
        ///     A string like "All properties of the row type returned by a store-defined function must be scalar."
        /// </summary>
        internal static string TVFReturnTypeRowHasNonScalarProperty
        {
            get { return EntityRes.GetString(EntityRes.TVFReturnTypeRowHasNonScalarProperty); }
        }

        /// <summary>
        ///     A string like "The EntitySet '{0}' with schema '{1}' and table '{2}' was already defined. Each EntitySet must refer to a unique schema and table."
        /// </summary>
        internal static string DuplicateEntitySetTable(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.DuplicateEntitySetTable, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Type '{0}' is derived from the type '{1}' that is the type for EntitySet '{2}'. Type '{0}' defines new concurrency requirements that are not allowed for sub types of base EntitySet types."
        /// </summary>
        internal static string ConcurrencyRedefinedOnSubTypeOfEntitySetType(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ConcurrencyRedefinedOnSubTypeOfEntitySetType, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "In EntityContainer '{4}', Role '{0}' in '{1}' and '{2}' AssociationSet refers to the same EntitySet '{3}'. Make sure that if two or more AssociationSet refer to the same AssociationType, the ends must not refer to the same EntitySet."
        /// </summary>
        internal static string SimilarRelationshipEnd(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.SimilarRelationshipEnd, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "Relationship {0} is not valid. Multiplicity ({1}) is not valid. Multiplicity must be: '*', '0..1', or '1'."
        /// </summary>
        internal static string InvalidRelationshipEndMultiplicity(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidRelationshipEndMultiplicity, p0, p1);
        }

        /// <summary>
        ///     A string like "Each Name and PluralName in a relationship must be unique. '{0}' was already defined."
        /// </summary>
        internal static string EndNameAlreadyDefinedDuplicate(object p0)
        {
            return EntityRes.GetString(EntityRes.EndNameAlreadyDefinedDuplicate, p0);
        }

        /// <summary>
        ///     A string like "Relationship {0} is not valid. End type ({1}) is not valid. The End type must be an EntityType."
        /// </summary>
        internal static string InvalidRelationshipEndType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidRelationshipEndType, p0, p1);
        }

        /// <summary>
        ///     A string like "The parameter {0} in function '{1}' in schema '{2}' has an invalid parameter direction {3}. Valid parameter directions are: In, Out, and InOut."
        /// </summary>
        internal static string BadParameterDirection(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.BadParameterDirection, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The parameter {0} in function '{1}' in schema '{2}' has an invalid parameter direction {3}. The only valid value for this parameter is In."
        /// </summary>
        internal static string BadParameterDirectionForComposableFunctions(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.BadParameterDirectionForComposableFunctions, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "OnDelete, OnLock, and other such elements can be specified on only one End of an Association."
        /// </summary>
        internal static string InvalidOperationMultipleEndsInAssociation
        {
            get { return EntityRes.GetString(EntityRes.InvalidOperationMultipleEndsInAssociation); }
        }

        /// <summary>
        ///     A string like "The Action {0} on {1} is not recognized. Valid actions are: None, Cascade, and Restrict."
        /// </summary>
        internal static string InvalidAction(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidAction, p0, p1);
        }

        /// <summary>
        ///     A string like "Only one {0} element is allowed per relationship."
        /// </summary>
        internal static string DuplicationOperation(object p0)
        {
            return EntityRes.GetString(EntityRes.DuplicationOperation, p0);
        }

        /// <summary>
        ///     A string like "Type {0} is not defined in namespace {1} (Alias={2})."
        /// </summary>
        internal static string NotInNamespaceAlias(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.NotInNamespaceAlias, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The Type {0} is not qualified with a namespace or alias. Only primitive types can be used without qualification."
        /// </summary>
        internal static string NotNamespaceQualified(object p0)
        {
            return EntityRes.GetString(EntityRes.NotNamespaceQualified, p0);
        }

        /// <summary>
        ///     A string like "Type {0} is not defined in namespace {1}."
        /// </summary>
        internal static string NotInNamespaceNoAlias(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NotInNamespaceNoAlias, p0, p1);
        }

        /// <summary>
        ///     A string like "The value {0} is not valid for ParameterTypeSemantics attribute. Valid values are 'ExactMatchOnly', 'AllowImplicitPromotion' or 'AllowImplicitConversion'."
        /// </summary>
        internal static string InvalidValueForParameterTypeSemanticsAttribute(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidValueForParameterTypeSemanticsAttribute, p0);
        }

        /// <summary>
        ///     A string like "Key specified in EntityType '{0}' is not valid. Property '{1}' is referenced more than once in the Key element."
        /// </summary>
        internal static string DuplicatePropertyNameSpecifiedInEntityKey(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.DuplicatePropertyNameSpecifiedInEntityKey, p0, p1);
        }

        /// <summary>
        ///     A string like "An EntitySet cannot be of type {0}. The property type must be an EntityType, or an AssociationEntityType."
        /// </summary>
        internal static string InvalidEntitySetType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEntitySetType, p0);
        }

        /// <summary>
        ///     A string like "A RelationshipSet cannot be of type {0}. The property type must be a Relationship."
        /// </summary>
        internal static string InvalidRelationshipSetType(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidRelationshipSetType, p0);
        }

        /// <summary>
        ///     A string like "No EntityContainer found with name '{0}'."
        /// </summary>
        internal static string InvalidEntityContainerNameInExtends(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEntityContainerNameInExtends, p0);
        }

        /// <summary>
        ///     A string like "'{0}' is not a valid namespace or alias name. You must use the current schema namespace or alias to qualify the type."
        /// </summary>
        internal static string InvalidNamespaceOrAliasSpecified(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidNamespaceOrAliasSpecified, p0);
        }

        /// <summary>
        ///     A string like "Maximum value '{0}' for Scale facet must be less than or equal to the maximum value '{1}' for Precision Facet in '{2}' type."
        /// </summary>
        internal static string InvalidPrecisionAndScaleSpecified(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidPrecisionAndScaleSpecified, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Precision '{0}' is not valid. Precision must be between '{1}' and '{2}' for '{3}' type."
        /// </summary>
        internal static string PrecisionOutOfRange(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.PrecisionOutOfRange, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "Scale '{0}' is not valid. Scale must be between '{1}' and '{2}' for '{3}' type."
        /// </summary>
        internal static string ScaleOutOfRange(object p0, object p1, object p2, object p3)
        {
            return EntityRes.GetString(EntityRes.ScaleOutOfRange, p0, p1, p2, p3);
        }

        /// <summary>
        ///     A string like "The referenced EntitySet {0} for End {1} could not be found in the containing EntityContainer."
        /// </summary>
        internal static string InvalidEntitySetNameReference(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidEntitySetNameReference, p0, p1);
        }

        /// <summary>
        ///     A string like "The End {0} does not match any Ends on the {1} type."
        /// </summary>
        internal static string InvalidEntityEndName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidEntityEndName, p0, p1);
        }

        /// <summary>
        ///     A string like "The End Name {0} is already defined."
        /// </summary>
        internal static string DuplicateEndName(object p0)
        {
            return EntityRes.GetString(EntityRes.DuplicateEndName, p0);
        }

        /// <summary>
        ///     A string like "The EntitySet for the End '{0}' in AssociationSet '{1}'was not specified, and cannot be inferred because the EntitySet is ambiguous. More than one EntitySet could be used; an explicit End element with an EntitySet attribute must be specified."
        /// </summary>
        internal static string AmbiguousEntityContainerEnd(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.AmbiguousEntityContainerEnd, p0, p1);
        }

        /// <summary>
        ///     A string like "The EntitySet for the End '{0}' in AssociationSet '{1}' was not specified, and cannot be inferred because none of the EntitySet elements are of the correct type."
        /// </summary>
        internal static string MissingEntityContainerEnd(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MissingEntityContainerEnd, p0, p1);
        }

        /// <summary>
        ///     A string like "The End {0} has a different Type than the EntitySet it refers to."
        /// </summary>
        internal static string InvalidEndEntitySetTypeMismatch(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidEndEntitySetTypeMismatch, p0);
        }

        /// <summary>
        ///     A string like "In EntityContainer '{4}', the Role for the End with the EntitySet '{0}', in the AssociationSet '{1}' was not supplied, and there were no Ends in the Relationship '{2}' that matched the type '{3}'."
        /// </summary>
        internal static string InferRelationshipEndFailedNoEntitySetMatch(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.InferRelationshipEndFailedNoEntitySetMatch, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "In EntityContainer '{4}', the Role for the End with the EntitySet '{0}' in the AssociationSet '{1}' was not supplied, and there is more than one End in the Relationship '{2}' that could match the type '{3}'. Provide the Role attribute to disambiguate the End."
        /// </summary>
        internal static string InferRelationshipEndAmbiguous(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.InferRelationshipEndAmbiguous, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "The Role for the End with the EntitySet {0} in the AssociationSet {1} was not supplied and the End found matches one that is already defined. Change the EntitySet to one which has a type of a different End of the Relationship."
        /// </summary>
        internal static string InferRelationshipEndGivesAlreadyDefinedEnd(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InferRelationshipEndGivesAlreadyDefinedEnd, p0, p1);
        }

        /// <summary>
        ///     A string like "The Association {0} is not valid. Associations may only contain two End elements."
        /// </summary>
        internal static string TooManyAssociationEnds(object p0)
        {
            return EntityRes.GetString(EntityRes.TooManyAssociationEnds, p0);
        }

        /// <summary>
        ///     A string like "There is no Role with name '{0}' defined in relationship '{1}'. Check and try again."
        /// </summary>
        internal static string InvalidEndRoleInRelationshipConstraint(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidEndRoleInRelationshipConstraint, p0, p1);
        }

        /// <summary>
        ///     A string like "Properties referred by the Principal Role {0} must be exactly identical to the key of the EntityType {1} referred to by the Principal Role in the relationship constraint for Relationship {2}. Make sure all the key properties are specified in the Principal Role."
        /// </summary>
        internal static string InvalidFromPropertyInRelationshipConstraint(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidFromPropertyInRelationshipConstraint, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Properties referred by the Dependent Role {0} must be a subset of the key of the EntityType {1} referred to by the Dependent Role in the referential constraint for Relationship {2}."
        /// </summary>
        internal static string InvalidToPropertyInRelationshipConstraint(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.InvalidToPropertyInRelationshipConstraint, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "There is no property with name '{0}' defined in type referred by Role '{1}'."
        /// </summary>
        internal static string InvalidPropertyInRelationshipConstraint(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidPropertyInRelationshipConstraint, p0, p1);
        }

        /// <summary>
        ///     A string like "The types of all properties in the Dependent Role of a referential constraint must be the same as the corresponding property types in the Principal Role. The type of property '{0}' on entity '{1}' does not match the type of property '{2}' on entity '{3}' in the referential constraint '{4}'."
        /// </summary>
        internal static string TypeMismatchRelationshipConstaint(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.TypeMismatchRelationshipConstaint, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in role '{0}' in relationship '{1}'. Valid values for multiplicity for Principal Role are '0..1' or '1'."
        /// </summary>
        internal static string InvalidMultiplicityFromRoleUpperBoundMustBeOne(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMultiplicityFromRoleUpperBoundMustBeOne, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity conflicts with the referential constraint in Role '{0}' in relationship '{1}'. Because one/all of the properties in the Dependent Role is non-nullable, multiplicity of the Principal Role must be '1'."
        /// </summary>
        internal static string InvalidMultiplicityFromRoleToPropertyNonNullableV1(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMultiplicityFromRoleToPropertyNonNullableV1, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity conflicts with the referential constraint in Role '{0}' in relationship '{1}'. Because all of the properties in the Dependent Role are non-nullable, multiplicity of the Principal Role must be '1'."
        /// </summary>
        internal static string InvalidMultiplicityFromRoleToPropertyNonNullableV2(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMultiplicityFromRoleToPropertyNonNullableV2, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. Because all the properties in the Dependent Role are nullable, multiplicity of the Principal Role must be '0..1'."
        /// </summary>
        internal static string InvalidMultiplicityFromRoleToPropertyNullableV1(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMultiplicityFromRoleToPropertyNullableV1, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. The Lower Bound of the multiplicity must be 0."
        /// </summary>
        internal static string InvalidMultiplicityToRoleLowerBoundMustBeZero(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMultiplicityToRoleLowerBoundMustBeZero, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. Because the Dependent Role refers to the key properties, the upper bound of the multiplicity of the Dependent Role must be 1."
        /// </summary>
        internal static string InvalidMultiplicityToRoleUpperBoundMustBeOne(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMultiplicityToRoleUpperBoundMustBeOne, p0, p1);
        }

        /// <summary>
        ///     A string like "Multiplicity is not valid in Role '{0}' in relationship '{1}'. Because the Dependent Role properties are not the key properties, the upper bound of the multiplicity of the Dependent Role must be *."
        /// </summary>
        internal static string InvalidMultiplicityToRoleUpperBoundMustBeMany(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.InvalidMultiplicityToRoleUpperBoundMustBeMany, p0, p1);
        }

        /// <summary>
        ///     A string like "Number of Properties in the Dependent and Principal Role in a relationship constraint must be exactly identical."
        /// </summary>
        internal static string MismatchNumberOfPropertiesinRelationshipConstraint
        {
            get { return EntityRes.GetString(EntityRes.MismatchNumberOfPropertiesinRelationshipConstraint); }
        }

        /// <summary>
        ///     A string like "The relationship '{0}' does not contain the required referential constraint."
        /// </summary>
        internal static string MissingConstraintOnRelationshipType(object p0)
        {
            return EntityRes.GetString(EntityRes.MissingConstraintOnRelationshipType, p0);
        }

        /// <summary>
        ///     A string like "In relationship '{0}', the Principal and Dependent Role of the referential constraint refers to the same Role in the relationship type."
        /// </summary>
        internal static string SameRoleReferredInReferentialConstraint(object p0)
        {
            return EntityRes.GetString(EntityRes.SameRoleReferredInReferentialConstraint, p0);
        }

        /// <summary>
        ///     A string like "The value '{0}' is not a valid PrimitiveTypeKind."
        /// </summary>
        internal static string InvalidPrimitiveTypeKind(object p0)
        {
            return EntityRes.GetString(EntityRes.InvalidPrimitiveTypeKind, p0);
        }

        /// <summary>
        ///     A string like "The property '{0}' in EntityType '{1}' is not valid. All properties that are part of the EntityKey must be of enumeration or primitive type."
        /// </summary>
        internal static string EntityKeyMustBeScalar(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityKeyMustBeScalar, p0, p1);
        }

        /// <summary>
        ///     A string like "The property '{0}' in EntityType '{1}' is not valid. Type '{2}' of the property maps to '{3}' and EntityKey properties that are of type '{4}' are currently not supported."
        /// </summary>
        internal static string EntityKeyTypeCurrentlyNotSupportedInSSDL(object p0, object p1, object p2, object p3, object p4)
        {
            return EntityRes.GetString(EntityRes.EntityKeyTypeCurrentlyNotSupportedInSSDL, p0, p1, p2, p3, p4);
        }

        /// <summary>
        ///     A string like "The property '{0}' in EntityType '{1}' is not valid. EntityKey properties that are of type '{2}' are currently not supported."
        /// </summary>
        internal static string EntityKeyTypeCurrentlyNotSupported(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EntityKeyTypeCurrentlyNotSupported, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The type '{0}' is of PrimitiveTypeKind {1} which must have the facet description {2}."
        /// </summary>
        internal static string MissingFacetDescription(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.MissingFacetDescription, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "End '{0}' on relationship '{1}' cannot have operation specified since its multiplicity is '*'. Operations cannot be specified on ends with multiplicity '*'."
        /// </summary>
        internal static string EndWithManyMultiplicityCannotHaveOperationsSpecified(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EndWithManyMultiplicityCannotHaveOperationsSpecified, p0, p1);
        }

        /// <summary>
        ///     A string like "End '{0}' on relationship '{1}' must specify multiplicity."
        /// </summary>
        internal static string EndWithoutMultiplicity(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EndWithoutMultiplicity, p0, p1);
        }

        /// <summary>
        ///     A string like "EntityContainer '{0}' cannot extend itself. Specify some other EntityContainer name."
        /// </summary>
        internal static string EntityContainerCannotExtendItself(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityContainerCannotExtendItself, p0);
        }

        /// <summary>
        ///     A string like "Functions and function imports that can be composed must declare a return type."
        /// </summary>
        internal static string ComposableFunctionOrFunctionImportMustDeclareReturnType
        {
            get { return EntityRes.GetString(EntityRes.ComposableFunctionOrFunctionImportMustDeclareReturnType); }
        }

        /// <summary>
        ///     A string like "Functions that cannot be composed must not declare a return type."
        /// </summary>
        internal static string NonComposableFunctionMustNotDeclareReturnType
        {
            get { return EntityRes.GetString(EntityRes.NonComposableFunctionMustNotDeclareReturnType); }
        }

        /// <summary>
        ///     A string like "Functions declaring command text cannot be composed."
        /// </summary>
        internal static string CommandTextFunctionsNotComposable
        {
            get { return EntityRes.GetString(EntityRes.CommandTextFunctionsNotComposable); }
        }

        /// <summary>
        ///     A string like "Functions declaring command text cannot also declare a store function name."
        /// </summary>
        internal static string CommandTextFunctionsCannotDeclareStoreFunctionName
        {
            get { return EntityRes.GetString(EntityRes.CommandTextFunctionsCannotDeclareStoreFunctionName); }
        }

        /// <summary>
        ///     A string like "Functions that cannot be composed may not set the aggregate or built-in function attributes."
        /// </summary>
        internal static string NonComposableFunctionHasDisallowedAttribute
        {
            get { return EntityRes.GetString(EntityRes.NonComposableFunctionHasDisallowedAttribute); }
        }

        /// <summary>
        ///     A string like "The DefiningQuery element is empty. Add the query text to the DefiningQuery element."
        /// </summary>
        internal static string EmptyDefiningQuery
        {
            get { return EntityRes.GetString(EntityRes.EmptyDefiningQuery); }
        }

        /// <summary>
        ///     A string like "The CommandText element is empty. Add the command text to the CommandText element."
        /// </summary>
        internal static string EmptyCommandText
        {
            get { return EntityRes.GetString(EntityRes.EmptyCommandText); }
        }

        /// <summary>
        ///     A string like "Function '{0}' with the same {1} space type parameters already exists. Make sure that function overloads are not ambiguous."
        /// </summary>
        internal static string AmbiguousFunctionOverload(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.AmbiguousFunctionOverload, p0, p1);
        }

        /// <summary>
        ///     A string like "Function '{0}' and {1} space type '{0}' cannot have the same fully qualified name."
        /// </summary>
        internal static string AmbiguousFunctionAndType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.AmbiguousFunctionAndType, p0, p1);
        }

        /// <summary>
        ///     A string like "A cycle was detected in the type hierarchy of '{0}'."
        /// </summary>
        internal static string CycleInTypeHierarchy(object p0)
        {
            return EntityRes.GetString(EntityRes.CycleInTypeHierarchy, p0);
        }

        /// <summary>
        ///     A string like "The Provider Manifest is incorrect."
        /// </summary>
        internal static string IncorrectProviderManifest
        {
            get { return EntityRes.GetString(EntityRes.IncorrectProviderManifest); }
        }

        /// <summary>
        ///     A string like "The function import '{0}' cannot have ComplexType ReturnType '{1}' and an EntitySet specified at the same time."
        /// </summary>
        internal static string ComplexTypeAsReturnTypeAndDefinedEntitySet(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ComplexTypeAsReturnTypeAndDefinedEntitySet, p0, p1);
        }

        /// <summary>
        ///     A string like "Nested ComplexType property '{0}' in the ReturnType '{1}' of the function '{2}' is not supported, please consider flattening the nested ComplexType property."
        /// </summary>
        internal static string ComplexTypeAsReturnTypeAndNestedComplexProperty(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.ComplexTypeAsReturnTypeAndNestedComplexProperty, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Facets cannot be specified for non-scalar type '{0}'."
        /// </summary>
        internal static string FacetsOnNonScalarType(object p0)
        {
            return EntityRes.GetString(EntityRes.FacetsOnNonScalarType, p0);
        }

        /// <summary>
        ///     A string like "Facet declaration requires type attribute declaration."
        /// </summary>
        internal static string FacetDeclarationRequiresTypeAttribute
        {
            get { return EntityRes.GetString(EntityRes.FacetDeclarationRequiresTypeAttribute); }
        }

        /// <summary>
        ///     A string like "Type declaration missing for element."
        /// </summary>
        internal static string TypeMustBeDeclared
        {
            get { return EntityRes.GetString(EntityRes.TypeMustBeDeclared); }
        }

        /// <summary>
        ///     A string like "RowType element must have at least one property element."
        /// </summary>
        internal static string RowTypeWithoutProperty
        {
            get { return EntityRes.GetString(EntityRes.RowTypeWithoutProperty); }
        }

        /// <summary>
        ///     A string like "Type must be declared through attribute or sub-element, but not both."
        /// </summary>
        internal static string TypeDeclaredAsAttributeAndElement
        {
            get { return EntityRes.GetString(EntityRes.TypeDeclaredAsAttributeAndElement); }
        }

        /// <summary>
        ///     A string like "ReferenceType element can only refer to an EntityType. '{0}' is not declared as an EntityType."
        /// </summary>
        internal static string ReferenceToNonEntityType(object p0)
        {
            return EntityRes.GetString(EntityRes.ReferenceToNonEntityType, p0);
        }

        /// <summary>
        ///     A string like "The '{0}' namespace is reserved for the Entity Framework code generation."
        /// </summary>
        internal static string NoCodeGenNamespaceInStructuralAnnotation(object p0)
        {
            return EntityRes.GetString(EntityRes.NoCodeGenNamespaceInStructuralAnnotation, p0);
        }

        /// <summary>
        ///     A string like "All artifacts loaded into an ItemCollection must have the same version. Multiple versions were encountered."
        /// </summary>
        internal static string CannotLoadDifferentVersionOfSchemaInTheSameItemCollection
        {
            get { return EntityRes.GetString(EntityRes.CannotLoadDifferentVersionOfSchemaInTheSameItemCollection); }
        }

        /// <summary>
        ///     A string like "The specified type cannot be used as the underlying type of an enumeration type."
        /// </summary>
        internal static string InvalidEnumUnderlyingType
        {
            get { return EntityRes.GetString(EntityRes.InvalidEnumUnderlyingType); }
        }

        /// <summary>
        ///     A string like "Enumeration members have to have unique names."
        /// </summary>
        internal static string DuplicateEnumMember
        {
            get { return EntityRes.GetString(EntityRes.DuplicateEnumMember); }
        }

        /// <summary>
        ///     A string like "The value of the calculated enumeration type member is not valid according to its data type 'http://www.w3.org/2001/XMLSchema:long'."
        /// </summary>
        internal static string CalculatedEnumValueOutOfRange
        {
            get { return EntityRes.GetString(EntityRes.CalculatedEnumValueOutOfRange); }
        }

        /// <summary>
        ///     A string like "The value '{0}' of the enumeration type member '{1}' cannot be converted to '{2}' type."
        /// </summary>
        internal static string EnumMemberValueOutOfItsUnderylingTypeRange(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.EnumMemberValueOutOfItsUnderylingTypeRange, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Currently, spatial types are only supported when used in CSDL files that have the UseStrongSpatialTypes annotation with a false value on their root Schema element."
        /// </summary>
        internal static string SpatialWithUseStrongSpatialTypesFalse
        {
            get { return EntityRes.GetString(EntityRes.SpatialWithUseStrongSpatialTypesFalse); }
        }

        /// <summary>
        ///     A string like "You must specify a valid projection list."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidProjectionList
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidProjectionList); }
        }

        /// <summary>
        ///     A string like "You must specify a valid key list for sorting the results."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidSortKeyList
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidSortKeyList); }
        }

        /// <summary>
        ///     A string like "You must specify a valid key list for grouping the results."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidGroupKeyList
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidGroupKeyList); }
        }

        /// <summary>
        ///     A string like "You must specify a valid skip count."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidSkipCount
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidSkipCount); }
        }

        /// <summary>
        ///     A string like "You must specify a valid result count."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidTopCount
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidTopCount); }
        }

        /// <summary>
        ///     A string like "You must specify a valid predicate for filtering the results."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidFilterPredicate
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidFilterPredicate); }
        }

        /// <summary>
        ///     A string like "'{0}' is not a valid type for type filtering operations. Type filtering is only valid on entity types and complex types."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidResultType(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidResultType, p0);
        }

        /// <summary>
        ///     A string like "The specified ObjectQuery is not valid for this operation because it is associated with a different ObjectContext."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_InvalidQueryArgument
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_InvalidQueryArgument); }
        }

        /// <summary>
        ///     A string like "Query builder methods are not supported for LINQ to Entities queries. For more information, see the Entity Framework documentation."
        /// </summary>
        internal static string ObjectQuery_QueryBuilder_NotSupportedLinqSource
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_QueryBuilder_NotSupportedLinqSource); }
        }

        /// <summary>
        ///     A string like "The command text for an ObjectQuery instance cannot be empty."
        /// </summary>
        internal static string ObjectQuery_InvalidEmptyQuery
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_InvalidEmptyQuery); }
        }

        /// <summary>
        ///     A string like "A connection must be specified before the query can be executed."
        /// </summary>
        internal static string ObjectQuery_InvalidConnection
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_InvalidConnection); }
        }

        /// <summary>
        ///     A string like "The specified query name '{0}' is not valid. Query names must begin with a letter and can only contain letters, numbers, and underscores."
        /// </summary>
        internal static string ObjectQuery_InvalidQueryName(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectQuery_InvalidQueryName, p0);
        }

        /// <summary>
        ///     A string like "The result type of the query could not be determined because the required metadata is missing."
        /// </summary>
        internal static string ObjectQuery_UnableToMapResultType
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_UnableToMapResultType); }
        }

        /// <summary>
        ///     A string like "The array type '{0}' cannot be initialized in a query result. Consider using '{1}' instead."
        /// </summary>
        internal static string ObjectQuery_UnableToMaterializeArray(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectQuery_UnableToMaterializeArray, p0, p1);
        }

        /// <summary>
        ///     A string like "The collection in the projection is of type '{0}'. For a collection to be materialized to a projection, it must be of type ICollection<T>, IList
        ///                                                                                                                                                              <T>, ISet
        ///                                                                                                                                                                  <T>or of a concrete type that implements ICollection
        ///                                                                                                                                                                      <T>and has a parameterless constructor."
        /// </summary>
        internal static string ObjectQuery_UnableToMaterializeArbitaryProjectionType(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectQuery_UnableToMaterializeArbitaryProjectionType, p0);
        }

        /// <summary>
        ///     A string like "The specified parameter name '{0}' is not valid. Parameter names must begin with a letter and can only contain letters, numbers, and underscores."
        /// </summary>
        internal static string ObjectParameter_InvalidParameterName(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectParameter_InvalidParameterName, p0);
        }

        /// <summary>
        ///     A string like "The specified parameter type '{0}' is not valid. Only scalar types, such as System.Int32, System.Decimal, System.DateTime, and System.Guid, are supported."
        /// </summary>
        internal static string ObjectParameter_InvalidParameterType(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectParameter_InvalidParameterType, p0);
        }

        /// <summary>
        ///     A string like "A parameter named '{0}' was not found in the parameter collection."
        /// </summary>
        internal static string ObjectParameterCollection_ParameterNameNotFound(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectParameterCollection_ParameterNameNotFound, p0);
        }

        /// <summary>
        ///     A string like "A parameter '{0}' already exists in the parameter collection. Parameters must be unique in the parameter collection."
        /// </summary>
        internal static string ObjectParameterCollection_ParameterAlreadyExists(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectParameterCollection_ParameterAlreadyExists, p0);
        }

        /// <summary>
        ///     A string like "A parameter named '{0}' already exists in the parameter collection. Parameter names must be unique in the parameter collection."
        /// </summary>
        internal static string ObjectParameterCollection_DuplicateParameterName(object p0)
        {
            return EntityRes.GetString(EntityRes.ObjectParameterCollection_DuplicateParameterName, p0);
        }

        /// <summary>
        ///     A string like "Parameters cannot be added or removed from the parameter collection, and the parameter collection cannot be cleared after a query has been evaluated or its trace string has been retrieved.  "
        /// </summary>
        internal static string ObjectParameterCollection_ParametersLocked
        {
            get { return EntityRes.GetString(EntityRes.ObjectParameterCollection_ParametersLocked); }
        }

        /// <summary>
        ///     A string like "The provider returned null for the informationType '{0}'."
        /// </summary>
        internal static string ProviderReturnedNullForGetDbInformation(object p0)
        {
            return EntityRes.GetString(EntityRes.ProviderReturnedNullForGetDbInformation, p0);
        }

        /// <summary>
        ///     A string like "The provider returned null from CreateCommandDefinition."
        /// </summary>
        internal static string ProviderReturnedNullForCreateCommandDefinition
        {
            get { return EntityRes.GetString(EntityRes.ProviderReturnedNullForCreateCommandDefinition); }
        }

        /// <summary>
        ///     A string like "The provider did not return a ProviderManifest instance."
        /// </summary>
        internal static string ProviderDidNotReturnAProviderManifest
        {
            get { return EntityRes.GetString(EntityRes.ProviderDidNotReturnAProviderManifest); }
        }

        /// <summary>
        ///     A string like "The provider did not return a ProviderManifestToken string."
        /// </summary>
        internal static string ProviderDidNotReturnAProviderManifestToken
        {
            get { return EntityRes.GetString(EntityRes.ProviderDidNotReturnAProviderManifestToken); }
        }

        /// <summary>
        ///     A string like "The provider did not return a DbSpatialServices instance."
        /// </summary>
        internal static string ProviderDidNotReturnSpatialServices
        {
            get { return EntityRes.GetString(EntityRes.ProviderDidNotReturnSpatialServices); }
        }

        /// <summary>
        ///     A string like "This provider does not support the specified command tree. EntityClient should be used to create a command definition from this command tree."
        /// </summary>
        internal static string ProviderRequiresStoreCommandTree
        {
            get { return EntityRes.GetString(EntityRes.ProviderRequiresStoreCommandTree); }
        }

        /// <summary>
        ///     A string like "Because the underlying provider had overridden DbProviderManifest.SupportsEscapingLikeArgument to return true, the DbProviderManifest.EscapeLikeArgument method must also be implemented by the provider."
        /// </summary>
        internal static string ProviderShouldOverrideEscapeLikeArgument
        {
            get { return EntityRes.GetString(EntityRes.ProviderShouldOverrideEscapeLikeArgument); }
        }

        /// <summary>
        ///     A string like "The underlying provider returned null when trying to escape the specified string."
        /// </summary>
        internal static string ProviderEscapeLikeArgumentReturnedNull
        {
            get { return EntityRes.GetString(EntityRes.ProviderEscapeLikeArgumentReturnedNull); }
        }

        /// <summary>
        ///     A string like "The provider did not create a CommandDefinition."
        /// </summary>
        internal static string ProviderDidNotCreateACommandDefinition
        {
            get { return EntityRes.GetString(EntityRes.ProviderDidNotCreateACommandDefinition); }
        }

        /// <summary>
        ///     A string like "CreateDatabaseScript is not supported by the provider."
        /// </summary>
        internal static string ProviderDoesNotSupportCreateDatabaseScript
        {
            get { return EntityRes.GetString(EntityRes.ProviderDoesNotSupportCreateDatabaseScript); }
        }

        /// <summary>
        ///     A string like "CreateDatabase is not supported by the provider."
        /// </summary>
        internal static string ProviderDoesNotSupportCreateDatabase
        {
            get { return EntityRes.GetString(EntityRes.ProviderDoesNotSupportCreateDatabase); }
        }

        /// <summary>
        ///     A string like "DatabaseExists is not supported by the provider."
        /// </summary>
        internal static string ProviderDoesNotSupportDatabaseExists
        {
            get { return EntityRes.GetString(EntityRes.ProviderDoesNotSupportDatabaseExists); }
        }

        /// <summary>
        ///     A string like "DeleteDatabase is not supported by the provider."
        /// </summary>
        internal static string ProviderDoesNotSupportDeleteDatabase
        {
            get { return EntityRes.GetString(EntityRes.ProviderDoesNotSupportDeleteDatabase); }
        }

        /// <summary>
        ///     A string like "The specified DbGeography value is not compatible with this spatial services implementation."
        /// </summary>
        internal static string Spatial_GeographyValueNotCompatibleWithSpatialServices
        {
            get { return EntityRes.GetString(EntityRes.Spatial_GeographyValueNotCompatibleWithSpatialServices); }
        }

        /// <summary>
        ///     A string like "The specified DbGeometry value is not compatible with this spatial services implementation."
        /// </summary>
        internal static string Spatial_GeometryValueNotCompatibleWithSpatialServices
        {
            get { return EntityRes.GetString(EntityRes.Spatial_GeometryValueNotCompatibleWithSpatialServices); }
        }

        /// <summary>
        ///     A string like "The specified provider value is not compatible with this spatial services implementation."
        /// </summary>
        internal static string Spatial_ProviderValueNotCompatibleWithSpatialServices
        {
            get { return EntityRes.GetString(EntityRes.Spatial_ProviderValueNotCompatibleWithSpatialServices); }
        }

        /// <summary>
        ///     A string like "The WellKnownValue property is intended to support serialization and deserialization and should not be set directly."
        /// </summary>
        internal static string Spatial_WellKnownValueSerializationPropertyNotDirectlySettable
        {
            get { return EntityRes.GetString(EntityRes.Spatial_WellKnownValueSerializationPropertyNotDirectlySettable); }
        }

        /// <summary>
        ///     A string like "The connection name in the connection string."
        /// </summary>
        internal static string EntityConnectionString_Name
        {
            get { return EntityRes.GetString(EntityRes.EntityConnectionString_Name); }
        }

        /// <summary>
        ///     A string like "The underlying provider invariant name in the connection string."
        /// </summary>
        internal static string EntityConnectionString_Provider
        {
            get { return EntityRes.GetString(EntityRes.EntityConnectionString_Provider); }
        }

        /// <summary>
        ///     A string like "The metadata locations in the connection string."
        /// </summary>
        internal static string EntityConnectionString_Metadata
        {
            get { return EntityRes.GetString(EntityRes.EntityConnectionString_Metadata); }
        }

        /// <summary>
        ///     A string like "The inner connection string in the connection string."
        /// </summary>
        internal static string EntityConnectionString_ProviderConnectionString
        {
            get { return EntityRes.GetString(EntityRes.EntityConnectionString_ProviderConnectionString); }
        }

        /// <summary>
        ///     A string like "Context"
        /// </summary>
        internal static string EntityDataCategory_Context
        {
            get { return EntityRes.GetString(EntityRes.EntityDataCategory_Context); }
        }

        /// <summary>
        ///     A string like "Named ConnectionString"
        /// </summary>
        internal static string EntityDataCategory_NamedConnectionString
        {
            get { return EntityRes.GetString(EntityRes.EntityDataCategory_NamedConnectionString); }
        }

        /// <summary>
        ///     A string like "Source"
        /// </summary>
        internal static string EntityDataCategory_Source
        {
            get { return EntityRes.GetString(EntityRes.EntityDataCategory_Source); }
        }

        /// <summary>
        ///     A string like "The result type of the query is neither an EntityType nor a CollectionType with an entity element type. An Include path can only be specified for a query with one of these result types."
        /// </summary>
        internal static string ObjectQuery_Span_IncludeRequiresEntityOrEntityCollection
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_Span_IncludeRequiresEntityOrEntityCollection); }
        }

        /// <summary>
        ///     A string like "A specified Include path is not valid. The EntityType '{0}' does not declare a navigation property with the name '{1}'."
        /// </summary>
        internal static string ObjectQuery_Span_NoNavProp(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ObjectQuery_Span_NoNavProp, p0, p1);
        }

        /// <summary>
        ///     A string like "There was an error parsing the Include path. An empty navigation property was found."
        /// </summary>
        internal static string ObjectQuery_Span_SpanPathSyntaxError
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_Span_SpanPathSyntaxError); }
        }

        /// <summary>
        ///     A string like "The path consists only of white space."
        /// </summary>
        internal static string ObjectQuery_Span_WhiteSpacePath
        {
            get { return EntityRes.GetString(EntityRes.ObjectQuery_Span_WhiteSpacePath); }
        }

        /// <summary>
        ///     A string like "The entity wrapper stored in the proxy does not reference the same proxy."
        /// </summary>
        internal static string EntityProxyTypeInfo_ProxyHasWrongWrapper
        {
            get { return EntityRes.GetString(EntityRes.EntityProxyTypeInfo_ProxyHasWrongWrapper); }
        }

        /// <summary>
        ///     A string like "The property '{0}' on type '{1}' cannot be set because the collection is already set to an EntityCollection."
        /// </summary>
        internal static string EntityProxyTypeInfo_CannotSetEntityCollectionProperty(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EntityProxyTypeInfo_CannotSetEntityCollectionProperty, p0, p1);
        }

        /// <summary>
        ///     A string like "There is no metadata information available for the proxy type for '{0}'. This exception can be caused when a proxy type for an entity is detached from an ObjectContext. See InnerException for details."
        /// </summary>
        internal static string EntityProxyTypeInfo_ProxyMetadataIsUnavailable(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityProxyTypeInfo_ProxyMetadataIsUnavailable, p0);
        }

        /// <summary>
        ///     A string like "There is already a generated proxy type for the object layer type '{0}'. This occurs when the same object layer type is mapped by two or more different models in an AppDomain."
        /// </summary>
        internal static string EntityProxyTypeInfo_DuplicateOSpaceType(object p0)
        {
            return EntityRes.GetString(EntityRes.EntityProxyTypeInfo_DuplicateOSpaceType, p0);
        }

        /// <summary>
        ///     A string like "All 'EdmMember' instances must be a valid member of the EdmType."
        /// </summary>
        internal static string InvalidEdmMemberInstance
        {
            get { return EntityRes.GetString(EntityRes.InvalidEdmMemberInstance); }
        }

        /// <summary>
        ///     A string like "No Entity Framework provider found for '{0}' ADO.NET provider. Make sure the provider is registered in the 'entityFramework' section of the application config file. See http://go.microsoft.com/fwlink/?LinkId=260882 for more information."
        /// </summary>
        internal static string EF6Providers_NoProviderFound(object p0)
        {
            return EntityRes.GetString(EntityRes.EF6Providers_NoProviderFound, p0);
        }

        /// <summary>
        ///     A string like "The Entity Framework provider type '{0}' for the '{1}' ADO.NET provider could not be loaded. Make sure the provider assembly is available to the running application. See http://go.microsoft.com/fwlink/?LinkId=260882 for more information."
        /// </summary>
        internal static string EF6Providers_ProviderTypeMissing(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EF6Providers_ProviderTypeMissing, p0, p1);
        }

        /// <summary>
        ///     A string like "The Entity Framework provider type '{0}' did not have a static property or field named 'Instance'. Entity Framework providers must declare a static property or field named 'Instance' that returns the Singleton instance of the provider."
        /// </summary>
        internal static string EF6Providers_InstanceMissing(object p0)
        {
            return EntityRes.GetString(EntityRes.EF6Providers_InstanceMissing, p0);
        }

        /// <summary>
        ///     A string like "The 'Instance' member of the Entity Framework provider type '{0}' did not return an object that extends from 'System.Data.Entity.Core.Common.DbProviderServices'. Entity Framework providers must extend from this class and the 'Instance' member must return the Singleton instance of the provider."
        /// </summary>
        internal static string EF6Providers_NotDbProviderServices(object p0)
        {
            return EntityRes.GetString(EntityRes.EF6Providers_NotDbProviderServices, p0);
        }

        /// <summary>
        ///     A string like "The provider for invariant name '{0}' is specified multiple times in the application configuration. The invariant name must be unique for each configured provider."
        /// </summary>
        internal static string ProviderInvariantRepeatedInConfig(object p0)
        {
            return EntityRes.GetString(EntityRes.ProviderInvariantRepeatedInConfig, p0);
        }

        /// <summary>
        ///     A string like "No name was passed to the IDbDependencyResolver.Get method. The provider invariant name must be supplied when attempting to resolve a DbProviderServices dependency."
        /// </summary>
        internal static string ProviderInvariantNotPassedToResolver
        {
            get { return EntityRes.GetString(EntityRes.ProviderInvariantNotPassedToResolver); }
        }

        /// <summary>
        ///     A string like "The default DbConfiguration instance was used by the Entity Framework before an attempt was made to set an instance of '{0}'. The '{0}' instance must be set at application start before using any Entity Framework features or must be registered in the application's config file. See http://go.microsoft.com/fwlink/?LinkId=260883 for more information."
        /// </summary>
        internal static string DefaultConfigurationUsedBeforeSet(object p0)
        {
            return EntityRes.GetString(EntityRes.DefaultConfigurationUsedBeforeSet, p0);
        }

        /// <summary>
        ///     A string like "An instance of '{0}' cannot be set because an instance of '{1}' is already being used. The DbConfiguration type to use cannot be changed once it has been set. See http://go.microsoft.com/fwlink/?LinkId=260883 for more information."
        /// </summary>
        internal static string ConfigurationSetTwice(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.ConfigurationSetTwice, p0, p1);
        }

        /// <summary>
        ///     A string like "The default DbConfiguration instance was used by the Entity Framework before the '{0}' type was discovered. An instance of '{0}' must be set at application start before using any Entity Framework features or must be registered in the application's config file. See http://go.microsoft.com/fwlink/?LinkId=260883 for more information."
        /// </summary>
        internal static string ConfigurationNotDiscovered(object p0)
        {
            return EntityRes.GetString(EntityRes.ConfigurationNotDiscovered, p0);
        }

        /// <summary>
        ///     A string like "An instance of '{0}' was set but this type was not discovered in the same assembly as the '{1}' context. A DbConfiguration type can be set in the config file, or it must be part of the same assembly as the DbContext type. See http://go.microsoft.com/fwlink/?LinkId=260883 for more information."
        /// </summary>
        internal static string SetConfigurationNotDiscovered(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.SetConfigurationNotDiscovered, p0, p1);
        }

        /// <summary>
        ///     A string like "The assembly {0} contains more than one type derived from {1}. Either define the DbConfiguration type to use in the application's config file or ensure that the assembly contains at most one type derived from {1}."
        /// </summary>
        internal static string MultipleConfigsInAssembly(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.MultipleConfigsInAssembly, p0, p1);
        }

        /// <summary>
        ///     A string like "The type '{0}' does not extend from '{1}'. Migrations configuration types must extend from '{1}'."
        /// </summary>
        internal static string CreateInstance_BadMigrationsConfigurationType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.CreateInstance_BadMigrationsConfigurationType, p0, p1);
        }

        /// <summary>
        ///     A string like "The type '{0}' does not extend from '{1}'. Migrations SQL generator implementations must extend from '{1}'."
        /// </summary>
        internal static string CreateInstance_BadSqlGeneratorType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.CreateInstance_BadSqlGeneratorType, p0, p1);
        }

        /// <summary>
        ///     A string like "Failed to create instance of type '{0}'. The type must have a public parameterless constructor."
        /// </summary>
        internal static string CreateInstance_NoParameterlessConstructor(object p0)
        {
            return EntityRes.GetString(EntityRes.CreateInstance_NoParameterlessConstructor, p0);
        }

        /// <summary>
        ///     A string like "Failed to create instance of type '{0}'. The type must not be abstract."
        /// </summary>
        internal static string CreateInstance_AbstractType(object p0)
        {
            return EntityRes.GetString(EntityRes.CreateInstance_AbstractType, p0);
        }

        /// <summary>
        ///     A string like "Failed to create instance of type '{0}'. The type must not be generic."
        /// </summary>
        internal static string CreateInstance_GenericType(object p0)
        {
            return EntityRes.GetString(EntityRes.CreateInstance_GenericType, p0);
        }

        /// <summary>
        ///     A string like "The Migrations SQL generator type '{0}' for the '{1}' ADO.NET provider could not be loaded. Make sure the assembly is available to the running application."
        /// </summary>
        internal static string SqlGeneratorTypeMissing(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.SqlGeneratorTypeMissing, p0, p1);
        }

        /// <summary>
        ///     A string like "The call to DbConfiguration.{0} failed because the configuration is locked. The protected methods and properties of DbConfiguration are intended to be called only from the constructor of a class derived from DbConfiguration and cannot be called after the DbConfiguration object is in use."
        /// </summary>
        internal static string ConfigurationLocked(object p0)
        {
            return EntityRes.GetString(EntityRes.ConfigurationLocked, p0);
        }

        /// <summary>
        ///     A string like "To enable migrations for '{0}', use Enable-Migrations -ContextTypeName {0}."
        /// </summary>
        internal static string EnableMigrationsForContext(object p0)
        {
            return EntityRes.GetString(EntityRes.EnableMigrationsForContext, p0);
        }

        /// <summary>
        ///     A string like "More than one context type was found in the assembly '{0}'."
        /// </summary>
        internal static string EnableMigrations_MultipleContexts(object p0)
        {
            return EntityRes.GetString(EntityRes.EnableMigrations_MultipleContexts, p0);
        }

        /// <summary>
        ///     A string like "More than one context type '{0}' was found in the assembly '{1}'. Specify the fully qualified name of the context."
        /// </summary>
        internal static string EnableMigrations_MultipleContextsWithName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EnableMigrations_MultipleContextsWithName, p0, p1);
        }

        /// <summary>
        ///     A string like "No context type was found in the assembly '{0}'."
        /// </summary>
        internal static string EnableMigrations_NoContext(object p0)
        {
            return EntityRes.GetString(EntityRes.EnableMigrations_NoContext, p0);
        }

        /// <summary>
        ///     A string like "The context type '{0}' was not found in the assembly '{1}'."
        /// </summary>
        internal static string EnableMigrations_NoContextWithName(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.EnableMigrations_NoContextWithName, p0, p1);
        }

        /// <summary>
        ///     A string like "Sequence contains more than one element"
        /// </summary>
        internal static string MoreThanOneElement
        {
            get { return EntityRes.GetString(EntityRes.MoreThanOneElement); }
        }

        /// <summary>
        ///     A string like "The source IQueryable doesn't implement IDbAsyncEnumerable{0}."
        /// </summary>
        internal static string IQueryable_Not_Async(object p0)
        {
            return EntityRes.GetString(EntityRes.IQueryable_Not_Async, p0);
        }

        /// <summary>
        ///     A string like "The provider for the source IQueryable doesn't implement IDbAsyncQueryProvider."
        /// </summary>
        internal static string IQueryable_Provider_Not_Async
        {
            get { return EntityRes.GetString(EntityRes.IQueryable_Provider_Not_Async); }
        }

        /// <summary>
        ///     A string like "Sequence contains no elements."
        /// </summary>
        internal static string EmptySequence
        {
            get { return EntityRes.GetString(EntityRes.EmptySequence); }
        }

        /// <summary>
        ///     A string like "Auto-migrating default schema changes is not supported. Please use code-based migrations to migrate default schema changes."
        /// </summary>
        internal static string UnableToAutoMigrateDefaultSchema
        {
            get { return EntityRes.GetString(EntityRes.UnableToAutoMigrateDefaultSchema); }
        }
    }

    /// <summary>
    ///     Strongly-typed and parameterized exception factory.
    /// </summary>
    [GeneratedCode("Resources.tt", "1.0.0.0")]
    internal static class Error
    {
        /// <summary>
        ///     Migrations.Infrastructure.AutomaticDataLossException with message like "Automatic migration was not applied because it would result in data loss."
        /// </summary>
        internal static Exception AutomaticDataLoss()
        {
            return new AutomaticDataLossException(Strings.AutomaticDataLoss);
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "Cannot scaffold the next migration because the target database was created with a version of Code First earlier than EF 4.3 and does not contain the migrations history table. To start using migrations against this database, ensure the current model is compatible with the target database and execute the migrations Update process. (In Visual Studio you can use the Update-Database command from Package Manager Console to execute the migrations Update process)."
        /// </summary>
        internal static Exception MetadataOutOfDate()
        {
            return new MigrationsException(Strings.MetadataOutOfDate);
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "The specified target migration '{0}' does not exist. Ensure that target migration refers to an existing migration id."
        /// </summary>
        internal static Exception MigrationNotFound(object p0)
        {
            return new MigrationsException(Strings.MigrationNotFound(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "The Foreign Key on table '{0}' with columns '{1}' could not be created because the principal key columns could not be determined. Use the AddForeignKey fluent API to fully specify the Foreign Key."
        /// </summary>
        internal static Exception PartialFkOperation(object p0, object p1)
        {
            return new MigrationsException(Strings.PartialFkOperation(p0, p1));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "'{0}' is not a valid target migration. When targeting a previously applied automatic migration, use the full migration id including timestamp."
        /// </summary>
        internal static Exception AutoNotValidTarget(object p0)
        {
            return new MigrationsException(Strings.AutoNotValidTarget(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "'{0}' is not a valid migration. Explicit migrations must be used for both source and target when scripting the upgrade between them."
        /// </summary>
        internal static Exception AutoNotValidForScriptWindows(object p0)
        {
            return new MigrationsException(Strings.AutoNotValidForScriptWindows(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "The target context '{0}' is not constructible. Add a default constructor or provide an implementation of IDbContextFactory."
        /// </summary>
        internal static Exception ContextNotConstructible(object p0)
        {
            return new MigrationsException(Strings.ContextNotConstructible(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "The specified migration name '{0}' is ambiguous. Specify the full migration id including timestamp instead."
        /// </summary>
        internal static Exception AmbiguousMigrationName(object p0)
        {
            return new MigrationsException(Strings.AmbiguousMigrationName(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.AutomaticMigrationsDisabledException with message like "Unable to update database to match the current model because there are pending changes and automatic migration is disabled. Either write the pending model changes to a code-based migration or enable automatic migration. Set DbMigrationsConfiguration.AutomaticMigrationsEnabled to true to enable automatic migration."
        /// </summary>
        internal static Exception AutomaticDisabledException()
        {
            return new AutomaticMigrationsDisabledException(Strings.AutomaticDisabledException);
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "Scripting the downgrade between two specified migrations is not supported."
        /// </summary>
        internal static Exception DownScriptWindowsNotSupported()
        {
            return new MigrationsException(Strings.DownScriptWindowsNotSupported);
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "The migrations configuration type '{0}' was not be found in the assembly '{1}'."
        /// </summary>
        internal static Exception AssemblyMigrator_NoConfigurationWithName(object p0, object p1)
        {
            return new MigrationsException(Strings.AssemblyMigrator_NoConfigurationWithName(p0, p1));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "More than one migrations configuration type '{0}' was found in the assembly '{1}'. Specify the fully qualified name of the one to use."
        /// </summary>
        internal static Exception AssemblyMigrator_MultipleConfigurationsWithName(object p0, object p1)
        {
            return new MigrationsException(Strings.AssemblyMigrator_MultipleConfigurationsWithName(p0, p1));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "No migrations configuration type was found in the assembly '{0}'. (In Visual Studio you can use the Enable-Migrations command from Package Manager Console to add a migrations configuration)."
        /// </summary>
        internal static Exception AssemblyMigrator_NoConfiguration(object p0)
        {
            return new MigrationsException(Strings.AssemblyMigrator_NoConfiguration(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "More than one migrations configuration type was found in the assembly '{0}'. Specify the name of the one to use."
        /// </summary>
        internal static Exception AssemblyMigrator_MultipleConfigurations(object p0)
        {
            return new MigrationsException(Strings.AssemblyMigrator_MultipleConfigurations(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "Direct column renaming is not supported by SQL Server Compact. To rename a column in SQL Server Compact, you will need to recreate it."
        /// </summary>
        internal static Exception SqlCeColumnRenameNotSupported()
        {
            return new MigrationsException(Strings.SqlCeColumnRenameNotSupported);
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "In VB.NET projects, the migrations namespace '{0}' must be under the root namespace '{1}'. Update the migrations project's root namespace to allow classes under the migrations namespace to be added."
        /// </summary>
        internal static Exception MigrationsNamespaceNotUnderRootNamespace(object p0, object p1)
        {
            return new MigrationsException(Strings.MigrationsNamespaceNotUnderRootNamespace(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Unable to call public, instance method AddOrUpdate on derived IDbSet<T>type '{0}'. Method not found."
        /// </summary>
        internal static Exception UnableToDispatchAddOrUpdate(object p0)
        {
            return new InvalidOperationException(Strings.UnableToDispatchAddOrUpdate(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "No MigrationSqlGenerator found for provider '{0}'. Use the SetSqlGenerator method in the target migrations configuration class to register additional SQL generators."
        /// </summary>
        internal static Exception NoSqlGeneratorForProvider(object p0)
        {
            return new MigrationsException(Strings.NoSqlGeneratorForProvider(p0));
        }

        /// <summary>
        ///     ArgumentException with message like "The argument '{0}' cannot be null, empty or contain only white space."
        /// </summary>
        internal static Exception ArgumentIsNullOrWhitespace(object p0)
        {
            return new ArgumentException(Strings.ArgumentIsNullOrWhitespace(p0));
        }

        /// <summary>
        ///     ArgumentException with message like "The argument property '{0}' cannot be null."
        /// </summary>
        internal static Exception ArgumentPropertyIsNull(object p0)
        {
            return new ArgumentException(Strings.ArgumentPropertyIsNull(p0));
        }

        /// <summary>
        ///     ArgumentException with message like "The precondition '{0}' failed. {1}"
        /// </summary>
        internal static Exception PreconditionFailed(object p0, object p1)
        {
            return new ArgumentException(Strings.PreconditionFailed(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' has already been configured as a complex type. It cannot be reconfigured as an entity type."
        /// </summary>
        internal static Exception EntityTypeConfigurationMismatch(object p0)
        {
            return new InvalidOperationException(Strings.EntityTypeConfigurationMismatch(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' has already been configured as an entity type. It cannot be reconfigured as a complex type."
        /// </summary>
        internal static Exception ComplexTypeConfigurationMismatch(object p0)
        {
            return new InvalidOperationException(Strings.ComplexTypeConfigurationMismatch(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The key component '{0}' is not a declared property on type '{1}'. Verify that it has not been explicitly excluded from the model and that it is a valid primitive property."
        /// </summary>
        internal static Exception KeyPropertyNotFound(object p0, object p1)
        {
            return new InvalidOperationException(Strings.KeyPropertyNotFound(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The foreign key component '{0}' is not a declared property on type '{1}'. Verify that it has not been explicitly excluded from the model and that it is a valid primitive property."
        /// </summary>
        internal static Exception ForeignKeyPropertyNotFound(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ForeignKeyPropertyNotFound(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The property '{0}' is not a declared property on type '{1}'. Verify that the property has not been explicitly excluded from the model by using the Ignore method or NotMappedAttribute data annotation. Make sure that it is a valid primitive property."
        /// </summary>
        internal static Exception PropertyNotFound(object p0, object p1)
        {
            return new InvalidOperationException(Strings.PropertyNotFound(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The navigation property '{0}' is not a declared property on type '{1}'. Verify that it has not been explicitly excluded from the model and that it is a valid navigation property."
        /// </summary>
        internal static Exception NavigationPropertyNotFound(object p0, object p1)
        {
            return new InvalidOperationException(Strings.NavigationPropertyNotFound(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The expression '{0}' is not a valid property expression. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'."
        /// </summary>
        internal static Exception InvalidPropertyExpression(object p0)
        {
            return new InvalidOperationException(Strings.InvalidPropertyExpression(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The expression '{0}' is not a valid property expression. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'. Use dotted paths for nested properties: C#: 't => t.MyProperty.MyProperty'  VB.Net: 'Function(t) t.MyProperty.MyProperty'."
        /// </summary>
        internal static Exception InvalidComplexPropertyExpression(object p0)
        {
            return new InvalidOperationException(Strings.InvalidComplexPropertyExpression(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The properties expression '{0}' is not valid. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'. When specifying multiple properties use an anonymous type: C#: 't => new {{ t.MyProperty1, t.MyProperty2 }}'  VB.Net: 'Function(t) New With {{ t.MyProperty1, t.MyProperty2 }}'."
        /// </summary>
        internal static Exception InvalidPropertiesExpression(object p0)
        {
            return new InvalidOperationException(Strings.InvalidPropertiesExpression(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The properties expression '{0}' is not valid. The expression should represent a property: C#: 't => t.MyProperty'  VB.Net: 'Function(t) t.MyProperty'. When specifying multiple properties use an anonymous type: C#: 't => new {{ t.MyProperty1, t.MyProperty2 }}'  VB.Net: 'Function(t) New With {{ t.MyProperty1, t.MyProperty2 }}'."
        /// </summary>
        internal static Exception InvalidComplexPropertiesExpression(object p0)
        {
            return new InvalidOperationException(Strings.InvalidComplexPropertiesExpression(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "A configuration for type '{0}' has already been added. To reference the existing configuration use the Entity<T>() or ComplexType
        ///                                                                                                                                                                   <T>() methods."
        /// </summary>
        internal static Exception DuplicateStructuralTypeConfiguration(object p0)
        {
            return new InvalidOperationException(Strings.DuplicateStructuralTypeConfiguration(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Conflicting configuration settings were specified for property '{0}' on type '{1}': {2}"
        /// </summary>
        internal static Exception ConflictingPropertyConfiguration(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.ConflictingPropertyConfiguration(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Conflicting configuration settings were specified for column '{0}' on table '{1}': {2}"
        /// </summary>
        internal static Exception ConflictingColumnConfiguration(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.ConflictingColumnConfiguration(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' was not mapped. Check that the type has not been explicitly excluded by using the Ignore method or NotMappedAttribute data annotation. Verify that the type was defined as a class, is not primitive, nested or generic, and does not inherit from ComplexObject."
        /// </summary>
        internal static Exception CodeFirstInvalidComplexType(object p0)
        {
            return new InvalidOperationException(Strings.CodeFirstInvalidComplexType(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' was not mapped. Check that the type has not been explicitly excluded by using the Ignore method or NotMappedAttribute data annotation. Verify that the type was defined as a class, is not primitive, nested or generic, and does not inherit from EntityObject."
        /// </summary>
        internal static Exception InvalidEntityType(object p0)
        {
            return new InvalidOperationException(Strings.InvalidEntityType(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The navigation property '{0}' declared on type '{1}' cannot be the inverse of itself."
        /// </summary>
        internal static Exception NavigationInverseItself(object p0, object p1)
        {
            return new InvalidOperationException(Strings.NavigationInverseItself(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting foreign keys."
        /// </summary>
        internal static Exception ConflictingConstraint(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ConflictingConstraint(p0, p1));
        }

        /// <summary>
        ///     MappingException with message like "Values of incompatible types ('{1}' and '{2}') were assigned to the '{0}' discriminator column. Values of the same type must be specified. To explicitly specify the type of the discriminator column use the HasColumnType method."
        /// </summary>
        internal static Exception ConflictingInferredColumnType(object p0, object p1, object p2)
        {
            return new MappingException(Strings.ConflictingInferredColumnType(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting mapping information."
        /// </summary>
        internal static Exception ConflictingMapping(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ConflictingMapping(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting cascade delete operations using 'WillCascadeOnDelete'."
        /// </summary>
        internal static Exception ConflictingCascadeDeleteOperation(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ConflictingCascadeDeleteOperation(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The navigation property '{0}' declared on type '{1}' has been configured with conflicting multiplicities."
        /// </summary>
        internal static Exception ConflictingMultiplicities(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ConflictingMultiplicities(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The MaxLengthAttribute on property '{0}' on type '{1} is not valid. The Length value must be greater than zero. Use MaxLength() without parameters to indicate that the string or array can have the maximum allowable length."
        /// </summary>
        internal static Exception MaxLengthAttributeConvention_InvalidMaxLength(object p0, object p1)
        {
            return new InvalidOperationException(Strings.MaxLengthAttributeConvention_InvalidMaxLength(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The StringLengthAttribute on property '{0}' on type '{1}' is not valid. The maximum length must be greater than zero. Use MaxLength() without parameters to indicate that the string or array can have the maximum allowable length."
        /// </summary>
        internal static Exception StringLengthAttributeConvention_InvalidMaximumLength(object p0, object p1)
        {
            return new InvalidOperationException(Strings.StringLengthAttributeConvention_InvalidMaximumLength(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Unable to determine composite primary key ordering for type '{0}'. Use the ColumnAttribute or the HasKey method to specify an order for composite primary keys."
        /// </summary>
        internal static Exception ModelGeneration_UnableToDetermineKeyOrder(object p0)
        {
            return new InvalidOperationException(Strings.ModelGeneration_UnableToDetermineKeyOrder(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The ForeignKeyAttribute on property '{0}' on type '{1}' is not valid. Name must not be empty."
        /// </summary>
        internal static Exception ForeignKeyAttributeConvention_EmptyKey(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ForeignKeyAttributeConvention_EmptyKey(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The ForeignKeyAttribute on property '{0}' on type '{1}' is not valid. The foreign key name '{2}' was not found on the dependent type '{3}'. The Name value should be a comma separated list of foreign key property names."
        /// </summary>
        internal static Exception ForeignKeyAttributeConvention_InvalidKey(object p0, object p1, object p2, object p3)
        {
            return new InvalidOperationException(Strings.ForeignKeyAttributeConvention_InvalidKey(p0, p1, p2, p3));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The ForeignKeyAttribute on property '{0}' on type '{1}' is not valid. The navigation property '{2}' was not found on the dependent type '{1}'. The Name value should be a valid navigation property name."
        /// </summary>
        internal static Exception ForeignKeyAttributeConvention_InvalidNavigationProperty(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.ForeignKeyAttributeConvention_InvalidNavigationProperty(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Unable to determine a composite foreign key ordering for foreign key on type {0}. When using the ForeignKey data annotation on composite foreign key properties ensure order is specified by using the Column data annotation or the fluent API."
        /// </summary>
        internal static Exception ForeignKeyAttributeConvention_OrderRequired(object p0)
        {
            return new InvalidOperationException(Strings.ForeignKeyAttributeConvention_OrderRequired(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The InversePropertyAttribute on property '{2}' on type '{3}' is not valid. The property '{0}' is not a valid navigation property on the related type '{1}'. Ensure that the property exists and is a valid reference or collection navigation property."
        /// </summary>
        internal static Exception InversePropertyAttributeConvention_PropertyNotFound(object p0, object p1, object p2, object p3)
        {
            return new InvalidOperationException(Strings.InversePropertyAttributeConvention_PropertyNotFound(p0, p1, p2, p3));
        }

        /// <summary>
        ///     InvalidOperationException with message like "A relationship cannot be established from property '{0}' on type '{1}' to property '{0}' on type '{1}'. Check the values in the InversePropertyAttribute to ensure relationship definitions are unique and reference from one navigation property to its corresponding inverse navigation property."
        /// </summary>
        internal static Exception InversePropertyAttributeConvention_SelfInverseDetected(object p0, object p1)
        {
            return new InvalidOperationException(Strings.InversePropertyAttributeConvention_SelfInverseDetected(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "A key is registered for the derived type '{0}'. Keys can only be registered for the root type '{1}'."
        /// </summary>
        internal static Exception KeyRegisteredOnDerivedType(object p0, object p1)
        {
            return new InvalidOperationException(Strings.KeyRegisteredOnDerivedType(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' has already been mapped to table '{1}'. Specify all mapping aspects of a table in a single Map call."
        /// </summary>
        internal static Exception InvalidTableMapping(object p0, object p1)
        {
            return new InvalidOperationException(Strings.InvalidTableMapping(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Map was called more than once for type '{0}' and at least one of the calls didn't specify the target table name."
        /// </summary>
        internal static Exception InvalidTableMapping_NoTableName(object p0)
        {
            return new InvalidOperationException(Strings.InvalidTableMapping_NoTableName(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The derived type '{0}' has already been mapped using the chaining syntax. A derived type can only be mapped once using the chaining syntax."
        /// </summary>
        internal static Exception InvalidChainedMappingSyntax(object p0)
        {
            return new InvalidOperationException(Strings.InvalidChainedMappingSyntax(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "An "is not null" condition cannot be specified on property '{0}' on type '{1}' because this property is not included in the model. Check that the property has not been explicitly excluded from the model by using the Ignore method or NotMappedAttribute data annotation."
        /// </summary>
        internal static Exception InvalidNotNullCondition(object p0, object p1)
        {
            return new InvalidOperationException(Strings.InvalidNotNullCondition(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "Values of type '{0}' cannot be used as type discriminator values. Supported types include byte, signed byte, bool, int16, int32, int64, and string."
        /// </summary>
        internal static Exception InvalidDiscriminatorType(object p0)
        {
            return new ArgumentException(Strings.InvalidDiscriminatorType(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Unable to add the convention '{0}'. Could not find an existing convention of type '{1}' in the current convention set."
        /// </summary>
        internal static Exception ConventionNotFound(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ConventionNotFound(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Not all properties for type '{0}' have been mapped. Either map those properties or explicitly excluded them from the model."
        /// </summary>
        internal static Exception InvalidEntitySplittingProperties(object p0)
        {
            return new InvalidOperationException(Strings.InvalidEntitySplittingProperties(p0));
        }

        /// <summary>
        ///     NotSupportedException with message like "Unable to determine the provider name for connection of type '{0}'."
        /// </summary>
        internal static Exception ModelBuilder_ProviderNameNotFound(object p0)
        {
            return new NotSupportedException(Strings.ModelBuilder_ProviderNameNotFound(p0));
        }

        /// <summary>
        ///     ArgumentException with message like "The database name '{0}' is invalid. Database names must be of the form [<schema_name>.]
        ///                                                                                                                      <object_name>."
        /// </summary>
        internal static Exception InvalidDatabaseName(object p0)
        {
            return new ArgumentException(Strings.InvalidDatabaseName(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Properties for type '{0}' can only be mapped once. Ensure the MapInheritedProperties method is only used during one call to the Map method."
        /// </summary>
        internal static Exception EntityMappingConfiguration_DuplicateMapInheritedProperties(object p0)
        {
            return new InvalidOperationException(Strings.EntityMappingConfiguration_DuplicateMapInheritedProperties(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Properties for type '{0}' can only be mapped once. Ensure the Properties method is used and that repeated calls specify each non-key property only once."
        /// </summary>
        internal static Exception EntityMappingConfiguration_DuplicateMappedProperties(object p0)
        {
            return new InvalidOperationException(Strings.EntityMappingConfiguration_DuplicateMappedProperties(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Properties for type '{0}' can only be mapped once. The non-key property '{1}' is mapped more than once. Ensure the Properties method specifies each non-key property only once."
        /// </summary>
        internal static Exception EntityMappingConfiguration_DuplicateMappedProperty(object p0, object p1)
        {
            return new InvalidOperationException(Strings.EntityMappingConfiguration_DuplicateMappedProperty(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The property '{1}' on type '{0}' cannot be mapped because it has been explicitly excluded from the model or it is of a type not supported by the DbModelBuilderVersion being used."
        /// </summary>
        internal static Exception EntityMappingConfiguration_CannotMapIgnoredProperty(object p0, object p1)
        {
            return new InvalidOperationException(Strings.EntityMappingConfiguration_CannotMapIgnoredProperty(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The entity types '{0}' and '{1}' cannot share table '{2}' because they are not in the same type hierarchy or do not have a valid one to one foreign key relationship with matching primary keys between them."
        /// </summary>
        internal static Exception EntityMappingConfiguration_InvalidTableSharing(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.EntityMappingConfiguration_InvalidTableSharing(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "You cannot use Ignore method on the property '{0}' on type '{1}' because this type inherits from the type '{2}' where this property is mapped. To exclude this property from your model, use NotMappedAttribute or Ignore method on the base type."
        /// </summary>
        internal static Exception CannotIgnoreMappedBaseProperty(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.CannotIgnoreMappedBaseProperty(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The property '{0}' cannot be used as a key property on the entity '{1}' because the property type is not a valid key type. Only scalar types, string and byte[] are supported key types."
        /// </summary>
        internal static Exception ModelBuilder_KeyPropertiesMustBePrimitive(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ModelBuilder_KeyPropertiesMustBePrimitive(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The specified table '{0}' was not found in the model. Ensure that the table name has been correctly specified."
        /// </summary>
        internal static Exception TableNotFound(object p0)
        {
            return new InvalidOperationException(Strings.TableNotFound(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The specified association foreign key columns '{0}' are invalid. The number of columns specified must match the number of primary key columns."
        /// </summary>
        internal static Exception IncorrectColumnCount(object p0)
        {
            return new InvalidOperationException(Strings.IncorrectColumnCount(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "A circular ComplexType hierarchy was detected. Self-referencing ComplexTypes are not supported."
        /// </summary>
        internal static Exception CircularComplexTypeHierarchy()
        {
            return new InvalidOperationException(Strings.CircularComplexTypeHierarchy);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Unable to determine the principal end of an association between the types '{0}' and '{1}'. The principal end of this association must be explicitly configured using either the relationship fluent API or data annotations."
        /// </summary>
        internal static Exception UnableToDeterminePrincipal(object p0, object p1)
        {
            return new InvalidOperationException(Strings.UnableToDeterminePrincipal(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The abstract type '{0}' has no mapped descendants and so cannot be mapped. Either remove '{0}' from the model or add one or more types deriving from '{0}' to the model. "
        /// </summary>
        internal static Exception UnmappedAbstractType(object p0)
        {
            return new InvalidOperationException(Strings.UnmappedAbstractType(p0));
        }

        /// <summary>
        ///     NotSupportedException with message like "The type '{0}' cannot be mapped as defined because it maps inherited properties from types that use entity splitting or another form of inheritance. Either choose a different inheritance mapping strategy so as to not map inherited properties, or change all types in the hierarchy to map inherited properties and to not use splitting. "
        /// </summary>
        internal static Exception UnsupportedHybridInheritanceMapping(object p0)
        {
            return new NotSupportedException(Strings.UnsupportedHybridInheritanceMapping(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The table '{0}' was configured but is not used in any mappings. Verify the mapping configuration for '{0}' is correct."
        /// </summary>
        internal static Exception OrphanedConfiguredTableDetected(object p0)
        {
            return new InvalidOperationException(Strings.OrphanedConfiguredTableDetected(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The configured column orders for the table '{0}' contains duplicates. Ensure the specified column order values are distinct."
        /// </summary>
        internal static Exception DuplicateConfiguredColumnOrder(object p0)
        {
            return new InvalidOperationException(Strings.DuplicateConfiguredColumnOrder(p0));
        }

        /// <summary>
        ///     NotSupportedException with message like "The enum or spatial property '{1}' on type '{0}' cannot be mapped. Use DbModelBuilderVersion 'V5_0' or later to map enum or spatial properties."
        /// </summary>
        internal static Exception UnsupportedUseOfV3Type(object p0, object p1)
        {
            return new NotSupportedException(Strings.UnsupportedUseOfV3Type(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Multiple potential primary key properties named '{0}' but differing only by case were found on entity type '{1}'. Configure the primary key explicitly using the HasKey fluent API or the KeyAttribute data annotation."
        /// </summary>
        internal static Exception MultiplePropertiesMatchedAsKeys(object p0, object p1)
        {
            return new InvalidOperationException(Strings.MultiplePropertiesMatchedAsKeys(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot get value for property '{0}' from entity of type '{1}' because the property has no get accessor."
        /// </summary>
        internal static Exception DbPropertyEntry_CannotGetCurrentValue(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyEntry_CannotGetCurrentValue(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot set value for property '{0}' on entity of type '{1}' because the property has no set accessor."
        /// </summary>
        internal static Exception DbPropertyEntry_CannotSetCurrentValue(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyEntry_CannotSetCurrentValue(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Member '{0}' cannot be called for property '{1}' because the entity of type '{2}' does not exist in the context. To add an entity to the context call the Add or Attach method of DbSet<{2}>."
        /// </summary>
        internal static Exception DbPropertyEntry_NotSupportedForDetached(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.DbPropertyEntry_NotSupportedForDetached(p0, p1, p2));
        }

        /// <summary>
        ///     NotSupportedException with message like "Cannot set value for property '{0}' on entity of type '{1}' because the property has no set accessor and is in the '{2}' state."
        /// </summary>
        internal static Exception DbPropertyEntry_SettingEntityRefNotSupported(object p0, object p1, object p2)
        {
            return new NotSupportedException(Strings.DbPropertyEntry_SettingEntityRefNotSupported(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Member '{0}' cannot be called for property '{1}' on entity of type '{2}' because the property is not part of the Entity Data Model."
        /// </summary>
        internal static Exception DbPropertyEntry_NotSupportedForPropertiesNotInTheModel(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.DbPropertyEntry_NotSupportedForPropertiesNotInTheModel(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Member '{0}' cannot be called for the entity of type '{1}' because the entity does not exist in the context. To add an entity to the context call the Add or Attach method of DbSet<{1}>."
        /// </summary>
        internal static Exception DbEntityEntry_NotSupportedForDetached(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbEntityEntry_NotSupportedForDetached(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "Cannot call the {0} method for an entity of type '{1}' on a DbSet for entities of type '{2}'. Only entities of type '{2}' or derived from type '{2}' can be added, attached, or removed."
        /// </summary>
        internal static Exception DbSet_BadTypeForAddAttachRemove(object p0, object p1, object p2)
        {
            return new ArgumentException(Strings.DbSet_BadTypeForAddAttachRemove(p0, p1, p2));
        }

        /// <summary>
        ///     ArgumentException with message like "Cannot call the Create method for the type '{0}' on a DbSet for entities of type '{1}'. Only entities of type '{1}' or derived from type '{1}' can be created."
        /// </summary>
        internal static Exception DbSet_BadTypeForCreate(object p0, object p1)
        {
            return new ArgumentException(Strings.DbSet_BadTypeForCreate(p0, p1));
        }

        /// <summary>
        ///     InvalidCastException with message like "Cannot create a {0}<{1}> from a non-generic {0} for objects of type '{2}'."
        /// </summary>
        internal static Exception DbEntity_BadTypeForCast(object p0, object p1, object p2)
        {
            return new InvalidCastException(Strings.DbEntity_BadTypeForCast(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidCastException with message like "Cannot create a {0}<{1}, {2}> from a non-generic {0} for entities of type '{3}' with property of type '{4}'."
        /// </summary>
        internal static Exception DbMember_BadTypeForCast(object p0, object p1, object p2, object p3, object p4)
        {
            return new InvalidCastException(Strings.DbMember_BadTypeForCast(p0, p1, p2, p3, p4));
        }

        /// <summary>
        ///     ArgumentException with message like "The property '{0}' on type '{1}' is a collection navigation property. The Collection method should be used instead of the Reference method."
        /// </summary>
        internal static Exception DbEntityEntry_UsedReferenceForCollectionProp(object p0, object p1)
        {
            return new ArgumentException(Strings.DbEntityEntry_UsedReferenceForCollectionProp(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "The property '{0}' on type '{1}' is a reference navigation property. The Reference method should be used instead of the Collection method."
        /// </summary>
        internal static Exception DbEntityEntry_UsedCollectionForReferenceProp(object p0, object p1)
        {
            return new ArgumentException(Strings.DbEntityEntry_UsedCollectionForReferenceProp(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "The property '{0}' on type '{1}' is not a navigation property. The Reference and Collection methods can only be used with navigation properties. Use the Property or ComplexProperty method."
        /// </summary>
        internal static Exception DbEntityEntry_NotANavigationProperty(object p0, object p1)
        {
            return new ArgumentException(Strings.DbEntityEntry_NotANavigationProperty(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "The property '{0}' on type '{1}' is not a primitive or complex property. The Property method can only be used with primitive or complex properties. Use the Reference or Collection method."
        /// </summary>
        internal static Exception DbEntityEntry_NotAScalarProperty(object p0, object p1)
        {
            return new ArgumentException(Strings.DbEntityEntry_NotAScalarProperty(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "The property '{0}' on type '{1}' is not a complex property. The ComplexProperty method can only be used with complex properties. Use the Property, Reference or Collection method."
        /// </summary>
        internal static Exception DbEntityEntry_NotAComplexProperty(object p0, object p1)
        {
            return new ArgumentException(Strings.DbEntityEntry_NotAComplexProperty(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "The property '{0}' on type '{1}' is not a primitive property, complex property, collection navigation property, or reference navigation property."
        /// </summary>
        internal static Exception DbEntityEntry_NotAProperty(object p0, object p1)
        {
            return new ArgumentException(Strings.DbEntityEntry_NotAProperty(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like ""The property '{0}' from the property path '{1}' is not a complex property on type '{2}'. Property paths must be composed of complex properties for all except the final property.""
        /// </summary>
        internal static Exception DbEntityEntry_DottedPartNotComplex(object p0, object p1, object p2)
        {
            return new ArgumentException(Strings.DbEntityEntry_DottedPartNotComplex(p0, p1, p2));
        }

        /// <summary>
        ///     NotSupportedException with message like "Setting IsModified to false for a modified property is not supported."
        /// </summary>
        internal static Exception DbPropertyEntry_CannotMarkPropertyUnmodified()
        {
            return new NotSupportedException(Strings.DbPropertyEntry_CannotMarkPropertyUnmodified);
        }

        /// <summary>
        ///     ArgumentException with message like ""The property path '{0}' cannot be used for navigation properties. Property paths can only be used to access primitive or complex properties.""
        /// </summary>
        internal static Exception DbEntityEntry_DottedPathMustBeProperty(object p0)
        {
            return new ArgumentException(Strings.DbEntityEntry_DottedPathMustBeProperty(p0));
        }

        /// <summary>
        ///     ArgumentException with message like "The navigation property '{0}' on entity type '{1}' cannot be used for entities of type '{2}' because it refers to entities of type '{3}'."
        /// </summary>
        internal static Exception DbEntityEntry_WrongGenericForNavProp(object p0, object p1, object p2, object p3)
        {
            return new ArgumentException(Strings.DbEntityEntry_WrongGenericForNavProp(p0, p1, p2, p3));
        }

        /// <summary>
        ///     ArgumentException with message like "The generic type argument '{0}' cannot be used with the Member method when accessing the collection navigation property '{1}' on entity type '{2}'. The generic type argument '{3}' must be used instead."
        /// </summary>
        internal static Exception DbEntityEntry_WrongGenericForCollectionNavProp(object p0, object p1, object p2, object p3)
        {
            return new ArgumentException(Strings.DbEntityEntry_WrongGenericForCollectionNavProp(p0, p1, p2, p3));
        }

        /// <summary>
        ///     ArgumentException with message like "The property '{0}' on entity type '{1}' cannot be used for objects of type '{2}' because it is a property for objects of type '{3}'."
        /// </summary>
        internal static Exception DbEntityEntry_WrongGenericForProp(object p0, object p1, object p2, object p3)
        {
            return new ArgumentException(Strings.DbEntityEntry_WrongGenericForProp(p0, p1, p2, p3));
        }

        /// <summary>
        ///     ArgumentException with message like "The expression passed to method {0} must represent a property defined on the type '{1}'."
        /// </summary>
        internal static Exception DbEntityEntry_BadPropertyExpression(object p0, object p1)
        {
            return new ArgumentException(Strings.DbEntityEntry_BadPropertyExpression(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "{0} cannot be used for entities in the {1} state."
        /// </summary>
        internal static Exception DbPropertyValues_CannotGetValuesForState(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_CannotGetValuesForState(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot set non-nullable property '{0}' of type '{1}' to null on object of type '{2}'."
        /// </summary>
        internal static Exception DbPropertyValues_CannotSetNullValue(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_CannotSetNullValue(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The property '{0}' in the entity of type '{1}' is null. Store values cannot be obtained for an entity with a null complex property."
        /// </summary>
        internal static Exception DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot assign value of type '{0}' to property '{1}' of type '{2}' in property values for type '{3}'."
        /// </summary>
        internal static Exception DbPropertyValues_WrongTypeForAssignment(object p0, object p1, object p2, object p3)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_WrongTypeForAssignment(p0, p1, p2, p3));
        }

        /// <summary>
        ///     NotSupportedException with message like "The set of property value names is read-only."
        /// </summary>
        internal static Exception DbPropertyValues_PropertyValueNamesAreReadonly()
        {
            return new NotSupportedException(Strings.DbPropertyValues_PropertyValueNamesAreReadonly);
        }

        /// <summary>
        ///     ArgumentException with message like "The '{0}' property does not exist or is not mapped for the type '{1}'."
        /// </summary>
        internal static Exception DbPropertyValues_PropertyDoesNotExist(object p0, object p1)
        {
            return new ArgumentException(Strings.DbPropertyValues_PropertyDoesNotExist(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "Cannot copy values from DbPropertyValues for type '{0}' into DbPropertyValues for type '{1}'."
        /// </summary>
        internal static Exception DbPropertyValues_AttemptToSetValuesFromWrongObject(object p0, object p1)
        {
            return new ArgumentException(Strings.DbPropertyValues_AttemptToSetValuesFromWrongObject(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "Cannot copy from property values for object of type '{0}' into property values for object of type '{1}'."
        /// </summary>
        internal static Exception DbPropertyValues_AttemptToSetValuesFromWrongType(object p0, object p1)
        {
            return new ArgumentException(Strings.DbPropertyValues_AttemptToSetValuesFromWrongType(p0, p1));
        }

        /// <summary>
        ///     ArgumentException with message like "A property of a complex type must be set to an instance of the generic or non-generic DbPropertyValues class for that type."
        /// </summary>
        internal static Exception DbPropertyValues_AttemptToSetNonValuesOnComplexProperty()
        {
            return new ArgumentException(Strings.DbPropertyValues_AttemptToSetNonValuesOnComplexProperty);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The value of the complex property '{0}' on entity of type '{1}' is null. Complex properties cannot be set to null and values cannot be set for null complex properties."
        /// </summary>
        internal static Exception DbPropertyValues_ComplexObjectCannotBeNull(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_ComplexObjectCannotBeNull(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The value of the nested property values property '{0}' on the values for entity of type '{1}' is null. Nested property values cannot be set to null and values cannot be set for null complex properties."
        /// </summary>
        internal static Exception DbPropertyValues_NestedPropertyValuesNull(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_NestedPropertyValuesNull(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot set the value of the nested property '{0}' because value of the complex property '{1}' to which it belongs is null."
        /// </summary>
        internal static Exception DbPropertyValues_CannotSetPropertyOnNullCurrentValue(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_CannotSetPropertyOnNullCurrentValue(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot set the original value of the nested property '{0}' because the original value of the complex property '{1}' to which it belongs is null."
        /// </summary>
        internal static Exception DbPropertyValues_CannotSetPropertyOnNullOriginalValue(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbPropertyValues_CannotSetPropertyOnNullOriginalValue(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The model backing the '{0}' context has changed since the database was created. Consider using Code First Migrations to update the database (http://go.microsoft.com/fwlink/?LinkId=238269)."
        /// </summary>
        internal static Exception DatabaseInitializationStrategy_ModelMismatch(object p0)
        {
            return new InvalidOperationException(Strings.DatabaseInitializationStrategy_ModelMismatch(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Database '{0}' cannot be created because it already exists."
        /// </summary>
        internal static Exception Database_DatabaseAlreadyExists(object p0)
        {
            return new InvalidOperationException(Strings.Database_DatabaseAlreadyExists(p0));
        }

        /// <summary>
        ///     NotSupportedException with message like "Model compatibility cannot be checked because the DbContext instance was not created using Code First patterns. DbContext instances created from an ObjectContext or using an EDMX file cannot be checked for compatibility."
        /// </summary>
        internal static Exception Database_NonCodeFirstCompatibilityCheck()
        {
            return new NotSupportedException(Strings.Database_NonCodeFirstCompatibilityCheck);
        }

        /// <summary>
        ///     NotSupportedException with message like "Model compatibility cannot be checked because the EdmMetadata type was not included in the model. Ensure that IncludeMetadataConvention has been added to the DbModelBuilder conventions."
        /// </summary>
        internal static Exception Database_MetadataNotMapped()
        {
            return new NotSupportedException(Strings.Database_MetadataNotMapped);
        }

        /// <summary>
        ///     NotSupportedException with message like "Model compatibility cannot be checked because the database does not contain model metadata. Model compatibility can only be checked for databases created using Code First or Code First Migrations."
        /// </summary>
        internal static Exception Database_NoDatabaseMetadata()
        {
            return new NotSupportedException(Strings.Database_NoDatabaseMetadata);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The DbContextDatabaseInitializer entry 'key="{0}" value="{1}"' in the application configuration is not valid. Entries should be of the form 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="MyNamespace.MyInitializerClass, MyAssembly"' or 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="Disabled"'. Consider using the <entityFramework>configuration section to set the database initializer (http://go.microsoft.com/fwlink/?LinkID=237468)."
        /// </summary>
        internal static Exception Database_BadLegacyInitializerEntry(object p0, object p1)
        {
            return new InvalidOperationException(Strings.Database_BadLegacyInitializerEntry(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Failed to set database initializer of type '{0}' for DbContext type '{1}' specified in the application configuration. Entries should be of the form 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="MyNamespace.MyInitializerClass, MyAssembly"' or 'key="DatabaseInitializerForType MyNamespace.MyDbContextClass, MyAssembly" value="Disabled"'. Also verify that 'DatabaseInitializerArgumentForType' entries are present for every parameter of the database initializer constructor. See inner exception for details. Consider using the <entityFramework>configuration section to set the database initializer (http://go.microsoft.com/fwlink/?LinkID=237468)."
        /// </summary>
        internal static Exception Database_InitializeFromLegacyConfigFailed(object p0, object p1)
        {
            return new InvalidOperationException(Strings.Database_InitializeFromLegacyConfigFailed(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Failed to set database initializer of type '{0}' for DbContext type '{1}' specified in the application configuration. See inner exception for details."
        /// </summary>
        internal static Exception Database_InitializeFromConfigFailed(object p0, object p1)
        {
            return new InvalidOperationException(Strings.Database_InitializeFromConfigFailed(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Configuration for DbContext type '{0}' is specified multiple times in the application configuration. Each context can only be configured once."
        /// </summary>
        internal static Exception ContextConfiguredMultipleTimes(object p0)
        {
            return new InvalidOperationException(Strings.ContextConfiguredMultipleTimes(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Failed to set Database.DefaultConnectionFactory to an instance of the '{0}' type as specified in the application configuration. See inner exception for details."
        /// </summary>
        internal static Exception SetConnectionFactoryFromConfigFailed(object p0)
        {
            return new InvalidOperationException(Strings.SetConnectionFactoryFromConfigFailed(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' could not be found. The type name must be an assembly-qualified name."
        /// </summary>
        internal static Exception Database_FailedToResolveType(object p0)
        {
            return new InvalidOperationException(Strings.Database_FailedToResolveType(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The context cannot be used while the model is being created."
        /// </summary>
        internal static Exception DbContext_ContextUsedInModelCreating()
        {
            return new InvalidOperationException(Strings.DbContext_ContextUsedInModelCreating);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The DbContext class cannot be used with models that have multiple entity sets per type (MEST)."
        /// </summary>
        internal static Exception DbContext_MESTNotSupported()
        {
            return new InvalidOperationException(Strings.DbContext_MESTNotSupported);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The operation cannot be completed because the DbContext has been disposed."
        /// </summary>
        internal static Exception DbContext_Disposed()
        {
            return new InvalidOperationException(Strings.DbContext_Disposed);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The provider factory returned a null connection."
        /// </summary>
        internal static Exception DbContext_ProviderReturnedNullConnection()
        {
            return new InvalidOperationException(Strings.DbContext_ProviderReturnedNullConnection);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The connection string '{0}' in the application's configuration file does not contain the required providerName attribute.""
        /// </summary>
        internal static Exception DbContext_ProviderNameMissing(object p0)
        {
            return new InvalidOperationException(Strings.DbContext_ProviderNameMissing(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The DbConnectionFactory instance returned a null connection."
        /// </summary>
        internal static Exception DbContext_ConnectionFactoryReturnedNullConnection()
        {
            return new InvalidOperationException(Strings.DbContext_ConnectionFactoryReturnedNullConnection);
        }

        /// <summary>
        ///     ArgumentException with message like "The number of primary key values passed must match number of primary key values defined on the entity."
        /// </summary>
        internal static Exception DbSet_WrongNumberOfKeyValuesPassed()
        {
            return new ArgumentException(Strings.DbSet_WrongNumberOfKeyValuesPassed);
        }

        /// <summary>
        ///     ArgumentException with message like "The type of one of the primary key values did not match the type defined in the entity. See inner exception for details."
        /// </summary>
        internal static Exception DbSet_WrongKeyValueType()
        {
            return new ArgumentException(Strings.DbSet_WrongKeyValueType);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The entity found was of type {0} when an entity of type {1} was requested."
        /// </summary>
        internal static Exception DbSet_WrongEntityTypeFound(object p0, object p1)
        {
            return new InvalidOperationException(Strings.DbSet_WrongEntityTypeFound(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Multiple entities were found in the Added state that match the given primary key values."
        /// </summary>
        internal static Exception DbSet_MultipleAddedEntitiesFound()
        {
            return new InvalidOperationException(Strings.DbSet_MultipleAddedEntitiesFound);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' is mapped as a complex type. The Set method, DbSet objects, and DbEntityEntry objects can only be used with entity types, not complex types."
        /// </summary>
        internal static Exception DbSet_DbSetUsedWithComplexType(object p0)
        {
            return new InvalidOperationException(Strings.DbSet_DbSetUsedWithComplexType(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The type '{0}' is not attributed with EdmEntityTypeAttribute but is contained in an assembly attributed with EdmSchemaAttribute. POCO entities that do not use EdmEntityTypeAttribute cannot be contained in the same assembly as non-POCO entities that use EdmEntityTypeAttribute."
        /// </summary>
        internal static Exception DbSet_PocoAndNonPocoMixedInSameAssembly(object p0)
        {
            return new InvalidOperationException(Strings.DbSet_PocoAndNonPocoMixedInSameAssembly(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The entity type {0} is not part of the model for the current context."
        /// </summary>
        internal static Exception DbSet_EntityTypeNotInModel(object p0)
        {
            return new InvalidOperationException(Strings.DbSet_EntityTypeNotInModel(p0));
        }

        /// <summary>
        ///     NotSupportedException with message like "Data binding directly to a store query (DbSet, DbQuery, DbSqlQuery, DbRawSqlQuery) is not supported. Instead populate a DbSet with data, for example by calling Load on the DbSet, and then bind to local data. For WPF bind to DbSet.Local. For WinForms bind to DbSet.Local.ToBindingList()."
        /// </summary>
        internal static Exception DbQuery_BindingToDbQueryNotSupported()
        {
            return new NotSupportedException(Strings.DbQuery_BindingToDbQueryNotSupported);
        }

        /// <summary>
        ///     ArgumentException with message like "The Include path expression must refer to a navigation property defined on the type. Use dotted paths for reference navigation properties and the Select operator for collection navigation properties."
        /// </summary>
        internal static Exception DbExtensions_InvalidIncludePathExpression()
        {
            return new ArgumentException(Strings.DbExtensions_InvalidIncludePathExpression);
        }

        /// <summary>
        ///     InvalidOperationException with message like "No connection string named '{0}' could be found in the application config file."
        /// </summary>
        internal static Exception DbContext_ConnectionStringNotFound(object p0)
        {
            return new InvalidOperationException(Strings.DbContext_ConnectionStringNotFound(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot initialize a DbContext from an entity connection string or an EntityConnection instance together with a DbCompiledModel. If an entity connection string or EntityConnection instance is used, then the model will be created from the metadata in the connection. If a DbCompiledModel is used, then the connection supplied should be a standard database connection (for example, a SqlConnection instance) rather than an entity connection."
        /// </summary>
        internal static Exception DbContext_ConnectionHasModel()
        {
            return new InvalidOperationException(Strings.DbContext_ConnectionHasModel);
        }

        /// <summary>
        ///     NotSupportedException with message like "The collection navigation property '{0}' on the entity of type '{1}' cannot be set because the entity type does not define a navigation property with a set accessor."
        /// </summary>
        internal static Exception DbCollectionEntry_CannotSetCollectionProp(object p0, object p1)
        {
            return new NotSupportedException(Strings.DbCollectionEntry_CannotSetCollectionProp(p0, p1));
        }

        /// <summary>
        ///     NotSupportedException with message like "Using the same DbCompiledModel to create contexts against different types of database servers is not supported. Instead, create a separate DbCompiledModel for each type of server being used."
        /// </summary>
        internal static Exception CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported()
        {
            return new NotSupportedException(Strings.CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Multiple object sets per type are not supported. The object sets '{0}' and '{1}' can both contain instances of type '{2}'."
        /// </summary>
        internal static Exception Mapping_MESTNotSupported(object p0, object p1, object p2)
        {
            return new InvalidOperationException(Strings.Mapping_MESTNotSupported(p0, p1, p2));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The context type '{0}' must have a public constructor taking an EntityConnection."
        /// </summary>
        internal static Exception DbModelBuilder_MissingRequiredCtor(object p0)
        {
            return new InvalidOperationException(Strings.DbModelBuilder_MissingRequiredCtor(p0));
        }

        /// <summary>
        ///     NotSupportedException with message like "The database name '{0}' is not supported because it is an MDF file name. A full connection string must be provided to attach an MDF file."
        /// </summary>
        internal static Exception SqlConnectionFactory_MdfNotSupported(object p0)
        {
            return new NotSupportedException(Strings.SqlConnectionFactory_MdfNotSupported(p0));
        }

        /// <summary>
        ///     DataException with message like "An exception occurred while initializing the database. See the InnerException for details."
        /// </summary>
        internal static Exception Database_InitializationException()
        {
            return new DataException(Strings.Database_InitializationException);
        }

        /// <summary>
        ///     NotSupportedException with message like "Creating a DbModelBuilder or writing the EDMX from a DbContext created using an existing ObjectContext is not supported. EDMX can only be obtained from a Code First DbContext created without using an existing DbCompiledModel."
        /// </summary>
        internal static Exception EdmxWriter_EdmxFromObjectContextNotSupported()
        {
            return new NotSupportedException(Strings.EdmxWriter_EdmxFromObjectContextNotSupported);
        }

        /// <summary>
        ///     NotSupportedException with message like "Creating a DbModelBuilder or writing the EDMX from a DbContext created using an existing DbCompiledModel is not supported. EDMX can only be obtained from a Code First DbContext created without using an existing DbCompiledModel."
        /// </summary>
        internal static Exception EdmxWriter_EdmxFromDbCompiledModelNotSupported()
        {
            return new NotSupportedException(Strings.EdmxWriter_EdmxFromDbCompiledModelNotSupported);
        }

        /// <summary>
        ///     NotSupportedException with message like "Creating a DbModelBuilder or writing the EDMX from a DbContext created using Database First or Model First is not supported. EDMX can only be obtained from a Code First DbContext created without using an existing DbCompiledModel."
        /// </summary>
        internal static Exception EdmxWriter_EdmxFromModelFirstNotSupported()
        {
            return new NotSupportedException(Strings.EdmxWriter_EdmxFromModelFirstNotSupported);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The context factory type '{0}' must have a public default constructor."
        /// </summary>
        internal static Exception DbContextServices_MissingDefaultCtor(object p0)
        {
            return new InvalidOperationException(Strings.DbContextServices_MissingDefaultCtor(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The generic 'Set' method cannot be called with a proxy type. Either use the actual entity type or call the non-generic 'Set' method."
        /// </summary>
        internal static Exception CannotCallGenericSetWithProxyType()
        {
            return new InvalidOperationException(Strings.CannotCallGenericSetWithProxyType);
        }

        /// <summary>
        ///     InvalidOperationException with message like "MaxLengthAttribute must have a Length value that is greater than zero. Use MaxLength() without parameters to  indicate that the string or array can have the maximum allowable length."
        /// </summary>
        internal static Exception MaxLengthAttribute_InvalidMaxLength()
        {
            return new InvalidOperationException(Strings.MaxLengthAttribute_InvalidMaxLength);
        }

        /// <summary>
        ///     InvalidOperationException with message like "MinLengthAttribute must have a Length value that is zero or greater."
        /// </summary>
        internal static Exception MinLengthAttribute_InvalidMinLength()
        {
            return new InvalidOperationException(Strings.MinLengthAttribute_InvalidMinLength);
        }

        /// <summary>
        ///     InvalidOperationException with message like "No connection string named '{0}' could be found in the application config file."
        /// </summary>
        internal static Exception DbConnectionInfo_ConnectionStringNotFound(object p0)
        {
            return new InvalidOperationException(Strings.DbConnectionInfo_ConnectionStringNotFound(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The connection can not be overridden because this context was created from an existing ObjectContext."
        /// </summary>
        internal static Exception EagerInternalContext_CannotSetConnectionInfo()
        {
            return new InvalidOperationException(Strings.EagerInternalContext_CannotSetConnectionInfo);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Can not override the connection for this context with a standard DbConnection because the original connection was an EntityConnection."
        /// </summary>
        internal static Exception LazyInternalContext_CannotReplaceEfConnectionWithDbConnection()
        {
            return new InvalidOperationException(Strings.LazyInternalContext_CannotReplaceEfConnectionWithDbConnection);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Can not override the connection for this context with an EntityConnection because the original connection was a standard DbConnection."
        /// </summary>
        internal static Exception LazyInternalContext_CannotReplaceDbConnectionWithEfConnection()
        {
            return new InvalidOperationException(Strings.LazyInternalContext_CannotReplaceDbConnectionWithEfConnection);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The requested operation could not be completed, because a null EntityKey property value was returned by the object."
        /// </summary>
        internal static Exception EntityKey_UnexpectedNull()
        {
            return new InvalidOperationException(Strings.EntityKey_UnexpectedNull);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot perform the operation because the adapter does not have a connection."
        /// </summary>
        internal static Exception EntityClient_NoConnectionForAdapter()
        {
            return new InvalidOperationException(Strings.EntityClient_NoConnectionForAdapter);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Cannot perform the update operation because the adapter's connection is not open."
        /// </summary>
        internal static Exception EntityClient_ClosedConnectionForUpdate()
        {
            return new InvalidOperationException(Strings.EntityClient_ClosedConnectionForUpdate);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The update operation cannot be performed, because the adapter's connection is not associated with a valid store connection."
        /// </summary>
        internal static Exception EntityClient_NoStoreConnectionForUpdate()
        {
            return new InvalidOperationException(Strings.EntityClient_NoStoreConnectionForUpdate);
        }

        /// <summary>
        ///     MappingException with message like "The type '{0}'('{1}') of the member '{2}' in the conceptual  type '{3}' doesn't match with the type '{4}'('{5}') of the member '{6}' on the object side type '{7}'."
        /// </summary>
        internal static Exception Mapping_Default_OCMapping_Member_Type_Mismatch(
            object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7)
        {
            return new MappingException(Strings.Mapping_Default_OCMapping_Member_Type_Mismatch(p0, p1, p2, p3, p4, p5, p6, p7));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Conflicting changes to the role '{0}' of the relationship '{1}' have been detected."
        /// </summary>
        internal static Exception ObjectStateManager_ConflictingChangesOfRelationshipDetected(object p0, object p1)
        {
            return new InvalidOperationException(Strings.ObjectStateManager_ConflictingChangesOfRelationshipDetected(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Attach is not a valid operation when the source object associated with this related end is in an added, deleted, or detached state. Objects loaded using the NoTracking merge option are always detached."
        /// </summary>
        internal static Exception RelatedEnd_InvalidOwnerStateForAttach()
        {
            return new InvalidOperationException(Strings.RelatedEnd_InvalidOwnerStateForAttach);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The object at index {0} in the specified collection of objects is null."
        /// </summary>
        internal static Exception RelatedEnd_InvalidNthElementNullForAttach(object p0)
        {
            return new InvalidOperationException(Strings.RelatedEnd_InvalidNthElementNullForAttach(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The object at index {0} in the specified collection of objects is not attached to the same ObjectContext as source object of this EntityCollection."
        /// </summary>
        internal static Exception RelatedEnd_InvalidNthElementContextForAttach(object p0)
        {
            return new InvalidOperationException(Strings.RelatedEnd_InvalidNthElementContextForAttach(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The object at index {0} in the specified collection of objects is in an added or deleted state. Relationships cannot be created for objects in this state."
        /// </summary>
        internal static Exception RelatedEnd_InvalidNthElementStateForAttach(object p0)
        {
            return new InvalidOperationException(Strings.RelatedEnd_InvalidNthElementStateForAttach(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The object being attached to the source object is not attached to the same ObjectContext as the source object."
        /// </summary>
        internal static Exception RelatedEnd_InvalidEntityContextForAttach()
        {
            return new InvalidOperationException(Strings.RelatedEnd_InvalidEntityContextForAttach);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The object being attached is in an added or deleted state. Relationships cannot be created for objects in this state."
        /// </summary>
        internal static Exception RelatedEnd_InvalidEntityStateForAttach()
        {
            return new InvalidOperationException(Strings.RelatedEnd_InvalidEntityStateForAttach);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Adding a relationship with an entity which is in the Deleted state is not allowed."
        /// </summary>
        internal static Exception RelatedEnd_UnableToAddRelationshipWithDeletedEntity()
        {
            return new InvalidOperationException(Strings.RelatedEnd_UnableToAddRelationshipWithDeletedEntity);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The relationship '{0}' does not match any relationship defined in the conceptual model."
        /// </summary>
        internal static Exception Collections_NoRelationshipSetMatched(object p0)
        {
            return new InvalidOperationException(Strings.Collections_NoRelationshipSetMatched(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The source query for this EntityCollection or EntityReference cannot be returned when the related object is in either an added state or a detached state and was not originally retrieved using the NoTracking merge option."
        /// </summary>
        internal static Exception Collections_InvalidEntityStateSource()
        {
            return new InvalidOperationException(Strings.Collections_InvalidEntityStateSource);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The Load method cannot return the {0} when the related object is in a deleted state."
        /// </summary>
        internal static Exception Collections_InvalidEntityStateLoad(object p0)
        {
            return new InvalidOperationException(Strings.Collections_InvalidEntityStateLoad(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The EntityKey property cannot be set to EntityNotValidKey, NoEntitySetKey, or a temporary key."
        /// </summary>
        internal static Exception EntityReference_CannotSetSpecialKeys()
        {
            return new InvalidOperationException(Strings.EntityReference_CannotSetSpecialKeys);
        }

        /// <summary>
        ///     InvalidOperationException with message like "At least one related end in the relationship could not be found."
        /// </summary>
        internal static Exception RelatedEnd_RelatedEndNotFound()
        {
            return new InvalidOperationException(Strings.RelatedEnd_RelatedEndNotFound);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The {0} could not be loaded because it is not attached to an ObjectContext."
        /// </summary>
        internal static Exception RelatedEnd_RelatedEndNotAttachedToContext(object p0)
        {
            return new InvalidOperationException(Strings.RelatedEnd_RelatedEndNotAttachedToContext(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "When an object is returned with a NoTracking merge option, Load can only be called when the EntityCollection or EntityReference does not contain objects."
        /// </summary>
        internal static Exception RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd()
        {
            return new InvalidOperationException(Strings.RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd);
        }

        /// <summary>
        ///     InvalidOperationException with message like "When an object is returned with a NoTracking merge option, Load cannot be called when the IsLoaded property is true."
        /// </summary>
        internal static Exception RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd()
        {
            return new InvalidOperationException(Strings.RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The object in the '{0}' role cannot be automatically added to the context because it was retrieved using the NoTracking merge option. Explicitly attach the entity to the ObjectContext before defining the relationship."
        /// </summary>
        internal static Exception RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(object p0)
        {
            return new InvalidOperationException(Strings.RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The relationship between the two objects cannot be defined because they are attached to different ObjectContext objects."
        /// </summary>
        internal static Exception RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts()
        {
            return new InvalidOperationException(Strings.RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Related objects cannot be loaded using the {0} merge option. Relationships cannot be created when one object was retrieved using a NoTracking merge option and the other object was retrieved using a different merge option."
        /// </summary>
        internal static Exception RelatedEnd_MismatchedMergeOptionOnLoad(object p0)
        {
            return new InvalidOperationException(Strings.RelatedEnd_MismatchedMergeOptionOnLoad(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The relationship cannot be defined because the EntitySet name '{0}.{1}' is not valid for the role '{2}' in association set name '{3}.{4}'."
        /// </summary>
        internal static Exception RelatedEnd_EntitySetIsNotValidForRelationship(object p0, object p1, object p2, object p3, object p4)
        {
            return new InvalidOperationException(Strings.RelatedEnd_EntitySetIsNotValidForRelationship(p0, p1, p2, p3, p4));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Requested operation is not allowed when the owner of this RelatedEnd is null. RelatedEnd objects that were created with the default constructor should only be used as a container during serialization."
        /// </summary>
        internal static Exception RelatedEnd_OwnerIsNull()
        {
            return new InvalidOperationException(Strings.RelatedEnd_OwnerIsNull);
        }

        /// <summary>
        ///     InvalidOperationException with message like "A referential integrity constraint violation occurred: The property values that define the referential constraints are not consistent between principal and dependent objects in the relationship."
        /// </summary>
        internal static Exception RelationshipManager_InconsistentReferentialConstraintProperties()
        {
            return new InvalidOperationException(Strings.RelationshipManager_InconsistentReferentialConstraintProperties);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The specified navigation property {0} could not be found."
        /// </summary>
        internal static Exception RelationshipManager_NavigationPropertyNotFound(object p0)
        {
            return new InvalidOperationException(Strings.RelationshipManager_NavigationPropertyNotFound(p0));
        }

        /// <summary>
        ///     ArgumentException with message like "All 'EdmMember' instances must be a valid member of the EdmType."
        /// </summary>
        internal static Exception InvalidEdmMemberInstance()
        {
            return new ArgumentException(Strings.InvalidEdmMemberInstance);
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "More than one context type '{0}' was found in the assembly '{1}'. Specify the fully qualified name of the context."
        /// </summary>
        internal static Exception EnableMigrations_MultipleContextsWithName(object p0, object p1)
        {
            return new MigrationsException(Strings.EnableMigrations_MultipleContextsWithName(p0, p1));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "No context type was found in the assembly '{0}'."
        /// </summary>
        internal static Exception EnableMigrations_NoContext(object p0)
        {
            return new MigrationsException(Strings.EnableMigrations_NoContext(p0));
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "The context type '{0}' was not found in the assembly '{1}'."
        /// </summary>
        internal static Exception EnableMigrations_NoContextWithName(object p0, object p1)
        {
            return new MigrationsException(Strings.EnableMigrations_NoContextWithName(p0, p1));
        }

        /// <summary>
        ///     InvalidOperationException with message like "Sequence contains more than one element"
        /// </summary>
        internal static Exception MoreThanOneElement()
        {
            return new InvalidOperationException(Strings.MoreThanOneElement);
        }

        /// <summary>
        ///     InvalidOperationException with message like "The source IQueryable doesn't implement IDbAsyncEnumerable{0}."
        /// </summary>
        internal static Exception IQueryable_Not_Async(object p0)
        {
            return new InvalidOperationException(Strings.IQueryable_Not_Async(p0));
        }

        /// <summary>
        ///     InvalidOperationException with message like "The provider for the source IQueryable doesn't implement IDbAsyncQueryProvider."
        /// </summary>
        internal static Exception IQueryable_Provider_Not_Async()
        {
            return new InvalidOperationException(Strings.IQueryable_Provider_Not_Async);
        }

        /// <summary>
        ///     InvalidOperationException with message like "Sequence contains no elements."
        /// </summary>
        internal static Exception EmptySequence()
        {
            return new InvalidOperationException(Strings.EmptySequence);
        }

        /// <summary>
        ///     Migrations.Infrastructure.MigrationsException with message like "Auto-migrating default schema changes is not supported. Please use code-based migrations to migrate default schema changes."
        /// </summary>
        internal static Exception UnableToAutoMigrateDefaultSchema()
        {
            return new MigrationsException(Strings.UnableToAutoMigrateDefaultSchema);
        }

        /// <summary>
        ///     The exception that is thrown when a null reference (Nothing in Visual Basic) is passed to a method that does not accept it as a valid argument.
        /// </summary>
        internal static Exception ArgumentNull(string paramName)
        {
            return new ArgumentNullException(paramName);
        }

        /// <summary>
        ///     The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.
        /// </summary>
        internal static Exception ArgumentOutOfRange(string paramName)
        {
            return new ArgumentOutOfRangeException(paramName);
        }

        /// <summary>
        ///     The exception that is thrown when the author has yet to implement the logic at this point in the program. This can act as an exception based TODO tag.
        /// </summary>
        internal static Exception NotImplemented()
        {
            return new NotImplementedException();
        }

        /// <summary>
        ///     The exception that is thrown when an invoked method is not supported, or when there is an attempt to read, seek, or write to a stream that does not support the invoked functionality.
        /// </summary>
        internal static Exception NotSupported()
        {
            return new NotSupportedException();
        }
    }

    ///<summary>
    ///    AutoGenerated resource class. Usage:
    ///
    ///    string s = EntityRes.GetString(EntityRes.MyIdenfitier);
    ///</summary>
    [GeneratedCode("Resources.tt", "1.0.0.0")]
    internal sealed class EntityRes
    {
        internal const string AutomaticMigration = "AutomaticMigration";
        internal const string BootstrapMigration = "BootstrapMigration";
        internal const string InitialCreate = "InitialCreate";
        internal const string AutomaticDataLoss = "AutomaticDataLoss";
        internal const string LoggingAutoMigrate = "LoggingAutoMigrate";
        internal const string LoggingRevertAutoMigrate = "LoggingRevertAutoMigrate";
        internal const string LoggingApplyMigration = "LoggingApplyMigration";
        internal const string LoggingRevertMigration = "LoggingRevertMigration";
        internal const string LoggingHistoryInsert = "LoggingHistoryInsert";
        internal const string LoggingHistoryDelete = "LoggingHistoryDelete";
        internal const string LoggingMetadataUpdate = "LoggingMetadataUpdate";
        internal const string LoggingSeedingDatabase = "LoggingSeedingDatabase";
        internal const string LoggingPendingMigrations = "LoggingPendingMigrations";
        internal const string LoggingPendingMigrationsDown = "LoggingPendingMigrationsDown";
        internal const string LoggingNoExplicitMigrations = "LoggingNoExplicitMigrations";
        internal const string LoggingAlreadyAtTarget = "LoggingAlreadyAtTarget";
        internal const string LoggingTargetDatabase = "LoggingTargetDatabase";
        internal const string LoggingTargetDatabaseFormat = "LoggingTargetDatabaseFormat";
        internal const string LoggingExplicit = "LoggingExplicit";
        internal const string UpgradingHistoryTable = "UpgradingHistoryTable";
        internal const string MetadataOutOfDate = "MetadataOutOfDate";
        internal const string MigrationNotFound = "MigrationNotFound";
        internal const string PartialFkOperation = "PartialFkOperation";
        internal const string AutoNotValidTarget = "AutoNotValidTarget";
        internal const string AutoNotValidForScriptWindows = "AutoNotValidForScriptWindows";
        internal const string ContextNotConstructible = "ContextNotConstructible";
        internal const string AmbiguousMigrationName = "AmbiguousMigrationName";
        internal const string AutomaticDisabledException = "AutomaticDisabledException";
        internal const string DownScriptWindowsNotSupported = "DownScriptWindowsNotSupported";
        internal const string AssemblyMigrator_NoConfigurationWithName = "AssemblyMigrator_NoConfigurationWithName";
        internal const string AssemblyMigrator_MultipleConfigurationsWithName = "AssemblyMigrator_MultipleConfigurationsWithName";
        internal const string AssemblyMigrator_NoConfiguration = "AssemblyMigrator_NoConfiguration";
        internal const string AssemblyMigrator_MultipleConfigurations = "AssemblyMigrator_MultipleConfigurations";
        internal const string SqlCeColumnRenameNotSupported = "SqlCeColumnRenameNotSupported";
        internal const string MigrationsNamespaceNotUnderRootNamespace = "MigrationsNamespaceNotUnderRootNamespace";
        internal const string UnableToDispatchAddOrUpdate = "UnableToDispatchAddOrUpdate";
        internal const string NoSqlGeneratorForProvider = "NoSqlGeneratorForProvider";
        internal const string ToolingFacade_AssemblyNotFound = "ToolingFacade_AssemblyNotFound";
        internal const string ArgumentIsNullOrWhitespace = "ArgumentIsNullOrWhitespace";
        internal const string ArgumentPropertyIsNull = "ArgumentPropertyIsNull";
        internal const string PreconditionFailed = "PreconditionFailed";
        internal const string EntityTypeConfigurationMismatch = "EntityTypeConfigurationMismatch";
        internal const string ComplexTypeConfigurationMismatch = "ComplexTypeConfigurationMismatch";
        internal const string KeyPropertyNotFound = "KeyPropertyNotFound";
        internal const string ForeignKeyPropertyNotFound = "ForeignKeyPropertyNotFound";
        internal const string PropertyNotFound = "PropertyNotFound";
        internal const string NavigationPropertyNotFound = "NavigationPropertyNotFound";
        internal const string InvalidPropertyExpression = "InvalidPropertyExpression";
        internal const string InvalidComplexPropertyExpression = "InvalidComplexPropertyExpression";
        internal const string InvalidPropertiesExpression = "InvalidPropertiesExpression";
        internal const string InvalidComplexPropertiesExpression = "InvalidComplexPropertiesExpression";
        internal const string DuplicateStructuralTypeConfiguration = "DuplicateStructuralTypeConfiguration";
        internal const string ConflictingPropertyConfiguration = "ConflictingPropertyConfiguration";
        internal const string ConflictingColumnConfiguration = "ConflictingColumnConfiguration";
        internal const string ConflictingConfigurationValue = "ConflictingConfigurationValue";
        internal const string CodeFirstInvalidComplexType = "CodeFirstInvalidComplexType";
        internal const string InvalidEntityType = "InvalidEntityType";
        internal const string NavigationInverseItself = "NavigationInverseItself";
        internal const string ConflictingConstraint = "ConflictingConstraint";
        internal const string ConflictingInferredColumnType = "ConflictingInferredColumnType";
        internal const string ConflictingMapping = "ConflictingMapping";
        internal const string ConflictingCascadeDeleteOperation = "ConflictingCascadeDeleteOperation";
        internal const string ConflictingMultiplicities = "ConflictingMultiplicities";
        internal const string MaxLengthAttributeConvention_InvalidMaxLength = "MaxLengthAttributeConvention_InvalidMaxLength";
        internal const string StringLengthAttributeConvention_InvalidMaximumLength = "StringLengthAttributeConvention_InvalidMaximumLength";
        internal const string ModelGeneration_UnableToDetermineKeyOrder = "ModelGeneration_UnableToDetermineKeyOrder";
        internal const string ForeignKeyAttributeConvention_EmptyKey = "ForeignKeyAttributeConvention_EmptyKey";
        internal const string ForeignKeyAttributeConvention_InvalidKey = "ForeignKeyAttributeConvention_InvalidKey";

        internal const string ForeignKeyAttributeConvention_InvalidNavigationProperty =
            "ForeignKeyAttributeConvention_InvalidNavigationProperty";

        internal const string ForeignKeyAttributeConvention_OrderRequired = "ForeignKeyAttributeConvention_OrderRequired";
        internal const string InversePropertyAttributeConvention_PropertyNotFound = "InversePropertyAttributeConvention_PropertyNotFound";

        internal const string InversePropertyAttributeConvention_SelfInverseDetected =
            "InversePropertyAttributeConvention_SelfInverseDetected";

        internal const string ValidationHeader = "ValidationHeader";
        internal const string ValidationItemFormat = "ValidationItemFormat";
        internal const string KeyRegisteredOnDerivedType = "KeyRegisteredOnDerivedType";
        internal const string DuplicateEntryInUserDictionary = "DuplicateEntryInUserDictionary";
        internal const string InvalidTableMapping = "InvalidTableMapping";
        internal const string InvalidTableMapping_NoTableName = "InvalidTableMapping_NoTableName";
        internal const string InvalidChainedMappingSyntax = "InvalidChainedMappingSyntax";
        internal const string InvalidNotNullCondition = "InvalidNotNullCondition";
        internal const string InvalidDiscriminatorType = "InvalidDiscriminatorType";
        internal const string ConventionNotFound = "ConventionNotFound";
        internal const string InvalidEntitySplittingProperties = "InvalidEntitySplittingProperties";
        internal const string ModelBuilder_ProviderNameNotFound = "ModelBuilder_ProviderNameNotFound";
        internal const string InvalidDatabaseName = "InvalidDatabaseName";

        internal const string EntityMappingConfiguration_DuplicateMapInheritedProperties =
            "EntityMappingConfiguration_DuplicateMapInheritedProperties";

        internal const string EntityMappingConfiguration_DuplicateMappedProperties = "EntityMappingConfiguration_DuplicateMappedProperties";
        internal const string EntityMappingConfiguration_DuplicateMappedProperty = "EntityMappingConfiguration_DuplicateMappedProperty";
        internal const string EntityMappingConfiguration_CannotMapIgnoredProperty = "EntityMappingConfiguration_CannotMapIgnoredProperty";
        internal const string EntityMappingConfiguration_InvalidTableSharing = "EntityMappingConfiguration_InvalidTableSharing";
        internal const string CannotIgnoreMappedBaseProperty = "CannotIgnoreMappedBaseProperty";
        internal const string ModelBuilder_KeyPropertiesMustBePrimitive = "ModelBuilder_KeyPropertiesMustBePrimitive";
        internal const string TableNotFound = "TableNotFound";
        internal const string IncorrectColumnCount = "IncorrectColumnCount";
        internal const string CircularComplexTypeHierarchy = "CircularComplexTypeHierarchy";
        internal const string UnableToDeterminePrincipal = "UnableToDeterminePrincipal";
        internal const string UnmappedAbstractType = "UnmappedAbstractType";
        internal const string UnsupportedHybridInheritanceMapping = "UnsupportedHybridInheritanceMapping";
        internal const string OrphanedConfiguredTableDetected = "OrphanedConfiguredTableDetected";
        internal const string DuplicateConfiguredColumnOrder = "DuplicateConfiguredColumnOrder";
        internal const string UnsupportedUseOfV3Type = "UnsupportedUseOfV3Type";
        internal const string MultiplePropertiesMatchedAsKeys = "MultiplePropertiesMatchedAsKeys";
        internal const string BadLocalDBDatabaseName = "BadLocalDBDatabaseName";
        internal const string FailedToGetProviderInformation = "FailedToGetProviderInformation";
        internal const string DbPropertyEntry_CannotGetCurrentValue = "DbPropertyEntry_CannotGetCurrentValue";
        internal const string DbPropertyEntry_CannotSetCurrentValue = "DbPropertyEntry_CannotSetCurrentValue";
        internal const string DbPropertyEntry_NotSupportedForDetached = "DbPropertyEntry_NotSupportedForDetached";
        internal const string DbPropertyEntry_SettingEntityRefNotSupported = "DbPropertyEntry_SettingEntityRefNotSupported";

        internal const string DbPropertyEntry_NotSupportedForPropertiesNotInTheModel =
            "DbPropertyEntry_NotSupportedForPropertiesNotInTheModel";

        internal const string DbEntityEntry_NotSupportedForDetached = "DbEntityEntry_NotSupportedForDetached";
        internal const string DbSet_BadTypeForAddAttachRemove = "DbSet_BadTypeForAddAttachRemove";
        internal const string DbSet_BadTypeForCreate = "DbSet_BadTypeForCreate";
        internal const string DbEntity_BadTypeForCast = "DbEntity_BadTypeForCast";
        internal const string DbMember_BadTypeForCast = "DbMember_BadTypeForCast";
        internal const string DbEntityEntry_UsedReferenceForCollectionProp = "DbEntityEntry_UsedReferenceForCollectionProp";
        internal const string DbEntityEntry_UsedCollectionForReferenceProp = "DbEntityEntry_UsedCollectionForReferenceProp";
        internal const string DbEntityEntry_NotANavigationProperty = "DbEntityEntry_NotANavigationProperty";
        internal const string DbEntityEntry_NotAScalarProperty = "DbEntityEntry_NotAScalarProperty";
        internal const string DbEntityEntry_NotAComplexProperty = "DbEntityEntry_NotAComplexProperty";
        internal const string DbEntityEntry_NotAProperty = "DbEntityEntry_NotAProperty";
        internal const string DbEntityEntry_DottedPartNotComplex = "DbEntityEntry_DottedPartNotComplex";
        internal const string DbPropertyEntry_CannotMarkPropertyUnmodified = "DbPropertyEntry_CannotMarkPropertyUnmodified";
        internal const string DbEntityEntry_DottedPathMustBeProperty = "DbEntityEntry_DottedPathMustBeProperty";
        internal const string DbEntityEntry_WrongGenericForNavProp = "DbEntityEntry_WrongGenericForNavProp";
        internal const string DbEntityEntry_WrongGenericForCollectionNavProp = "DbEntityEntry_WrongGenericForCollectionNavProp";
        internal const string DbEntityEntry_WrongGenericForProp = "DbEntityEntry_WrongGenericForProp";
        internal const string DbEntityEntry_BadPropertyExpression = "DbEntityEntry_BadPropertyExpression";
        internal const string DbContext_IndependentAssociationUpdateException = "DbContext_IndependentAssociationUpdateException";
        internal const string DbPropertyValues_CannotGetValuesForState = "DbPropertyValues_CannotGetValuesForState";
        internal const string DbPropertyValues_CannotSetNullValue = "DbPropertyValues_CannotSetNullValue";

        internal const string DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull =
            "DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull";

        internal const string DbPropertyValues_WrongTypeForAssignment = "DbPropertyValues_WrongTypeForAssignment";
        internal const string DbPropertyValues_PropertyValueNamesAreReadonly = "DbPropertyValues_PropertyValueNamesAreReadonly";
        internal const string DbPropertyValues_PropertyDoesNotExist = "DbPropertyValues_PropertyDoesNotExist";
        internal const string DbPropertyValues_AttemptToSetValuesFromWrongObject = "DbPropertyValues_AttemptToSetValuesFromWrongObject";
        internal const string DbPropertyValues_AttemptToSetValuesFromWrongType = "DbPropertyValues_AttemptToSetValuesFromWrongType";

        internal const string DbPropertyValues_AttemptToSetNonValuesOnComplexProperty =
            "DbPropertyValues_AttemptToSetNonValuesOnComplexProperty";

        internal const string DbPropertyValues_ComplexObjectCannotBeNull = "DbPropertyValues_ComplexObjectCannotBeNull";
        internal const string DbPropertyValues_NestedPropertyValuesNull = "DbPropertyValues_NestedPropertyValuesNull";
        internal const string DbPropertyValues_CannotSetPropertyOnNullCurrentValue = "DbPropertyValues_CannotSetPropertyOnNullCurrentValue";

        internal const string DbPropertyValues_CannotSetPropertyOnNullOriginalValue =
            "DbPropertyValues_CannotSetPropertyOnNullOriginalValue";

        internal const string DatabaseInitializationStrategy_ModelMismatch = "DatabaseInitializationStrategy_ModelMismatch";
        internal const string Database_DatabaseAlreadyExists = "Database_DatabaseAlreadyExists";
        internal const string Database_NonCodeFirstCompatibilityCheck = "Database_NonCodeFirstCompatibilityCheck";
        internal const string Database_MetadataNotMapped = "Database_MetadataNotMapped";
        internal const string Database_NoDatabaseMetadata = "Database_NoDatabaseMetadata";
        internal const string Database_BadLegacyInitializerEntry = "Database_BadLegacyInitializerEntry";
        internal const string Database_InitializeFromLegacyConfigFailed = "Database_InitializeFromLegacyConfigFailed";
        internal const string Database_InitializeFromConfigFailed = "Database_InitializeFromConfigFailed";
        internal const string ContextConfiguredMultipleTimes = "ContextConfiguredMultipleTimes";
        internal const string SetConnectionFactoryFromConfigFailed = "SetConnectionFactoryFromConfigFailed";
        internal const string Database_FailedToResolveType = "Database_FailedToResolveType";
        internal const string DbContext_ContextUsedInModelCreating = "DbContext_ContextUsedInModelCreating";
        internal const string DbContext_MESTNotSupported = "DbContext_MESTNotSupported";
        internal const string DbContext_Disposed = "DbContext_Disposed";
        internal const string DbContext_ProviderReturnedNullConnection = "DbContext_ProviderReturnedNullConnection";
        internal const string DbContext_ProviderNameMissing = "DbContext_ProviderNameMissing";
        internal const string DbContext_ConnectionFactoryReturnedNullConnection = "DbContext_ConnectionFactoryReturnedNullConnection";
        internal const string DbSet_WrongNumberOfKeyValuesPassed = "DbSet_WrongNumberOfKeyValuesPassed";
        internal const string DbSet_WrongKeyValueType = "DbSet_WrongKeyValueType";
        internal const string DbSet_WrongEntityTypeFound = "DbSet_WrongEntityTypeFound";
        internal const string DbSet_MultipleAddedEntitiesFound = "DbSet_MultipleAddedEntitiesFound";
        internal const string DbSet_DbSetUsedWithComplexType = "DbSet_DbSetUsedWithComplexType";
        internal const string DbSet_PocoAndNonPocoMixedInSameAssembly = "DbSet_PocoAndNonPocoMixedInSameAssembly";
        internal const string DbSet_EntityTypeNotInModel = "DbSet_EntityTypeNotInModel";
        internal const string DbQuery_BindingToDbQueryNotSupported = "DbQuery_BindingToDbQueryNotSupported";
        internal const string DbExtensions_InvalidIncludePathExpression = "DbExtensions_InvalidIncludePathExpression";
        internal const string DbContext_ConnectionStringNotFound = "DbContext_ConnectionStringNotFound";
        internal const string DbContext_ConnectionHasModel = "DbContext_ConnectionHasModel";
        internal const string DbCollectionEntry_CannotSetCollectionProp = "DbCollectionEntry_CannotSetCollectionProp";

        internal const string CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported =
            "CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported";

        internal const string Mapping_MESTNotSupported = "Mapping_MESTNotSupported";
        internal const string DbModelBuilder_MissingRequiredCtor = "DbModelBuilder_MissingRequiredCtor";
        internal const string DbEntityValidationException_ValidationFailed = "DbEntityValidationException_ValidationFailed";
        internal const string DbUnexpectedValidationException_ValidationAttribute = "DbUnexpectedValidationException_ValidationAttribute";
        internal const string DbUnexpectedValidationException_IValidatableObject = "DbUnexpectedValidationException_IValidatableObject";
        internal const string SqlConnectionFactory_MdfNotSupported = "SqlConnectionFactory_MdfNotSupported";
        internal const string Database_InitializationException = "Database_InitializationException";
        internal const string EdmxWriter_EdmxFromObjectContextNotSupported = "EdmxWriter_EdmxFromObjectContextNotSupported";
        internal const string EdmxWriter_EdmxFromDbCompiledModelNotSupported = "EdmxWriter_EdmxFromDbCompiledModelNotSupported";
        internal const string EdmxWriter_EdmxFromModelFirstNotSupported = "EdmxWriter_EdmxFromModelFirstNotSupported";
        internal const string UnintentionalCodeFirstException_Message = "UnintentionalCodeFirstException_Message";
        internal const string DbContextServices_MissingDefaultCtor = "DbContextServices_MissingDefaultCtor";
        internal const string CannotCallGenericSetWithProxyType = "CannotCallGenericSetWithProxyType";
        internal const string EdmPrimitiveType_SetPropertyNotSupported = "EdmPrimitiveType_SetPropertyNotSupported";

        internal const string EdmModel_Validator_Semantic_SystemNamespaceEncountered =
            "EdmModel_Validator_Semantic_SystemNamespaceEncountered";

        internal const string EdmModel_Validator_Semantic_SimilarRelationshipEnd = "EdmModel_Validator_Semantic_SimilarRelationshipEnd";

        internal const string EdmModel_Validator_Semantic_InvalidEntitySetNameReference =
            "EdmModel_Validator_Semantic_InvalidEntitySetNameReference";

        internal const string EdmModel_Validator_Semantic_ConcurrencyRedefinedOnSubTypeOfEntitySetType =
            "EdmModel_Validator_Semantic_ConcurrencyRedefinedOnSubTypeOfEntitySetType";

        internal const string EdmModel_Validator_Semantic_EntitySetTypeHasNoKeys = "EdmModel_Validator_Semantic_EntitySetTypeHasNoKeys";
        internal const string EdmModel_Validator_Semantic_DuplicateEndName = "EdmModel_Validator_Semantic_DuplicateEndName";

        internal const string EdmModel_Validator_Semantic_DuplicatePropertyNameSpecifiedInEntityKey =
            "EdmModel_Validator_Semantic_DuplicatePropertyNameSpecifiedInEntityKey";

        internal const string EdmModel_Validator_Semantic_InvalidCollectionKindNotCollection =
            "EdmModel_Validator_Semantic_InvalidCollectionKindNotCollection";

        internal const string EdmModel_Validator_Semantic_InvalidCollectionKindNotV1_1 =
            "EdmModel_Validator_Semantic_InvalidCollectionKindNotV1_1";

        internal const string EdmModel_Validator_Semantic_InvalidComplexTypeAbstract =
            "EdmModel_Validator_Semantic_InvalidComplexTypeAbstract";

        internal const string EdmModel_Validator_Semantic_InvalidComplexTypePolymorphic =
            "EdmModel_Validator_Semantic_InvalidComplexTypePolymorphic";

        internal const string EdmModel_Validator_Semantic_InvalidKeyNullablePart = "EdmModel_Validator_Semantic_InvalidKeyNullablePart";
        internal const string EdmModel_Validator_Semantic_EntityKeyMustBeScalar = "EdmModel_Validator_Semantic_EntityKeyMustBeScalar";

        internal const string EdmModel_Validator_Semantic_InvalidKeyKeyDefinedInBaseClass =
            "EdmModel_Validator_Semantic_InvalidKeyKeyDefinedInBaseClass";

        internal const string EdmModel_Validator_Semantic_KeyMissingOnEntityType = "EdmModel_Validator_Semantic_KeyMissingOnEntityType";

        internal const string EdmModel_Validator_Semantic_BadNavigationPropertyUndefinedRole =
            "EdmModel_Validator_Semantic_BadNavigationPropertyUndefinedRole";

        internal const string EdmModel_Validator_Semantic_BadNavigationPropertyRolesCannotBeTheSame =
            "EdmModel_Validator_Semantic_BadNavigationPropertyRolesCannotBeTheSame";

        internal const string EdmModel_Validator_Semantic_InvalidOperationMultipleEndsInAssociation =
            "EdmModel_Validator_Semantic_InvalidOperationMultipleEndsInAssociation";

        internal const string EdmModel_Validator_Semantic_EndWithManyMultiplicityCannotHaveOperationsSpecified =
            "EdmModel_Validator_Semantic_EndWithManyMultiplicityCannotHaveOperationsSpecified";

        internal const string EdmModel_Validator_Semantic_EndNameAlreadyDefinedDuplicate =
            "EdmModel_Validator_Semantic_EndNameAlreadyDefinedDuplicate";

        internal const string EdmModel_Validator_Semantic_SameRoleReferredInReferentialConstraint =
            "EdmModel_Validator_Semantic_SameRoleReferredInReferentialConstraint";

        internal const string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleUpperBoundMustBeOne =
            "EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleUpperBoundMustBeOne";

        internal const string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNullableV1 =
            "EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNullableV1";

        internal const string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV1 =
            "EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV1";

        internal const string EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV2 =
            "EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV2";

        internal const string EdmModel_Validator_Semantic_InvalidToPropertyInRelationshipConstraint =
            "EdmModel_Validator_Semantic_InvalidToPropertyInRelationshipConstraint";

        internal const string EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeOne =
            "EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeOne";

        internal const string EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeMany =
            "EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeMany";

        internal const string EdmModel_Validator_Semantic_MismatchNumberOfPropertiesinRelationshipConstraint =
            "EdmModel_Validator_Semantic_MismatchNumberOfPropertiesinRelationshipConstraint";

        internal const string EdmModel_Validator_Semantic_TypeMismatchRelationshipConstraint =
            "EdmModel_Validator_Semantic_TypeMismatchRelationshipConstraint";

        internal const string EdmModel_Validator_Semantic_InvalidPropertyInRelationshipConstraint =
            "EdmModel_Validator_Semantic_InvalidPropertyInRelationshipConstraint";

        internal const string EdmModel_Validator_Semantic_NullableComplexType = "EdmModel_Validator_Semantic_NullableComplexType";
        internal const string EdmModel_Validator_Semantic_InvalidPropertyType = "EdmModel_Validator_Semantic_InvalidPropertyType";

        internal const string EdmModel_Validator_Semantic_DuplicateEntityContainerMemberName =
            "EdmModel_Validator_Semantic_DuplicateEntityContainerMemberName";

        internal const string EdmModel_Validator_Semantic_TypeNameAlreadyDefinedDuplicate =
            "EdmModel_Validator_Semantic_TypeNameAlreadyDefinedDuplicate";

        internal const string EdmModel_Validator_Semantic_InvalidMemberNameMatchesTypeName =
            "EdmModel_Validator_Semantic_InvalidMemberNameMatchesTypeName";

        internal const string EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate =
            "EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate";

        internal const string EdmModel_Validator_Semantic_CycleInTypeHierarchy = "EdmModel_Validator_Semantic_CycleInTypeHierarchy";
        internal const string EdmModel_Validator_Semantic_InvalidPropertyType_V1_1 = "EdmModel_Validator_Semantic_InvalidPropertyType_V1_1";
        internal const string EdmModel_Validator_Semantic_InvalidPropertyType_V3 = "EdmModel_Validator_Semantic_InvalidPropertyType_V3";
        internal const string EdmModel_Validator_Syntactic_MissingName = "EdmModel_Validator_Syntactic_MissingName";
        internal const string EdmModel_Validator_Syntactic_EdmModel_NameIsTooLong = "EdmModel_Validator_Syntactic_EdmModel_NameIsTooLong";

        internal const string EdmModel_Validator_Syntactic_EdmModel_NameIsNotAllowed =
            "EdmModel_Validator_Syntactic_EdmModel_NameIsNotAllowed";

        internal const string EdmModel_Validator_Syntactic_EdmAssociationType_AssocationEndMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmAssociationType_AssocationEndMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentEndMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentEndMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentPropertiesMustNotBeEmpty =
            "EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentPropertiesMustNotBeEmpty";

        internal const string EdmModel_Validator_Syntactic_EdmNavigationProperty_AssocationMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmNavigationProperty_AssocationMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmNavigationProperty_ResultEndMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmNavigationProperty_ResultEndMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmAssociationEnd_EntityTypeMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmAssociationEnd_EntityTypeMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmEntitySet_ElementTypeMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmEntitySet_ElementTypeMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmAssociationSet_ElementTypeMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmAssociationSet_ElementTypeMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmAssociationSet_SourceSetMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmAssociationSet_SourceSetMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmAssociationSet_TargetSetMustNotBeNull =
            "EdmModel_Validator_Syntactic_EdmAssociationSet_TargetSetMustNotBeNull";

        internal const string EdmModel_Validator_Syntactic_EdmTypeReferenceNotValid =
            "EdmModel_Validator_Syntactic_EdmTypeReferenceNotValid";

        internal const string Serializer_OneNamespaceAndOneContainer = "Serializer_OneNamespaceAndOneContainer";
        internal const string MaxLengthAttribute_ValidationError = "MaxLengthAttribute_ValidationError";
        internal const string MaxLengthAttribute_InvalidMaxLength = "MaxLengthAttribute_InvalidMaxLength";
        internal const string MinLengthAttribute_ValidationError = "MinLengthAttribute_ValidationError";
        internal const string MinLengthAttribute_InvalidMinLength = "MinLengthAttribute_InvalidMinLength";
        internal const string DbConnectionInfo_ConnectionStringNotFound = "DbConnectionInfo_ConnectionStringNotFound";
        internal const string EagerInternalContext_CannotSetConnectionInfo = "EagerInternalContext_CannotSetConnectionInfo";

        internal const string LazyInternalContext_CannotReplaceEfConnectionWithDbConnection =
            "LazyInternalContext_CannotReplaceEfConnectionWithDbConnection";

        internal const string LazyInternalContext_CannotReplaceDbConnectionWithEfConnection =
            "LazyInternalContext_CannotReplaceDbConnectionWithEfConnection";

        internal const string EntityKey_DataRecordMustBeEntity = "EntityKey_DataRecordMustBeEntity";
        internal const string EntityKey_EntitySetDoesNotMatch = "EntityKey_EntitySetDoesNotMatch";
        internal const string EntityKey_EntityTypesDoNotMatch = "EntityKey_EntityTypesDoNotMatch";
        internal const string EntityKey_IncorrectNumberOfKeyValuePairs = "EntityKey_IncorrectNumberOfKeyValuePairs";
        internal const string EntityKey_IncorrectValueType = "EntityKey_IncorrectValueType";
        internal const string EntityKey_NoCorrespondingOSpaceTypeForEnumKeyMember = "EntityKey_NoCorrespondingOSpaceTypeForEnumKeyMember";
        internal const string EntityKey_MissingKeyValue = "EntityKey_MissingKeyValue";
        internal const string EntityKey_NoNullsAllowedInKeyValuePairs = "EntityKey_NoNullsAllowedInKeyValuePairs";
        internal const string EntityKey_UnexpectedNull = "EntityKey_UnexpectedNull";
        internal const string EntityKey_DoesntMatchKeyOnEntity = "EntityKey_DoesntMatchKeyOnEntity";
        internal const string EntityKey_EntityKeyMustHaveValues = "EntityKey_EntityKeyMustHaveValues";
        internal const string EntityKey_InvalidQualifiedEntitySetName = "EntityKey_InvalidQualifiedEntitySetName";
        internal const string EntityKey_MissingEntitySetName = "EntityKey_MissingEntitySetName";
        internal const string EntityKey_InvalidName = "EntityKey_InvalidName";
        internal const string EntityKey_CannotChangeKey = "EntityKey_CannotChangeKey";
        internal const string EntityTypesDoNotAgree = "EntityTypesDoNotAgree";
        internal const string EntityKey_NullKeyValue = "EntityKey_NullKeyValue";
        internal const string EdmMembersDefiningTypeDoNotAgreeWithMetadataType = "EdmMembersDefiningTypeDoNotAgreeWithMetadataType";
        internal const string InvalidStringArgument = "InvalidStringArgument";
        internal const string CannotCallNoncomposableFunction = "CannotCallNoncomposableFunction";
        internal const string EntityClient_ConnectionStringMissingInfo = "EntityClient_ConnectionStringMissingInfo";
        internal const string EntityClient_ValueNotString = "EntityClient_ValueNotString";
        internal const string EntityClient_KeywordNotSupported = "EntityClient_KeywordNotSupported";
        internal const string EntityClient_NoCommandText = "EntityClient_NoCommandText";
        internal const string EntityClient_ConnectionStringNeededBeforeOperation = "EntityClient_ConnectionStringNeededBeforeOperation";
        internal const string EntityClient_CannotReopenConnection = "EntityClient_CannotReopenConnection";
        internal const string EntityClient_ConnectionNotOpen = "EntityClient_ConnectionNotOpen";
        internal const string EntityClient_DuplicateParameterNames = "EntityClient_DuplicateParameterNames";
        internal const string EntityClient_NoConnectionForCommand = "EntityClient_NoConnectionForCommand";
        internal const string EntityClient_NoConnectionForAdapter = "EntityClient_NoConnectionForAdapter";
        internal const string EntityClient_ClosedConnectionForUpdate = "EntityClient_ClosedConnectionForUpdate";
        internal const string EntityClient_InvalidNamedConnection = "EntityClient_InvalidNamedConnection";
        internal const string EntityClient_NestedNamedConnection = "EntityClient_NestedNamedConnection";
        internal const string EntityClient_InvalidStoreProvider = "EntityClient_InvalidStoreProvider";
        internal const string EntityClient_DataReaderIsStillOpen = "EntityClient_DataReaderIsStillOpen";
        internal const string EntityClient_SettingsCannotBeChangedOnOpenConnection = "EntityClient_SettingsCannotBeChangedOnOpenConnection";
        internal const string EntityClient_ExecutingOnClosedConnection = "EntityClient_ExecutingOnClosedConnection";
        internal const string EntityClient_ConnectionStateClosed = "EntityClient_ConnectionStateClosed";
        internal const string EntityClient_ConnectionStateBroken = "EntityClient_ConnectionStateBroken";
        internal const string EntityClient_CannotCloneStoreProvider = "EntityClient_CannotCloneStoreProvider";
        internal const string EntityClient_UnsupportedCommandType = "EntityClient_UnsupportedCommandType";
        internal const string EntityClient_ErrorInClosingConnection = "EntityClient_ErrorInClosingConnection";
        internal const string EntityClient_ErrorInBeginningTransaction = "EntityClient_ErrorInBeginningTransaction";
        internal const string EntityClient_ExtraParametersWithNamedConnection = "EntityClient_ExtraParametersWithNamedConnection";
        internal const string EntityClient_CommandDefinitionPreparationFailed = "EntityClient_CommandDefinitionPreparationFailed";
        internal const string EntityClient_CommandDefinitionExecutionFailed = "EntityClient_CommandDefinitionExecutionFailed";
        internal const string EntityClient_CommandExecutionFailed = "EntityClient_CommandExecutionFailed";
        internal const string EntityClient_StoreReaderFailed = "EntityClient_StoreReaderFailed";
        internal const string EntityClient_FailedToGetInformation = "EntityClient_FailedToGetInformation";
        internal const string EntityClient_TooFewColumns = "EntityClient_TooFewColumns";
        internal const string EntityClient_InvalidParameterName = "EntityClient_InvalidParameterName";
        internal const string EntityClient_EmptyParameterName = "EntityClient_EmptyParameterName";
        internal const string EntityClient_ReturnedNullOnProviderMethod = "EntityClient_ReturnedNullOnProviderMethod";
        internal const string EntityClient_CannotDeduceDbType = "EntityClient_CannotDeduceDbType";
        internal const string EntityClient_InvalidParameterDirection = "EntityClient_InvalidParameterDirection";
        internal const string EntityClient_UnknownParameterType = "EntityClient_UnknownParameterType";
        internal const string EntityClient_UnsupportedDbType = "EntityClient_UnsupportedDbType";
        internal const string EntityClient_DoesNotImplementIServiceProvider = "EntityClient_DoesNotImplementIServiceProvider";
        internal const string EntityClient_IncompatibleNavigationPropertyResult = "EntityClient_IncompatibleNavigationPropertyResult";
        internal const string EntityClient_TransactionAlreadyStarted = "EntityClient_TransactionAlreadyStarted";
        internal const string EntityClient_InvalidTransactionForCommand = "EntityClient_InvalidTransactionForCommand";
        internal const string EntityClient_NoStoreConnectionForUpdate = "EntityClient_NoStoreConnectionForUpdate";
        internal const string EntityClient_CommandTreeMetadataIncompatible = "EntityClient_CommandTreeMetadataIncompatible";
        internal const string EntityClient_ProviderGeneralError = "EntityClient_ProviderGeneralError";
        internal const string EntityClient_ProviderSpecificError = "EntityClient_ProviderSpecificError";
        internal const string EntityClient_FunctionImportEmptyCommandText = "EntityClient_FunctionImportEmptyCommandText";
        internal const string EntityClient_UnableToFindFunctionImportContainer = "EntityClient_UnableToFindFunctionImportContainer";
        internal const string EntityClient_UnableToFindFunctionImport = "EntityClient_UnableToFindFunctionImport";
        internal const string EntityClient_FunctionImportMustBeNonComposable = "EntityClient_FunctionImportMustBeNonComposable";
        internal const string EntityClient_UnmappedFunctionImport = "EntityClient_UnmappedFunctionImport";
        internal const string EntityClient_InvalidStoredProcedureCommandText = "EntityClient_InvalidStoredProcedureCommandText";
        internal const string EntityClient_ItemCollectionsNotRegisteredInWorkspace = "EntityClient_ItemCollectionsNotRegisteredInWorkspace";
        internal const string EntityClient_ConnectionMustBeClosed = "EntityClient_ConnectionMustBeClosed";
        internal const string EntityClient_DbConnectionHasNoProvider = "EntityClient_DbConnectionHasNoProvider";
        internal const string EntityClient_RequiresNonStoreCommandTree = "EntityClient_RequiresNonStoreCommandTree";

        internal const string EntityClient_CannotReprepareCommandDefinitionBasedCommand =
            "EntityClient_CannotReprepareCommandDefinitionBasedCommand";

        internal const string EntityClient_EntityParameterEdmTypeNotScalar = "EntityClient_EntityParameterEdmTypeNotScalar";
        internal const string EntityClient_EntityParameterInconsistentEdmType = "EntityClient_EntityParameterInconsistentEdmType";
        internal const string EntityClient_CannotGetCommandText = "EntityClient_CannotGetCommandText";
        internal const string EntityClient_CannotSetCommandText = "EntityClient_CannotSetCommandText";
        internal const string EntityClient_CannotGetCommandTree = "EntityClient_CannotGetCommandTree";
        internal const string EntityClient_CannotSetCommandTree = "EntityClient_CannotSetCommandTree";
        internal const string ELinq_ExpressionMustBeIQueryable = "ELinq_ExpressionMustBeIQueryable";
        internal const string ELinq_UnsupportedExpressionType = "ELinq_UnsupportedExpressionType";
        internal const string ELinq_UnsupportedUseOfContextParameter = "ELinq_UnsupportedUseOfContextParameter";
        internal const string ELinq_UnboundParameterExpression = "ELinq_UnboundParameterExpression";
        internal const string ELinq_UnsupportedConstructor = "ELinq_UnsupportedConstructor";
        internal const string ELinq_UnsupportedInitializers = "ELinq_UnsupportedInitializers";
        internal const string ELinq_UnsupportedBinding = "ELinq_UnsupportedBinding";
        internal const string ELinq_UnsupportedMethod = "ELinq_UnsupportedMethod";
        internal const string ELinq_UnsupportedMethodSuggestedAlternative = "ELinq_UnsupportedMethodSuggestedAlternative";
        internal const string ELinq_ThenByDoesNotFollowOrderBy = "ELinq_ThenByDoesNotFollowOrderBy";
        internal const string ELinq_UnrecognizedMember = "ELinq_UnrecognizedMember";
        internal const string ELinq_UnresolvableFunctionForMethod = "ELinq_UnresolvableFunctionForMethod";
        internal const string ELinq_UnresolvableFunctionForMethodAmbiguousMatch = "ELinq_UnresolvableFunctionForMethodAmbiguousMatch";
        internal const string ELinq_UnresolvableFunctionForMethodNotFound = "ELinq_UnresolvableFunctionForMethodNotFound";
        internal const string ELinq_UnresolvableFunctionForMember = "ELinq_UnresolvableFunctionForMember";
        internal const string ELinq_UnresolvableStoreFunctionForMember = "ELinq_UnresolvableStoreFunctionForMember";
        internal const string ELinq_UnresolvableFunctionForExpression = "ELinq_UnresolvableFunctionForExpression";
        internal const string ELinq_UnresolvableStoreFunctionForExpression = "ELinq_UnresolvableStoreFunctionForExpression";
        internal const string ELinq_UnsupportedType = "ELinq_UnsupportedType";
        internal const string ELinq_UnsupportedNullConstant = "ELinq_UnsupportedNullConstant";
        internal const string ELinq_UnsupportedConstant = "ELinq_UnsupportedConstant";
        internal const string ELinq_UnsupportedCast = "ELinq_UnsupportedCast";
        internal const string ELinq_UnsupportedIsOrAs = "ELinq_UnsupportedIsOrAs";
        internal const string ELinq_UnsupportedQueryableMethod = "ELinq_UnsupportedQueryableMethod";
        internal const string ELinq_InvalidOfTypeResult = "ELinq_InvalidOfTypeResult";
        internal const string ELinq_UnsupportedNominalType = "ELinq_UnsupportedNominalType";
        internal const string ELinq_UnsupportedEnumerableType = "ELinq_UnsupportedEnumerableType";
        internal const string ELinq_UnsupportedHeterogeneousInitializers = "ELinq_UnsupportedHeterogeneousInitializers";
        internal const string ELinq_UnsupportedDifferentContexts = "ELinq_UnsupportedDifferentContexts";
        internal const string ELinq_UnsupportedCastToDecimal = "ELinq_UnsupportedCastToDecimal";
        internal const string ELinq_UnsupportedKeySelector = "ELinq_UnsupportedKeySelector";
        internal const string ELinq_CreateOrderedEnumerableNotSupported = "ELinq_CreateOrderedEnumerableNotSupported";
        internal const string ELinq_UnsupportedPassthrough = "ELinq_UnsupportedPassthrough";
        internal const string ELinq_UnexpectedTypeForNavigationProperty = "ELinq_UnexpectedTypeForNavigationProperty";
        internal const string ELinq_SkipWithoutOrder = "ELinq_SkipWithoutOrder";
        internal const string ELinq_PropertyIndexNotSupported = "ELinq_PropertyIndexNotSupported";
        internal const string ELinq_NotPropertyOrField = "ELinq_NotPropertyOrField";
        internal const string ELinq_UnsupportedStringRemoveCase = "ELinq_UnsupportedStringRemoveCase";
        internal const string ELinq_UnsupportedTrimStartTrimEndCase = "ELinq_UnsupportedTrimStartTrimEndCase";
        internal const string ELinq_UnsupportedVBDatePartNonConstantInterval = "ELinq_UnsupportedVBDatePartNonConstantInterval";
        internal const string ELinq_UnsupportedVBDatePartInvalidInterval = "ELinq_UnsupportedVBDatePartInvalidInterval";
        internal const string ELinq_UnsupportedAsUnicodeAndAsNonUnicode = "ELinq_UnsupportedAsUnicodeAndAsNonUnicode";
        internal const string ELinq_UnsupportedComparison = "ELinq_UnsupportedComparison";
        internal const string ELinq_UnsupportedRefComparison = "ELinq_UnsupportedRefComparison";
        internal const string ELinq_UnsupportedRowComparison = "ELinq_UnsupportedRowComparison";
        internal const string ELinq_UnsupportedRowMemberComparison = "ELinq_UnsupportedRowMemberComparison";
        internal const string ELinq_UnsupportedRowTypeComparison = "ELinq_UnsupportedRowTypeComparison";
        internal const string ELinq_AnonymousType = "ELinq_AnonymousType";
        internal const string ELinq_ClosureType = "ELinq_ClosureType";
        internal const string ELinq_UnhandledExpressionType = "ELinq_UnhandledExpressionType";
        internal const string ELinq_UnhandledBindingType = "ELinq_UnhandledBindingType";
        internal const string ELinq_UnsupportedNestedFirst = "ELinq_UnsupportedNestedFirst";
        internal const string ELinq_UnsupportedNestedSingle = "ELinq_UnsupportedNestedSingle";
        internal const string ELinq_UnsupportedInclude = "ELinq_UnsupportedInclude";
        internal const string ELinq_UnsupportedMergeAs = "ELinq_UnsupportedMergeAs";
        internal const string ELinq_MethodNotDirectlyCallable = "ELinq_MethodNotDirectlyCallable";
        internal const string ELinq_CycleDetected = "ELinq_CycleDetected";
        internal const string ELinq_DbFunctionAttributeParameterNameNotValid = "ELinq_DbFunctionAttributeParameterNameNotValid";

        internal const string ELinq_DbFunctionAttributedFunctionWithWrongReturnType =
            "ELinq_DbFunctionAttributedFunctionWithWrongReturnType";

        internal const string ELinq_DbFunctionDirectCall = "ELinq_DbFunctionDirectCall";
        internal const string CompiledELinq_UnsupportedParameterTypes = "CompiledELinq_UnsupportedParameterTypes";
        internal const string CompiledELinq_UnsupportedNamedParameterType = "CompiledELinq_UnsupportedNamedParameterType";
        internal const string CompiledELinq_UnsupportedNamedParameterUseAsType = "CompiledELinq_UnsupportedNamedParameterUseAsType";
        internal const string Update_UnsupportedExpressionKind = "Update_UnsupportedExpressionKind";
        internal const string Update_UnsupportedCastArgument = "Update_UnsupportedCastArgument";
        internal const string Update_UnsupportedExtentType = "Update_UnsupportedExtentType";
        internal const string Update_ConstraintCycle = "Update_ConstraintCycle";
        internal const string Update_UnsupportedJoinType = "Update_UnsupportedJoinType";
        internal const string Update_UnsupportedProjection = "Update_UnsupportedProjection";
        internal const string Update_ConcurrencyError = "Update_ConcurrencyError";
        internal const string Update_MissingEntity = "Update_MissingEntity";
        internal const string Update_RelationshipCardinalityConstraintViolation = "Update_RelationshipCardinalityConstraintViolation";
        internal const string Update_GeneralExecutionException = "Update_GeneralExecutionException";
        internal const string Update_MissingRequiredEntity = "Update_MissingRequiredEntity";
        internal const string Update_RelationshipCardinalityViolation = "Update_RelationshipCardinalityViolation";
        internal const string Update_NotSupportedComputedKeyColumn = "Update_NotSupportedComputedKeyColumn";
        internal const string Update_AmbiguousServerGenIdentifier = "Update_AmbiguousServerGenIdentifier";
        internal const string Update_WorkspaceMismatch = "Update_WorkspaceMismatch";
        internal const string Update_MissingRequiredRelationshipValue = "Update_MissingRequiredRelationshipValue";
        internal const string Update_MissingResultColumn = "Update_MissingResultColumn";
        internal const string Update_NullReturnValueForNonNullableMember = "Update_NullReturnValueForNonNullableMember";
        internal const string Update_ReturnValueHasUnexpectedType = "Update_ReturnValueHasUnexpectedType";
        internal const string Update_UnableToConvertRowsAffectedParameter = "Update_UnableToConvertRowsAffectedParameter";
        internal const string Update_MappingNotFound = "Update_MappingNotFound";
        internal const string Update_ModifyingIdentityColumn = "Update_ModifyingIdentityColumn";
        internal const string Update_GeneratedDependent = "Update_GeneratedDependent";
        internal const string Update_ReferentialConstraintIntegrityViolation = "Update_ReferentialConstraintIntegrityViolation";
        internal const string Update_ErrorLoadingRecord = "Update_ErrorLoadingRecord";
        internal const string Update_NullValue = "Update_NullValue";
        internal const string Update_CircularRelationships = "Update_CircularRelationships";

        internal const string Update_RelationshipCardinalityConstraintViolationSingleValue =
            "Update_RelationshipCardinalityConstraintViolationSingleValue";

        internal const string Update_MissingFunctionMapping = "Update_MissingFunctionMapping";
        internal const string Update_InvalidChanges = "Update_InvalidChanges";
        internal const string Update_DuplicateKeys = "Update_DuplicateKeys";
        internal const string Update_AmbiguousForeignKey = "Update_AmbiguousForeignKey";
        internal const string Update_InsertingOrUpdatingReferenceToDeletedEntity = "Update_InsertingOrUpdatingReferenceToDeletedEntity";
        internal const string ViewGen_Extent = "ViewGen_Extent";
        internal const string ViewGen_Null = "ViewGen_Null";
        internal const string ViewGen_CommaBlank = "ViewGen_CommaBlank";
        internal const string ViewGen_Entities = "ViewGen_Entities";
        internal const string ViewGen_Tuples = "ViewGen_Tuples";
        internal const string ViewGen_NotNull = "ViewGen_NotNull";
        internal const string ViewGen_NegatedCellConstant = "ViewGen_NegatedCellConstant";
        internal const string ViewGen_Error = "ViewGen_Error";
        internal const string ViewGen_AND = "ViewGen_AND";
        internal const string Viewgen_CannotGenerateQueryViewUnderNoValidation = "Viewgen_CannotGenerateQueryViewUnderNoValidation";
        internal const string ViewGen_Missing_Sets_Mapping = "ViewGen_Missing_Sets_Mapping";
        internal const string ViewGen_Missing_Type_Mapping = "ViewGen_Missing_Type_Mapping";
        internal const string ViewGen_Missing_Set_Mapping = "ViewGen_Missing_Set_Mapping";
        internal const string ViewGen_Concurrency_Derived_Class = "ViewGen_Concurrency_Derived_Class";
        internal const string ViewGen_Concurrency_Invalid_Condition = "ViewGen_Concurrency_Invalid_Condition";
        internal const string ViewGen_TableKey_Missing = "ViewGen_TableKey_Missing";
        internal const string ViewGen_EntitySetKey_Missing = "ViewGen_EntitySetKey_Missing";
        internal const string ViewGen_AssociationSetKey_Missing = "ViewGen_AssociationSetKey_Missing";
        internal const string ViewGen_Cannot_Recover_Attributes = "ViewGen_Cannot_Recover_Attributes";
        internal const string ViewGen_Cannot_Recover_Types = "ViewGen_Cannot_Recover_Types";
        internal const string ViewGen_Cannot_Disambiguate_MultiConstant = "ViewGen_Cannot_Disambiguate_MultiConstant";
        internal const string ViewGen_No_Default_Value = "ViewGen_No_Default_Value";
        internal const string ViewGen_No_Default_Value_For_Configuration = "ViewGen_No_Default_Value_For_Configuration";
        internal const string ViewGen_KeyConstraint_Violation = "ViewGen_KeyConstraint_Violation";
        internal const string ViewGen_KeyConstraint_Update_Violation_EntitySet = "ViewGen_KeyConstraint_Update_Violation_EntitySet";

        internal const string ViewGen_KeyConstraint_Update_Violation_AssociationSet =
            "ViewGen_KeyConstraint_Update_Violation_AssociationSet";

        internal const string ViewGen_AssociationEndShouldBeMappedToKey = "ViewGen_AssociationEndShouldBeMappedToKey";
        internal const string ViewGen_Duplicate_CProperties = "ViewGen_Duplicate_CProperties";
        internal const string ViewGen_Duplicate_CProperties_IsMapped = "ViewGen_Duplicate_CProperties_IsMapped";
        internal const string ViewGen_NotNull_No_Projected_Slot = "ViewGen_NotNull_No_Projected_Slot";
        internal const string ViewGen_InvalidCondition = "ViewGen_InvalidCondition";
        internal const string ViewGen_NonKeyProjectedWithOverlappingPartitions = "ViewGen_NonKeyProjectedWithOverlappingPartitions";
        internal const string ViewGen_CQ_PartitionConstraint = "ViewGen_CQ_PartitionConstraint";
        internal const string ViewGen_CQ_DomainConstraint = "ViewGen_CQ_DomainConstraint";
        internal const string ViewGen_OneOfConst_MustBeNonNullable = "ViewGen_OneOfConst_MustBeNonNullable";
        internal const string ViewGen_OneOfConst_MustBeNull = "ViewGen_OneOfConst_MustBeNull";
        internal const string ViewGen_OneOfConst_MustBeEqualTo = "ViewGen_OneOfConst_MustBeEqualTo";
        internal const string ViewGen_OneOfConst_MustNotBeEqualTo = "ViewGen_OneOfConst_MustNotBeEqualTo";
        internal const string ViewGen_OneOfConst_MustBeOneOf = "ViewGen_OneOfConst_MustBeOneOf";
        internal const string ViewGen_OneOfConst_MustNotBeOneOf = "ViewGen_OneOfConst_MustNotBeOneOf";
        internal const string ViewGen_OneOfConst_IsNonNullable = "ViewGen_OneOfConst_IsNonNullable";
        internal const string ViewGen_OneOfConst_IsEqualTo = "ViewGen_OneOfConst_IsEqualTo";
        internal const string ViewGen_OneOfConst_IsNotEqualTo = "ViewGen_OneOfConst_IsNotEqualTo";
        internal const string ViewGen_OneOfConst_IsOneOf = "ViewGen_OneOfConst_IsOneOf";
        internal const string ViewGen_OneOfConst_IsNotOneOf = "ViewGen_OneOfConst_IsNotOneOf";
        internal const string ViewGen_OneOfConst_IsOneOfTypes = "ViewGen_OneOfConst_IsOneOfTypes";
        internal const string ViewGen_ErrorLog = "ViewGen_ErrorLog";
        internal const string ViewGen_ErrorLog2 = "ViewGen_ErrorLog2";
        internal const string ViewGen_Foreign_Key_Missing_Table_Mapping = "ViewGen_Foreign_Key_Missing_Table_Mapping";
        internal const string ViewGen_Foreign_Key_ParentTable_NotMappedToEnd = "ViewGen_Foreign_Key_ParentTable_NotMappedToEnd";
        internal const string ViewGen_Foreign_Key = "ViewGen_Foreign_Key";
        internal const string ViewGen_Foreign_Key_UpperBound_MustBeOne = "ViewGen_Foreign_Key_UpperBound_MustBeOne";
        internal const string ViewGen_Foreign_Key_LowerBound_MustBeOne = "ViewGen_Foreign_Key_LowerBound_MustBeOne";
        internal const string ViewGen_Foreign_Key_Missing_Relationship_Mapping = "ViewGen_Foreign_Key_Missing_Relationship_Mapping";
        internal const string ViewGen_Foreign_Key_Not_Guaranteed_InCSpace = "ViewGen_Foreign_Key_Not_Guaranteed_InCSpace";
        internal const string ViewGen_Foreign_Key_ColumnOrder_Incorrect = "ViewGen_Foreign_Key_ColumnOrder_Incorrect";
        internal const string ViewGen_AssociationSet_AsUserString = "ViewGen_AssociationSet_AsUserString";
        internal const string ViewGen_AssociationSet_AsUserString_Negated = "ViewGen_AssociationSet_AsUserString_Negated";
        internal const string ViewGen_EntitySet_AsUserString = "ViewGen_EntitySet_AsUserString";
        internal const string ViewGen_EntitySet_AsUserString_Negated = "ViewGen_EntitySet_AsUserString_Negated";
        internal const string ViewGen_EntityInstanceToken = "ViewGen_EntityInstanceToken";
        internal const string Viewgen_ConfigurationErrorMsg = "Viewgen_ConfigurationErrorMsg";
        internal const string ViewGen_HashOnMappingClosure_Not_Matching = "ViewGen_HashOnMappingClosure_Not_Matching";
        internal const string Viewgen_RightSideNotDisjoint = "Viewgen_RightSideNotDisjoint";
        internal const string Viewgen_QV_RewritingNotFound = "Viewgen_QV_RewritingNotFound";
        internal const string Viewgen_NullableMappingForNonNullableColumn = "Viewgen_NullableMappingForNonNullableColumn";
        internal const string Viewgen_ErrorPattern_ConditionMemberIsMapped = "Viewgen_ErrorPattern_ConditionMemberIsMapped";
        internal const string Viewgen_ErrorPattern_DuplicateConditionValue = "Viewgen_ErrorPattern_DuplicateConditionValue";
        internal const string Viewgen_ErrorPattern_TableMappedToMultipleES = "Viewgen_ErrorPattern_TableMappedToMultipleES";
        internal const string Viewgen_ErrorPattern_Partition_Disj_Eq = "Viewgen_ErrorPattern_Partition_Disj_Eq";

        internal const string Viewgen_ErrorPattern_NotNullConditionMappedToNullableMember =
            "Viewgen_ErrorPattern_NotNullConditionMappedToNullableMember";

        internal const string Viewgen_ErrorPattern_Partition_MultipleTypesMappedToSameTable_WithoutCondition =
            "Viewgen_ErrorPattern_Partition_MultipleTypesMappedToSameTable_WithoutCondition";

        internal const string Viewgen_ErrorPattern_Partition_Disj_Subs_Ref = "Viewgen_ErrorPattern_Partition_Disj_Subs_Ref";
        internal const string Viewgen_ErrorPattern_Partition_Disj_Subs = "Viewgen_ErrorPattern_Partition_Disj_Subs";
        internal const string Viewgen_ErrorPattern_Partition_Disj_Unk = "Viewgen_ErrorPattern_Partition_Disj_Unk";
        internal const string Viewgen_ErrorPattern_Partition_Eq_Disj = "Viewgen_ErrorPattern_Partition_Eq_Disj";
        internal const string Viewgen_ErrorPattern_Partition_Eq_Subs_Ref = "Viewgen_ErrorPattern_Partition_Eq_Subs_Ref";
        internal const string Viewgen_ErrorPattern_Partition_Eq_Subs = "Viewgen_ErrorPattern_Partition_Eq_Subs";
        internal const string Viewgen_ErrorPattern_Partition_Eq_Unk = "Viewgen_ErrorPattern_Partition_Eq_Unk";
        internal const string Viewgen_ErrorPattern_Partition_Eq_Unk_Association = "Viewgen_ErrorPattern_Partition_Eq_Unk_Association";
        internal const string Viewgen_ErrorPattern_Partition_Sub_Disj = "Viewgen_ErrorPattern_Partition_Sub_Disj";
        internal const string Viewgen_ErrorPattern_Partition_Sub_Eq = "Viewgen_ErrorPattern_Partition_Sub_Eq";
        internal const string Viewgen_ErrorPattern_Partition_Sub_Eq_Ref = "Viewgen_ErrorPattern_Partition_Sub_Eq_Ref";
        internal const string Viewgen_ErrorPattern_Partition_Sub_Unk = "Viewgen_ErrorPattern_Partition_Sub_Unk";
        internal const string Viewgen_NoJoinKeyOrFK = "Viewgen_NoJoinKeyOrFK";

        internal const string Viewgen_MultipleFragmentsBetweenCandSExtentWithDistinct =
            "Viewgen_MultipleFragmentsBetweenCandSExtentWithDistinct";

        internal const string Validator_EmptyIdentity = "Validator_EmptyIdentity";
        internal const string Validator_CollectionHasNoTypeUsage = "Validator_CollectionHasNoTypeUsage";
        internal const string Validator_NoKeyMembers = "Validator_NoKeyMembers";
        internal const string Validator_FacetTypeIsNull = "Validator_FacetTypeIsNull";
        internal const string Validator_MemberHasNullDeclaringType = "Validator_MemberHasNullDeclaringType";
        internal const string Validator_MemberHasNullTypeUsage = "Validator_MemberHasNullTypeUsage";
        internal const string Validator_ItemAttributeHasNullTypeUsage = "Validator_ItemAttributeHasNullTypeUsage";
        internal const string Validator_RefTypeHasNullEntityType = "Validator_RefTypeHasNullEntityType";
        internal const string Validator_TypeUsageHasNullEdmType = "Validator_TypeUsageHasNullEdmType";
        internal const string Validator_BaseTypeHasMemberOfSameName = "Validator_BaseTypeHasMemberOfSameName";
        internal const string Validator_CollectionTypesCannotHaveBaseType = "Validator_CollectionTypesCannotHaveBaseType";
        internal const string Validator_RefTypesCannotHaveBaseType = "Validator_RefTypesCannotHaveBaseType";
        internal const string Validator_TypeHasNoName = "Validator_TypeHasNoName";
        internal const string Validator_TypeHasNoNamespace = "Validator_TypeHasNoNamespace";
        internal const string Validator_FacetHasNoName = "Validator_FacetHasNoName";
        internal const string Validator_MemberHasNoName = "Validator_MemberHasNoName";
        internal const string Validator_MetadataPropertyHasNoName = "Validator_MetadataPropertyHasNoName";
        internal const string Validator_NullableEntityKeyProperty = "Validator_NullableEntityKeyProperty";
        internal const string Validator_OSpace_InvalidNavPropReturnType = "Validator_OSpace_InvalidNavPropReturnType";
        internal const string Validator_OSpace_ScalarPropertyNotPrimitive = "Validator_OSpace_ScalarPropertyNotPrimitive";
        internal const string Validator_OSpace_ComplexPropertyNotComplex = "Validator_OSpace_ComplexPropertyNotComplex";

        internal const string Validator_OSpace_Convention_MultipleTypesWithSameName =
            "Validator_OSpace_Convention_MultipleTypesWithSameName";

        internal const string Validator_OSpace_Convention_NonPrimitiveTypeProperty = "Validator_OSpace_Convention_NonPrimitiveTypeProperty";
        internal const string Validator_OSpace_Convention_MissingRequiredProperty = "Validator_OSpace_Convention_MissingRequiredProperty";
        internal const string Validator_OSpace_Convention_BaseTypeIncompatible = "Validator_OSpace_Convention_BaseTypeIncompatible";
        internal const string Validator_OSpace_Convention_MissingOSpaceType = "Validator_OSpace_Convention_MissingOSpaceType";
        internal const string Validator_OSpace_Convention_RelationshipNotLoaded = "Validator_OSpace_Convention_RelationshipNotLoaded";

        internal const string Validator_OSpace_Convention_AttributeAssemblyReferenced =
            "Validator_OSpace_Convention_AttributeAssemblyReferenced";

        internal const string Validator_OSpace_Convention_ScalarPropertyMissginGetterOrSetter =
            "Validator_OSpace_Convention_ScalarPropertyMissginGetterOrSetter";

        internal const string Validator_OSpace_Convention_AmbiguousClrType = "Validator_OSpace_Convention_AmbiguousClrType";
        internal const string Validator_OSpace_Convention_Struct = "Validator_OSpace_Convention_Struct";
        internal const string Validator_OSpace_Convention_BaseTypeNotLoaded = "Validator_OSpace_Convention_BaseTypeNotLoaded";
        internal const string Validator_OSpace_Convention_SSpaceOSpaceTypeMismatch = "Validator_OSpace_Convention_SSpaceOSpaceTypeMismatch";

        internal const string Validator_OSpace_Convention_NonMatchingUnderlyingTypes =
            "Validator_OSpace_Convention_NonMatchingUnderlyingTypes";

        internal const string Validator_UnsupportedEnumUnderlyingType = "Validator_UnsupportedEnumUnderlyingType";
        internal const string ExtraInfo = "ExtraInfo";
        internal const string Metadata_General_Error = "Metadata_General_Error";
        internal const string InvalidNumberOfParametersForAggregateFunction = "InvalidNumberOfParametersForAggregateFunction";
        internal const string InvalidParameterTypeForAggregateFunction = "InvalidParameterTypeForAggregateFunction";
        internal const string ItemCollectionAlreadyRegistered = "ItemCollectionAlreadyRegistered";
        internal const string InvalidSchemaEncountered = "InvalidSchemaEncountered";
        internal const string SystemNamespaceEncountered = "SystemNamespaceEncountered";
        internal const string NoCollectionForSpace = "NoCollectionForSpace";
        internal const string OperationOnReadOnlyCollection = "OperationOnReadOnlyCollection";
        internal const string OperationOnReadOnlyItem = "OperationOnReadOnlyItem";
        internal const string EntitySetInAnotherContainer = "EntitySetInAnotherContainer";
        internal const string InvalidKeyMember = "InvalidKeyMember";
        internal const string InvalidFileExtension = "InvalidFileExtension";
        internal const string NewTypeConflictsWithExistingType = "NewTypeConflictsWithExistingType";
        internal const string NotValidInputPath = "NotValidInputPath";
        internal const string UnableToDetermineApplicationContext = "UnableToDetermineApplicationContext";
        internal const string WildcardEnumeratorReturnedNull = "WildcardEnumeratorReturnedNull";
        internal const string InvalidUseOfWebPath = "InvalidUseOfWebPath";
        internal const string UnableToFindReflectedType = "UnableToFindReflectedType";
        internal const string AssemblyMissingFromAssembliesToConsider = "AssemblyMissingFromAssembliesToConsider";
        internal const string InvalidCollectionSpecified = "InvalidCollectionSpecified";
        internal const string UnableToLoadResource = "UnableToLoadResource";
        internal const string EdmVersionNotSupportedByRuntime = "EdmVersionNotSupportedByRuntime";
        internal const string AtleastOneSSDLNeeded = "AtleastOneSSDLNeeded";
        internal const string InvalidMetadataPath = "InvalidMetadataPath";
        internal const string UnableToResolveAssembly = "UnableToResolveAssembly";
        internal const string DuplicatedFunctionoverloads = "DuplicatedFunctionoverloads";
        internal const string EntitySetNotInCSPace = "EntitySetNotInCSPace";
        internal const string TypeNotInEntitySet = "TypeNotInEntitySet";
        internal const string TypeNotInAssociationSet = "TypeNotInAssociationSet";
        internal const string DifferentSchemaVersionInCollection = "DifferentSchemaVersionInCollection";
        internal const string InvalidCollectionForMapping = "InvalidCollectionForMapping";
        internal const string OnlyStoreConnectionsSupported = "OnlyStoreConnectionsSupported";
        internal const string StoreItemCollectionMustHaveOneArtifact = "StoreItemCollectionMustHaveOneArtifact";
        internal const string CheckArgumentContainsNullFailed = "CheckArgumentContainsNullFailed";
        internal const string InvalidRelationshipSetName = "InvalidRelationshipSetName";
        internal const string MemberInvalidIdentity = "MemberInvalidIdentity";
        internal const string InvalidEntitySetName = "InvalidEntitySetName";
        internal const string ItemInvalidIdentity = "ItemInvalidIdentity";
        internal const string ItemDuplicateIdentity = "ItemDuplicateIdentity";
        internal const string NotStringTypeForTypeUsage = "NotStringTypeForTypeUsage";
        internal const string NotBinaryTypeForTypeUsage = "NotBinaryTypeForTypeUsage";
        internal const string NotDateTimeTypeForTypeUsage = "NotDateTimeTypeForTypeUsage";
        internal const string NotDateTimeOffsetTypeForTypeUsage = "NotDateTimeOffsetTypeForTypeUsage";
        internal const string NotTimeTypeForTypeUsage = "NotTimeTypeForTypeUsage";
        internal const string NotDecimalTypeForTypeUsage = "NotDecimalTypeForTypeUsage";
        internal const string ArrayTooSmall = "ArrayTooSmall";
        internal const string MoreThanOneItemMatchesIdentity = "MoreThanOneItemMatchesIdentity";
        internal const string MissingDefaultValueForConstantFacet = "MissingDefaultValueForConstantFacet";
        internal const string MinAndMaxValueMustBeSameForConstantFacet = "MinAndMaxValueMustBeSameForConstantFacet";
        internal const string BothMinAndMaxValueMustBeSpecifiedForNonConstantFacet = "BothMinAndMaxValueMustBeSpecifiedForNonConstantFacet";
        internal const string MinAndMaxValueMustBeDifferentForNonConstantFacet = "MinAndMaxValueMustBeDifferentForNonConstantFacet";
        internal const string MinAndMaxMustBePositive = "MinAndMaxMustBePositive";
        internal const string MinMustBeLessThanMax = "MinMustBeLessThanMax";
        internal const string SameRoleNameOnRelationshipAttribute = "SameRoleNameOnRelationshipAttribute";
        internal const string RoleTypeInEdmRelationshipAttributeIsInvalidType = "RoleTypeInEdmRelationshipAttributeIsInvalidType";
        internal const string TargetRoleNameInNavigationPropertyNotValid = "TargetRoleNameInNavigationPropertyNotValid";
        internal const string RelationshipNameInNavigationPropertyNotValid = "RelationshipNameInNavigationPropertyNotValid";
        internal const string NestedClassNotSupported = "NestedClassNotSupported";
        internal const string NullParameterForEdmRelationshipAttribute = "NullParameterForEdmRelationshipAttribute";
        internal const string NullRelationshipNameforEdmRelationshipAttribute = "NullRelationshipNameforEdmRelationshipAttribute";
        internal const string NavigationPropertyRelationshipEndTypeMismatch = "NavigationPropertyRelationshipEndTypeMismatch";
        internal const string AllArtifactsMustTargetSameProvider_InvariantName = "AllArtifactsMustTargetSameProvider_InvariantName";
        internal const string AllArtifactsMustTargetSameProvider_ManifestToken = "AllArtifactsMustTargetSameProvider_ManifestToken";
        internal const string ProviderManifestTokenNotFound = "ProviderManifestTokenNotFound";
        internal const string FailedToRetrieveProviderManifest = "FailedToRetrieveProviderManifest";
        internal const string InvalidMaxLengthSize = "InvalidMaxLengthSize";
        internal const string ArgumentMustBeCSpaceType = "ArgumentMustBeCSpaceType";
        internal const string ArgumentMustBeOSpaceType = "ArgumentMustBeOSpaceType";
        internal const string FailedToFindOSpaceTypeMapping = "FailedToFindOSpaceTypeMapping";
        internal const string FailedToFindCSpaceTypeMapping = "FailedToFindCSpaceTypeMapping";
        internal const string FailedToFindClrTypeMapping = "FailedToFindClrTypeMapping";
        internal const string GenericTypeNotSupported = "GenericTypeNotSupported";
        internal const string InvalidEDMVersion = "InvalidEDMVersion";
        internal const string Mapping_General_Error = "Mapping_General_Error";
        internal const string Mapping_InvalidContent_General = "Mapping_InvalidContent_General";
        internal const string Mapping_InvalidContent_EntityContainer = "Mapping_InvalidContent_EntityContainer";
        internal const string Mapping_InvalidContent_StorageEntityContainer = "Mapping_InvalidContent_StorageEntityContainer";
        internal const string Mapping_AlreadyMapped_StorageEntityContainer = "Mapping_AlreadyMapped_StorageEntityContainer";
        internal const string Mapping_InvalidContent_Entity_Set = "Mapping_InvalidContent_Entity_Set";
        internal const string Mapping_InvalidContent_Entity_Type = "Mapping_InvalidContent_Entity_Type";

        internal const string Mapping_InvalidContent_AbstractEntity_FunctionMapping =
            "Mapping_InvalidContent_AbstractEntity_FunctionMapping";

        internal const string Mapping_InvalidContent_AbstractEntity_Type = "Mapping_InvalidContent_AbstractEntity_Type";
        internal const string Mapping_InvalidContent_AbstractEntity_IsOfType = "Mapping_InvalidContent_AbstractEntity_IsOfType";
        internal const string Mapping_InvalidContent_Entity_Type_For_Entity_Set = "Mapping_InvalidContent_Entity_Type_For_Entity_Set";
        internal const string Mapping_Invalid_Association_Type_For_Association_Set = "Mapping_Invalid_Association_Type_For_Association_Set";
        internal const string Mapping_InvalidContent_Table = "Mapping_InvalidContent_Table";
        internal const string Mapping_InvalidContent_Complex_Type = "Mapping_InvalidContent_Complex_Type";
        internal const string Mapping_InvalidContent_Association_Set = "Mapping_InvalidContent_Association_Set";
        internal const string Mapping_InvalidContent_AssociationSet_Condition = "Mapping_InvalidContent_AssociationSet_Condition";
        internal const string Mapping_InvalidContent_ForeignKey_Association_Set = "Mapping_InvalidContent_ForeignKey_Association_Set";

        internal const string Mapping_InvalidContent_ForeignKey_Association_Set_PKtoPK =
            "Mapping_InvalidContent_ForeignKey_Association_Set_PKtoPK";

        internal const string Mapping_InvalidContent_Association_Type = "Mapping_InvalidContent_Association_Type";
        internal const string Mapping_InvalidContent_EndProperty = "Mapping_InvalidContent_EndProperty";
        internal const string Mapping_InvalidContent_Association_Type_Empty = "Mapping_InvalidContent_Association_Type_Empty";
        internal const string Mapping_InvalidContent_Table_Expected = "Mapping_InvalidContent_Table_Expected";
        internal const string Mapping_InvalidContent_Cdm_Member = "Mapping_InvalidContent_Cdm_Member";
        internal const string Mapping_InvalidContent_Column = "Mapping_InvalidContent_Column";
        internal const string Mapping_InvalidContent_End = "Mapping_InvalidContent_End";
        internal const string Mapping_InvalidContent_Container_SubElement = "Mapping_InvalidContent_Container_SubElement";
        internal const string Mapping_InvalidContent_Duplicate_Cdm_Member = "Mapping_InvalidContent_Duplicate_Cdm_Member";
        internal const string Mapping_InvalidContent_Duplicate_Condition_Member = "Mapping_InvalidContent_Duplicate_Condition_Member";
        internal const string Mapping_InvalidContent_ConditionMapping_Both_Members = "Mapping_InvalidContent_ConditionMapping_Both_Members";

        internal const string Mapping_InvalidContent_ConditionMapping_Either_Members =
            "Mapping_InvalidContent_ConditionMapping_Either_Members";

        internal const string Mapping_InvalidContent_ConditionMapping_Both_Values = "Mapping_InvalidContent_ConditionMapping_Both_Values";

        internal const string Mapping_InvalidContent_ConditionMapping_Either_Values =
            "Mapping_InvalidContent_ConditionMapping_Either_Values";

        internal const string Mapping_InvalidContent_ConditionMapping_NonScalar = "Mapping_InvalidContent_ConditionMapping_NonScalar";

        internal const string Mapping_InvalidContent_ConditionMapping_InvalidPrimitiveTypeKind =
            "Mapping_InvalidContent_ConditionMapping_InvalidPrimitiveTypeKind";

        internal const string Mapping_InvalidContent_ConditionMapping_InvalidMember =
            "Mapping_InvalidContent_ConditionMapping_InvalidMember";

        internal const string Mapping_InvalidContent_ConditionMapping_Computed = "Mapping_InvalidContent_ConditionMapping_Computed";
        internal const string Mapping_InvalidContent_Emtpty_SetMap = "Mapping_InvalidContent_Emtpty_SetMap";
        internal const string Mapping_InvalidContent_TypeMapping_QueryView = "Mapping_InvalidContent_TypeMapping_QueryView";
        internal const string Mapping_Default_OCMapping_Clr_Member = "Mapping_Default_OCMapping_Clr_Member";
        internal const string Mapping_Default_OCMapping_Clr_Member2 = "Mapping_Default_OCMapping_Clr_Member2";
        internal const string Mapping_Default_OCMapping_Invalid_MemberType = "Mapping_Default_OCMapping_Invalid_MemberType";
        internal const string Mapping_Default_OCMapping_MemberKind_Mismatch = "Mapping_Default_OCMapping_MemberKind_Mismatch";
        internal const string Mapping_Default_OCMapping_MultiplicityMismatch = "Mapping_Default_OCMapping_MultiplicityMismatch";
        internal const string Mapping_Default_OCMapping_Member_Count_Mismatch = "Mapping_Default_OCMapping_Member_Count_Mismatch";
        internal const string Mapping_Default_OCMapping_Member_Type_Mismatch = "Mapping_Default_OCMapping_Member_Type_Mismatch";
        internal const string Mapping_Enum_OCMapping_UnderlyingTypesMismatch = "Mapping_Enum_OCMapping_UnderlyingTypesMismatch";
        internal const string Mapping_Enum_OCMapping_MemberMismatch = "Mapping_Enum_OCMapping_MemberMismatch";
        internal const string Mapping_NotFound_EntityContainer = "Mapping_NotFound_EntityContainer";
        internal const string Mapping_Duplicate_CdmAssociationSet_StorageMap = "Mapping_Duplicate_CdmAssociationSet_StorageMap";
        internal const string Mapping_Invalid_CSRootElementMissing = "Mapping_Invalid_CSRootElementMissing";
        internal const string Mapping_ConditionValueTypeMismatch = "Mapping_ConditionValueTypeMismatch";
        internal const string Mapping_Storage_InvalidSpace = "Mapping_Storage_InvalidSpace";
        internal const string Mapping_Invalid_Member_Mapping = "Mapping_Invalid_Member_Mapping";
        internal const string Mapping_Invalid_CSide_ScalarProperty = "Mapping_Invalid_CSide_ScalarProperty";
        internal const string Mapping_Duplicate_Type = "Mapping_Duplicate_Type";
        internal const string Mapping_Duplicate_PropertyMap_CaseInsensitive = "Mapping_Duplicate_PropertyMap_CaseInsensitive";
        internal const string Mapping_Enum_EmptyValue = "Mapping_Enum_EmptyValue";
        internal const string Mapping_Enum_InvalidValue = "Mapping_Enum_InvalidValue";
        internal const string Mapping_InvalidMappingSchema_Parsing = "Mapping_InvalidMappingSchema_Parsing";
        internal const string Mapping_InvalidMappingSchema_validation = "Mapping_InvalidMappingSchema_validation";
        internal const string Mapping_Object_InvalidType = "Mapping_Object_InvalidType";
        internal const string Mapping_Provider_WrongConnectionType = "Mapping_Provider_WrongConnectionType";
        internal const string Mapping_Views_For_Extent_Not_Generated = "Mapping_Views_For_Extent_Not_Generated";
        internal const string Mapping_TableName_QueryView = "Mapping_TableName_QueryView";
        internal const string Mapping_Empty_QueryView = "Mapping_Empty_QueryView";
        internal const string Mapping_Empty_QueryView_OfType = "Mapping_Empty_QueryView_OfType";
        internal const string Mapping_Empty_QueryView_OfTypeOnly = "Mapping_Empty_QueryView_OfTypeOnly";
        internal const string Mapping_QueryView_PropertyMaps = "Mapping_QueryView_PropertyMaps";
        internal const string Mapping_Invalid_QueryView = "Mapping_Invalid_QueryView";
        internal const string Mapping_Invalid_QueryView2 = "Mapping_Invalid_QueryView2";
        internal const string Mapping_Invalid_QueryView_Type = "Mapping_Invalid_QueryView_Type";
        internal const string Mapping_TypeName_For_First_QueryView = "Mapping_TypeName_For_First_QueryView";
        internal const string Mapping_AllQueryViewAtCompileTime = "Mapping_AllQueryViewAtCompileTime";
        internal const string Mapping_QueryViewMultipleTypeInTypeName = "Mapping_QueryViewMultipleTypeInTypeName";
        internal const string Mapping_QueryView_Duplicate_OfType = "Mapping_QueryView_Duplicate_OfType";
        internal const string Mapping_QueryView_Duplicate_OfTypeOnly = "Mapping_QueryView_Duplicate_OfTypeOnly";
        internal const string Mapping_QueryView_TypeName_Not_Defined = "Mapping_QueryView_TypeName_Not_Defined";
        internal const string Mapping_QueryView_For_Base_Type = "Mapping_QueryView_For_Base_Type";
        internal const string Mapping_UnsupportedExpressionKind_QueryView = "Mapping_UnsupportedExpressionKind_QueryView";
        internal const string Mapping_UnsupportedFunctionCall_QueryView = "Mapping_UnsupportedFunctionCall_QueryView";
        internal const string Mapping_UnsupportedScanTarget_QueryView = "Mapping_UnsupportedScanTarget_QueryView";
        internal const string Mapping_UnsupportedPropertyKind_QueryView = "Mapping_UnsupportedPropertyKind_QueryView";
        internal const string Mapping_UnsupportedInitialization_QueryView = "Mapping_UnsupportedInitialization_QueryView";

        internal const string Mapping_EntitySetMismatchOnAssociationSetEnd_QueryView =
            "Mapping_EntitySetMismatchOnAssociationSetEnd_QueryView";

        internal const string Mapping_Invalid_Query_Views_MissingSetClosure = "Mapping_Invalid_Query_Views_MissingSetClosure";
        internal const string Generated_View_Type_Super_Class = "Generated_View_Type_Super_Class";
        internal const string Generated_Views_Changed = "Generated_Views_Changed";
        internal const string Generated_Views_Invalid_Extent = "Generated_Views_Invalid_Extent";
        internal const string Mapping_ItemWithSameNameExistsBothInCSpaceAndSSpace = "Mapping_ItemWithSameNameExistsBothInCSpaceAndSSpace";
        internal const string Mapping_AbstractTypeMappingToNonAbstractType = "Mapping_AbstractTypeMappingToNonAbstractType";
        internal const string Mapping_EnumTypeMappingToNonEnumType = "Mapping_EnumTypeMappingToNonEnumType";

        internal const string StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping =
            "StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping";

        internal const string Mapping_InvalidContent_IsTypeOfNotTerminated = "Mapping_InvalidContent_IsTypeOfNotTerminated";
        internal const string Mapping_CannotMapCLRTypeMultipleTimes = "Mapping_CannotMapCLRTypeMultipleTimes";
        internal const string Mapping_ModificationFunction_In_Table_Context = "Mapping_ModificationFunction_In_Table_Context";
        internal const string Mapping_ModificationFunction_Multiple_Types = "Mapping_ModificationFunction_Multiple_Types";
        internal const string Mapping_ModificationFunction_UnknownFunction = "Mapping_ModificationFunction_UnknownFunction";
        internal const string Mapping_ModificationFunction_AmbiguousFunction = "Mapping_ModificationFunction_AmbiguousFunction";
        internal const string Mapping_ModificationFunction_NotValidFunction = "Mapping_ModificationFunction_NotValidFunction";

        internal const string Mapping_ModificationFunction_NotValidFunctionParameter =
            "Mapping_ModificationFunction_NotValidFunctionParameter";

        internal const string Mapping_ModificationFunction_MissingParameter = "Mapping_ModificationFunction_MissingParameter";

        internal const string Mapping_ModificationFunction_AssociationSetDoesNotExist =
            "Mapping_ModificationFunction_AssociationSetDoesNotExist";

        internal const string Mapping_ModificationFunction_AssociationSetRoleDoesNotExist =
            "Mapping_ModificationFunction_AssociationSetRoleDoesNotExist";

        internal const string Mapping_ModificationFunction_AssociationSetFromRoleIsNotEntitySet =
            "Mapping_ModificationFunction_AssociationSetFromRoleIsNotEntitySet";

        internal const string Mapping_ModificationFunction_AssociationSetCardinality =
            "Mapping_ModificationFunction_AssociationSetCardinality";

        internal const string Mapping_ModificationFunction_ComplexTypeNotFound = "Mapping_ModificationFunction_ComplexTypeNotFound";
        internal const string Mapping_ModificationFunction_WrongComplexType = "Mapping_ModificationFunction_WrongComplexType";
        internal const string Mapping_ModificationFunction_MissingVersion = "Mapping_ModificationFunction_MissingVersion";
        internal const string Mapping_ModificationFunction_VersionMustBeOriginal = "Mapping_ModificationFunction_VersionMustBeOriginal";
        internal const string Mapping_ModificationFunction_VersionMustBeCurrent = "Mapping_ModificationFunction_VersionMustBeCurrent";
        internal const string Mapping_ModificationFunction_ParameterNotFound = "Mapping_ModificationFunction_ParameterNotFound";
        internal const string Mapping_ModificationFunction_PropertyNotFound = "Mapping_ModificationFunction_PropertyNotFound";
        internal const string Mapping_ModificationFunction_PropertyNotKey = "Mapping_ModificationFunction_PropertyNotKey";
        internal const string Mapping_ModificationFunction_ParameterBoundTwice = "Mapping_ModificationFunction_ParameterBoundTwice";

        internal const string Mapping_ModificationFunction_RedundantEntityTypeMapping =
            "Mapping_ModificationFunction_RedundantEntityTypeMapping";

        internal const string Mapping_ModificationFunction_MissingSetClosure = "Mapping_ModificationFunction_MissingSetClosure";
        internal const string Mapping_ModificationFunction_MissingEntityType = "Mapping_ModificationFunction_MissingEntityType";

        internal const string Mapping_ModificationFunction_PropertyParameterTypeMismatch =
            "Mapping_ModificationFunction_PropertyParameterTypeMismatch";

        internal const string Mapping_ModificationFunction_AssociationSetAmbiguous = "Mapping_ModificationFunction_AssociationSetAmbiguous";

        internal const string Mapping_ModificationFunction_MultipleEndsOfAssociationMapped =
            "Mapping_ModificationFunction_MultipleEndsOfAssociationMapped";

        internal const string Mapping_ModificationFunction_AmbiguousResultBinding = "Mapping_ModificationFunction_AmbiguousResultBinding";

        internal const string Mapping_ModificationFunction_AssociationSetNotMappedForOperation =
            "Mapping_ModificationFunction_AssociationSetNotMappedForOperation";

        internal const string Mapping_ModificationFunction_AssociationEndMappingInvalidForEntityType =
            "Mapping_ModificationFunction_AssociationEndMappingInvalidForEntityType";

        internal const string Mapping_ModificationFunction_AssociationEndMappingForeignKeyAssociation =
            "Mapping_ModificationFunction_AssociationEndMappingForeignKeyAssociation";

        internal const string Mapping_StoreTypeMismatch_ScalarPropertyMapping = "Mapping_StoreTypeMismatch_ScalarPropertyMapping";
        internal const string Mapping_DistinctFlagInReadWriteContainer = "Mapping_DistinctFlagInReadWriteContainer";
        internal const string Mapping_ProviderReturnsNullType = "Mapping_ProviderReturnsNullType";
        internal const string Mapping_DifferentEdmStoreVersion = "Mapping_DifferentEdmStoreVersion";
        internal const string Mapping_DifferentMappingEdmStoreVersion = "Mapping_DifferentMappingEdmStoreVersion";
        internal const string Mapping_FunctionImport_StoreFunctionDoesNotExist = "Mapping_FunctionImport_StoreFunctionDoesNotExist";
        internal const string Mapping_FunctionImport_FunctionImportDoesNotExist = "Mapping_FunctionImport_FunctionImportDoesNotExist";

        internal const string Mapping_FunctionImport_FunctionImportMappedMultipleTimes =
            "Mapping_FunctionImport_FunctionImportMappedMultipleTimes";

        internal const string Mapping_FunctionImport_TargetFunctionMustBeNonComposable =
            "Mapping_FunctionImport_TargetFunctionMustBeNonComposable";

        internal const string Mapping_FunctionImport_TargetFunctionMustBeComposable =
            "Mapping_FunctionImport_TargetFunctionMustBeComposable";

        internal const string Mapping_FunctionImport_TargetParameterHasNoCorrespondingImportParameter =
            "Mapping_FunctionImport_TargetParameterHasNoCorrespondingImportParameter";

        internal const string Mapping_FunctionImport_ImportParameterHasNoCorrespondingTargetParameter =
            "Mapping_FunctionImport_ImportParameterHasNoCorrespondingTargetParameter";

        internal const string Mapping_FunctionImport_IncompatibleParameterMode = "Mapping_FunctionImport_IncompatibleParameterMode";
        internal const string Mapping_FunctionImport_IncompatibleParameterType = "Mapping_FunctionImport_IncompatibleParameterType";
        internal const string Mapping_FunctionImport_IncompatibleEnumParameterType = "Mapping_FunctionImport_IncompatibleEnumParameterType";

        internal const string Mapping_FunctionImport_RowsAffectedParameterDoesNotExist =
            "Mapping_FunctionImport_RowsAffectedParameterDoesNotExist";

        internal const string Mapping_FunctionImport_RowsAffectedParameterHasWrongType =
            "Mapping_FunctionImport_RowsAffectedParameterHasWrongType";

        internal const string Mapping_FunctionImport_RowsAffectedParameterHasWrongMode =
            "Mapping_FunctionImport_RowsAffectedParameterHasWrongMode";

        internal const string Mapping_FunctionImport_EntityTypeMappingForFunctionNotReturningEntitySet =
            "Mapping_FunctionImport_EntityTypeMappingForFunctionNotReturningEntitySet";

        internal const string Mapping_FunctionImport_InvalidContentEntityTypeForEntitySet =
            "Mapping_FunctionImport_InvalidContentEntityTypeForEntitySet";

        internal const string Mapping_FunctionImport_ConditionValueTypeMismatch = "Mapping_FunctionImport_ConditionValueTypeMismatch";
        internal const string Mapping_FunctionImport_UnsupportedType = "Mapping_FunctionImport_UnsupportedType";

        internal const string Mapping_FunctionImport_ResultMappingCountDoesNotMatchResultCount =
            "Mapping_FunctionImport_ResultMappingCountDoesNotMatchResultCount";

        internal const string Mapping_FunctionImport_ResultMapping_MappedTypeDoesNotMatchReturnType =
            "Mapping_FunctionImport_ResultMapping_MappedTypeDoesNotMatchReturnType";

        internal const string Mapping_FunctionImport_ResultMapping_InvalidCTypeCTExpected =
            "Mapping_FunctionImport_ResultMapping_InvalidCTypeCTExpected";

        internal const string Mapping_FunctionImport_ResultMapping_InvalidCTypeETExpected =
            "Mapping_FunctionImport_ResultMapping_InvalidCTypeETExpected";

        internal const string Mapping_FunctionImport_ResultMapping_InvalidSType = "Mapping_FunctionImport_ResultMapping_InvalidSType";
        internal const string Mapping_FunctionImport_PropertyNotMapped = "Mapping_FunctionImport_PropertyNotMapped";

        internal const string Mapping_FunctionImport_ImplicitMappingForAbstractReturnType =
            "Mapping_FunctionImport_ImplicitMappingForAbstractReturnType";

        internal const string Mapping_FunctionImport_ScalarMappingToMulticolumnTVF = "Mapping_FunctionImport_ScalarMappingToMulticolumnTVF";
        internal const string Mapping_FunctionImport_ScalarMappingTypeMismatch = "Mapping_FunctionImport_ScalarMappingTypeMismatch";
        internal const string Mapping_FunctionImport_UnreachableType = "Mapping_FunctionImport_UnreachableType";
        internal const string Mapping_FunctionImport_UnreachableIsTypeOf = "Mapping_FunctionImport_UnreachableIsTypeOf";
        internal const string Mapping_FunctionImport_FunctionAmbiguous = "Mapping_FunctionImport_FunctionAmbiguous";
        internal const string Mapping_FunctionImport_CannotInferTargetFunctionKeys = "Mapping_FunctionImport_CannotInferTargetFunctionKeys";
        internal const string Entity_EntityCantHaveMultipleChangeTrackers = "Entity_EntityCantHaveMultipleChangeTrackers";
        internal const string ComplexObject_NullableComplexTypesNotSupported = "ComplexObject_NullableComplexTypesNotSupported";
        internal const string ComplexObject_ComplexObjectAlreadyAttachedToParent = "ComplexObject_ComplexObjectAlreadyAttachedToParent";
        internal const string ComplexObject_ComplexChangeRequestedOnScalarProperty = "ComplexObject_ComplexChangeRequestedOnScalarProperty";
        internal const string ObjectStateEntry_SetModifiedOnInvalidProperty = "ObjectStateEntry_SetModifiedOnInvalidProperty";
        internal const string ObjectStateEntry_OriginalValuesDoesNotExist = "ObjectStateEntry_OriginalValuesDoesNotExist";
        internal const string ObjectStateEntry_CurrentValuesDoesNotExist = "ObjectStateEntry_CurrentValuesDoesNotExist";
        internal const string ObjectStateEntry_InvalidState = "ObjectStateEntry_InvalidState";
        internal const string ObjectStateEntry_CannotModifyKeyProperty = "ObjectStateEntry_CannotModifyKeyProperty";
        internal const string ObjectStateEntry_CantModifyRelationValues = "ObjectStateEntry_CantModifyRelationValues";
        internal const string ObjectStateEntry_CantModifyRelationState = "ObjectStateEntry_CantModifyRelationState";
        internal const string ObjectStateEntry_CantModifyDetachedDeletedEntries = "ObjectStateEntry_CantModifyDetachedDeletedEntries";
        internal const string ObjectStateEntry_SetModifiedStates = "ObjectStateEntry_SetModifiedStates";
        internal const string ObjectStateEntry_CantSetEntityKey = "ObjectStateEntry_CantSetEntityKey";
        internal const string ObjectStateEntry_CannotAccessKeyEntryValues = "ObjectStateEntry_CannotAccessKeyEntryValues";
        internal const string ObjectStateEntry_CannotModifyKeyEntryState = "ObjectStateEntry_CannotModifyKeyEntryState";
        internal const string ObjectStateEntry_CannotDeleteOnKeyEntry = "ObjectStateEntry_CannotDeleteOnKeyEntry";

        internal const string ObjectStateEntry_EntityMemberChangedWithoutEntityMemberChanging =
            "ObjectStateEntry_EntityMemberChangedWithoutEntityMemberChanging";

        internal const string ObjectStateEntry_ChangeOnUnmappedProperty = "ObjectStateEntry_ChangeOnUnmappedProperty";
        internal const string ObjectStateEntry_ChangeOnUnmappedComplexProperty = "ObjectStateEntry_ChangeOnUnmappedComplexProperty";
        internal const string ObjectStateEntry_ChangedInDifferentStateFromChanging = "ObjectStateEntry_ChangedInDifferentStateFromChanging";
        internal const string ObjectStateEntry_UnableToEnumerateCollection = "ObjectStateEntry_UnableToEnumerateCollection";

        internal const string ObjectStateEntry_RelationshipAndKeyEntriesDoNotHaveRelationshipManagers =
            "ObjectStateEntry_RelationshipAndKeyEntriesDoNotHaveRelationshipManagers";

        internal const string ObjectStateEntry_InvalidTypeForComplexTypeProperty = "ObjectStateEntry_InvalidTypeForComplexTypeProperty";
        internal const string ObjectStateEntry_ComplexObjectUsedMultipleTimes = "ObjectStateEntry_ComplexObjectUsedMultipleTimes";
        internal const string ObjectStateEntry_SetOriginalComplexProperties = "ObjectStateEntry_SetOriginalComplexProperties";

        internal const string ObjectStateEntry_NullOriginalValueForNonNullableProperty =
            "ObjectStateEntry_NullOriginalValueForNonNullableProperty";

        internal const string ObjectStateEntry_SetOriginalPrimaryKey = "ObjectStateEntry_SetOriginalPrimaryKey";
        internal const string ObjectStateManager_NoEntryExistForEntityKey = "ObjectStateManager_NoEntryExistForEntityKey";
        internal const string ObjectStateManager_NoEntryExistsForObject = "ObjectStateManager_NoEntryExistsForObject";
        internal const string ObjectStateManager_EntityNotTracked = "ObjectStateManager_EntityNotTracked";

        internal const string ObjectStateManager_DetachedObjectStateEntriesDoesNotExistInObjectStateManager =
            "ObjectStateManager_DetachedObjectStateEntriesDoesNotExistInObjectStateManager";

        internal const string ObjectStateManager_ObjectStateManagerContainsThisEntityKey =
            "ObjectStateManager_ObjectStateManagerContainsThisEntityKey";

        internal const string ObjectStateManager_DoesnotAllowToReAddUnchangedOrModifiedOrDeletedEntity =
            "ObjectStateManager_DoesnotAllowToReAddUnchangedOrModifiedOrDeletedEntity";

        internal const string ObjectStateManager_CannotFixUpKeyToExistingValues = "ObjectStateManager_CannotFixUpKeyToExistingValues";
        internal const string ObjectStateManager_KeyPropertyDoesntMatchValueInKey = "ObjectStateManager_KeyPropertyDoesntMatchValueInKey";

        internal const string ObjectStateManager_KeyPropertyDoesntMatchValueInKeyForAttach =
            "ObjectStateManager_KeyPropertyDoesntMatchValueInKeyForAttach";

        internal const string ObjectStateManager_InvalidKey = "ObjectStateManager_InvalidKey";

        internal const string ObjectStateManager_EntityTypeDoesnotMatchtoEntitySetType =
            "ObjectStateManager_EntityTypeDoesnotMatchtoEntitySetType";

        internal const string ObjectStateManager_GetEntityKeyRequiresObjectToHaveAKey =
            "ObjectStateManager_GetEntityKeyRequiresObjectToHaveAKey";

        internal const string ObjectStateManager_AcceptChangesEntityKeyIsNotValid = "ObjectStateManager_AcceptChangesEntityKeyIsNotValid";
        internal const string ObjectStateManager_EntityConflictsWithKeyEntry = "ObjectStateManager_EntityConflictsWithKeyEntry";

        internal const string ObjectStateManager_CannotGetRelationshipManagerForDetachedPocoEntity =
            "ObjectStateManager_CannotGetRelationshipManagerForDetachedPocoEntity";

        internal const string ObjectStateManager_CannotChangeRelationshipStateEntityDeleted =
            "ObjectStateManager_CannotChangeRelationshipStateEntityDeleted";

        internal const string ObjectStateManager_CannotChangeRelationshipStateEntityAdded =
            "ObjectStateManager_CannotChangeRelationshipStateEntityAdded";

        internal const string ObjectStateManager_CannotChangeRelationshipStateKeyEntry =
            "ObjectStateManager_CannotChangeRelationshipStateKeyEntry";

        internal const string ObjectStateManager_ConflictingChangesOfRelationshipDetected =
            "ObjectStateManager_ConflictingChangesOfRelationshipDetected";

        internal const string ObjectStateManager_ChangeRelationshipStateNotSupportedForForeignKeyAssociations =
            "ObjectStateManager_ChangeRelationshipStateNotSupportedForForeignKeyAssociations";

        internal const string ObjectStateManager_ChangeStateFromAddedWithNullKeyIsInvalid =
            "ObjectStateManager_ChangeStateFromAddedWithNullKeyIsInvalid";

        internal const string ObjectContext_ClientEntityRemovedFromStore = "ObjectContext_ClientEntityRemovedFromStore";
        internal const string ObjectContext_StoreEntityNotPresentInClient = "ObjectContext_StoreEntityNotPresentInClient";
        internal const string ObjectContext_InvalidConnectionString = "ObjectContext_InvalidConnectionString";
        internal const string ObjectContext_InvalidConnection = "ObjectContext_InvalidConnection";
        internal const string ObjectContext_InvalidDataAdapter = "ObjectContext_InvalidDataAdapter";
        internal const string ObjectContext_InvalidDefaultContainerName = "ObjectContext_InvalidDefaultContainerName";
        internal const string ObjectContext_NthElementInAddedState = "ObjectContext_NthElementInAddedState";
        internal const string ObjectContext_NthElementIsDuplicate = "ObjectContext_NthElementIsDuplicate";
        internal const string ObjectContext_NthElementIsNull = "ObjectContext_NthElementIsNull";
        internal const string ObjectContext_NthElementNotInObjectStateManager = "ObjectContext_NthElementNotInObjectStateManager";
        internal const string ObjectContext_ObjectNotFound = "ObjectContext_ObjectNotFound";

        internal const string ObjectContext_CannotDeleteEntityNotInObjectStateManager =
            "ObjectContext_CannotDeleteEntityNotInObjectStateManager";

        internal const string ObjectContext_CannotDetachEntityNotInObjectStateManager =
            "ObjectContext_CannotDetachEntityNotInObjectStateManager";

        internal const string ObjectContext_EntitySetNotFoundForName = "ObjectContext_EntitySetNotFoundForName";
        internal const string ObjectContext_EntityContainerNotFoundForName = "ObjectContext_EntityContainerNotFoundForName";
        internal const string ObjectContext_InvalidCommandTimeout = "ObjectContext_InvalidCommandTimeout";
        internal const string ObjectContext_NoMappingForEntityType = "ObjectContext_NoMappingForEntityType";

        internal const string ObjectContext_EntityAlreadyExistsInObjectStateManager =
            "ObjectContext_EntityAlreadyExistsInObjectStateManager";

        internal const string ObjectContext_InvalidEntitySetInKey = "ObjectContext_InvalidEntitySetInKey";
        internal const string ObjectContext_CannotAttachEntityWithoutKey = "ObjectContext_CannotAttachEntityWithoutKey";
        internal const string ObjectContext_CannotAttachEntityWithTemporaryKey = "ObjectContext_CannotAttachEntityWithTemporaryKey";
        internal const string ObjectContext_EntitySetNameOrEntityKeyRequired = "ObjectContext_EntitySetNameOrEntityKeyRequired";
        internal const string ObjectContext_ExecuteFunctionTypeMismatch = "ObjectContext_ExecuteFunctionTypeMismatch";

        internal const string ObjectContext_ExecuteFunctionCalledWithScalarFunction =
            "ObjectContext_ExecuteFunctionCalledWithScalarFunction";

        internal const string ObjectContext_ExecuteFunctionCalledWithNonQueryFunction =
            "ObjectContext_ExecuteFunctionCalledWithNonQueryFunction";

        internal const string ObjectContext_ExecuteFunctionCalledWithNullParameter = "ObjectContext_ExecuteFunctionCalledWithNullParameter";

        internal const string ObjectContext_ContainerQualifiedEntitySetNameRequired =
            "ObjectContext_ContainerQualifiedEntitySetNameRequired";

        internal const string ObjectContext_CannotSetDefaultContainerName = "ObjectContext_CannotSetDefaultContainerName";
        internal const string ObjectContext_QualfiedEntitySetName = "ObjectContext_QualfiedEntitySetName";
        internal const string ObjectContext_EntitiesHaveDifferentType = "ObjectContext_EntitiesHaveDifferentType";
        internal const string ObjectContext_EntityMustBeUnchangedOrModified = "ObjectContext_EntityMustBeUnchangedOrModified";

        internal const string ObjectContext_EntityMustBeUnchangedOrModifiedOrDeleted =
            "ObjectContext_EntityMustBeUnchangedOrModifiedOrDeleted";

        internal const string ObjectContext_AcceptAllChangesFailure = "ObjectContext_AcceptAllChangesFailure";
        internal const string ObjectContext_CommitWithConceptualNull = "ObjectContext_CommitWithConceptualNull";
        internal const string ObjectContext_InvalidEntitySetOnEntity = "ObjectContext_InvalidEntitySetOnEntity";
        internal const string ObjectContext_InvalidObjectSetTypeForEntitySet = "ObjectContext_InvalidObjectSetTypeForEntitySet";
        internal const string ObjectContext_RequiredMetadataNotAvailble = "ObjectContext_RequiredMetadataNotAvailble";
        internal const string ObjectContext_MetadataHasChanged = "ObjectContext_MetadataHasChanged";
        internal const string ObjectContext_InvalidEntitySetInKeyFromName = "ObjectContext_InvalidEntitySetInKeyFromName";
        internal const string ObjectContext_ObjectDisposed = "ObjectContext_ObjectDisposed";

        internal const string ObjectContext_CannotExplicitlyLoadDetachedRelationships =
            "ObjectContext_CannotExplicitlyLoadDetachedRelationships";

        internal const string ObjectContext_CannotLoadReferencesUsingDifferentContext =
            "ObjectContext_CannotLoadReferencesUsingDifferentContext";

        internal const string ObjectContext_SelectorExpressionMustBeMemberAccess = "ObjectContext_SelectorExpressionMustBeMemberAccess";

        internal const string ObjectContext_MultipleEntitySetsFoundInSingleContainer =
            "ObjectContext_MultipleEntitySetsFoundInSingleContainer";

        internal const string ObjectContext_MultipleEntitySetsFoundInAllContainers = "ObjectContext_MultipleEntitySetsFoundInAllContainers";
        internal const string ObjectContext_NoEntitySetFoundForType = "ObjectContext_NoEntitySetFoundForType";
        internal const string ObjectContext_EntityNotInObjectSet_Delete = "ObjectContext_EntityNotInObjectSet_Delete";
        internal const string ObjectContext_EntityNotInObjectSet_Detach = "ObjectContext_EntityNotInObjectSet_Detach";
        internal const string ObjectContext_InvalidEntityState = "ObjectContext_InvalidEntityState";
        internal const string ObjectContext_InvalidRelationshipState = "ObjectContext_InvalidRelationshipState";
        internal const string ObjectContext_EntityNotTrackedOrHasTempKey = "ObjectContext_EntityNotTrackedOrHasTempKey";

        internal const string ObjectContext_ExecuteCommandWithMixOfDbParameterAndValues =
            "ObjectContext_ExecuteCommandWithMixOfDbParameterAndValues";

        internal const string ObjectContext_InvalidEntitySetForStoreQuery = "ObjectContext_InvalidEntitySetForStoreQuery";
        internal const string ObjectContext_InvalidTypeForStoreQuery = "ObjectContext_InvalidTypeForStoreQuery";
        internal const string ObjectContext_TwoPropertiesMappedToSameColumn = "ObjectContext_TwoPropertiesMappedToSameColumn";
        internal const string RelatedEnd_InvalidOwnerStateForAttach = "RelatedEnd_InvalidOwnerStateForAttach";
        internal const string RelatedEnd_InvalidNthElementNullForAttach = "RelatedEnd_InvalidNthElementNullForAttach";
        internal const string RelatedEnd_InvalidNthElementContextForAttach = "RelatedEnd_InvalidNthElementContextForAttach";
        internal const string RelatedEnd_InvalidNthElementStateForAttach = "RelatedEnd_InvalidNthElementStateForAttach";
        internal const string RelatedEnd_InvalidEntityContextForAttach = "RelatedEnd_InvalidEntityContextForAttach";
        internal const string RelatedEnd_InvalidEntityStateForAttach = "RelatedEnd_InvalidEntityStateForAttach";
        internal const string RelatedEnd_UnableToAddEntity = "RelatedEnd_UnableToAddEntity";
        internal const string RelatedEnd_UnableToRemoveEntity = "RelatedEnd_UnableToRemoveEntity";
        internal const string RelatedEnd_UnableToAddRelationshipWithDeletedEntity = "RelatedEnd_UnableToAddRelationshipWithDeletedEntity";
        internal const string RelatedEnd_ConflictingChangeOfRelationshipDetected = "RelatedEnd_ConflictingChangeOfRelationshipDetected";
        internal const string RelatedEnd_InvalidRelationshipFixupDetected = "RelatedEnd_InvalidRelationshipFixupDetected";
        internal const string RelatedEnd_CannotSerialize = "RelatedEnd_CannotSerialize";
        internal const string RelatedEnd_CannotAddToFixedSizeArray = "RelatedEnd_CannotAddToFixedSizeArray";
        internal const string RelatedEnd_CannotRemoveFromFixedSizeArray = "RelatedEnd_CannotRemoveFromFixedSizeArray";
        internal const string Materializer_PropertyIsNotNullable = "Materializer_PropertyIsNotNullable";
        internal const string Materializer_PropertyIsNotNullableWithName = "Materializer_PropertyIsNotNullableWithName";
        internal const string Materializer_SetInvalidValue = "Materializer_SetInvalidValue";
        internal const string Materializer_InvalidCastReference = "Materializer_InvalidCastReference";
        internal const string Materializer_InvalidCastNullable = "Materializer_InvalidCastNullable";
        internal const string Materializer_NullReferenceCast = "Materializer_NullReferenceCast";
        internal const string Materializer_RecyclingEntity = "Materializer_RecyclingEntity";
        internal const string Materializer_AddedEntityAlreadyExists = "Materializer_AddedEntityAlreadyExists";
        internal const string Materializer_CannotReEnumerateQueryResults = "Materializer_CannotReEnumerateQueryResults";
        internal const string Materializer_UnsupportedType = "Materializer_UnsupportedType";
        internal const string Collections_NoRelationshipSetMatched = "Collections_NoRelationshipSetMatched";
        internal const string Collections_ExpectedCollectionGotReference = "Collections_ExpectedCollectionGotReference";
        internal const string Collections_InvalidEntityStateSource = "Collections_InvalidEntityStateSource";
        internal const string Collections_InvalidEntityStateLoad = "Collections_InvalidEntityStateLoad";
        internal const string Collections_CannotFillTryDifferentMergeOption = "Collections_CannotFillTryDifferentMergeOption";
        internal const string Collections_UnableToMergeCollections = "Collections_UnableToMergeCollections";
        internal const string EntityReference_ExpectedReferenceGotCollection = "EntityReference_ExpectedReferenceGotCollection";

        internal const string EntityReference_CannotAddMoreThanOneEntityToEntityReference =
            "EntityReference_CannotAddMoreThanOneEntityToEntityReference";

        internal const string EntityReference_LessThanExpectedRelatedEntitiesFound = "EntityReference_LessThanExpectedRelatedEntitiesFound";
        internal const string EntityReference_MoreThanExpectedRelatedEntitiesFound = "EntityReference_MoreThanExpectedRelatedEntitiesFound";

        internal const string EntityReference_CannotChangeReferentialConstraintProperty =
            "EntityReference_CannotChangeReferentialConstraintProperty";

        internal const string EntityReference_CannotSetSpecialKeys = "EntityReference_CannotSetSpecialKeys";
        internal const string EntityReference_EntityKeyValueMismatch = "EntityReference_EntityKeyValueMismatch";
        internal const string RelatedEnd_RelatedEndNotFound = "RelatedEnd_RelatedEndNotFound";
        internal const string RelatedEnd_RelatedEndNotAttachedToContext = "RelatedEnd_RelatedEndNotAttachedToContext";
        internal const string RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd = "RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd";

        internal const string RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd =
            "RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd";

        internal const string RelatedEnd_InvalidContainedType_Collection = "RelatedEnd_InvalidContainedType_Collection";
        internal const string RelatedEnd_InvalidContainedType_Reference = "RelatedEnd_InvalidContainedType_Reference";

        internal const string RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities =
            "RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities";

        internal const string RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts =
            "RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts";

        internal const string RelatedEnd_MismatchedMergeOptionOnLoad = "RelatedEnd_MismatchedMergeOptionOnLoad";
        internal const string RelatedEnd_EntitySetIsNotValidForRelationship = "RelatedEnd_EntitySetIsNotValidForRelationship";
        internal const string RelatedEnd_OwnerIsNull = "RelatedEnd_OwnerIsNull";

        internal const string RelationshipManager_UnableToRetrieveReferentialConstraintProperties =
            "RelationshipManager_UnableToRetrieveReferentialConstraintProperties";

        internal const string RelationshipManager_InconsistentReferentialConstraintProperties =
            "RelationshipManager_InconsistentReferentialConstraintProperties";

        internal const string RelationshipManager_CircularRelationshipsWithReferentialConstraints =
            "RelationshipManager_CircularRelationshipsWithReferentialConstraints";

        internal const string RelationshipManager_UnableToFindRelationshipTypeInMetadata =
            "RelationshipManager_UnableToFindRelationshipTypeInMetadata";

        internal const string RelationshipManager_InvalidTargetRole = "RelationshipManager_InvalidTargetRole";
        internal const string RelationshipManager_UnexpectedNull = "RelationshipManager_UnexpectedNull";
        internal const string RelationshipManager_InvalidRelationshipManagerOwner = "RelationshipManager_InvalidRelationshipManagerOwner";
        internal const string RelationshipManager_OwnerIsNotSourceType = "RelationshipManager_OwnerIsNotSourceType";
        internal const string RelationshipManager_UnexpectedNullContext = "RelationshipManager_UnexpectedNullContext";
        internal const string RelationshipManager_ReferenceAlreadyInitialized = "RelationshipManager_ReferenceAlreadyInitialized";
        internal const string RelationshipManager_RelationshipManagerAttached = "RelationshipManager_RelationshipManagerAttached";
        internal const string RelationshipManager_InitializeIsForDeserialization = "RelationshipManager_InitializeIsForDeserialization";
        internal const string RelationshipManager_CollectionAlreadyInitialized = "RelationshipManager_CollectionAlreadyInitialized";

        internal const string RelationshipManager_CollectionRelationshipManagerAttached =
            "RelationshipManager_CollectionRelationshipManagerAttached";

        internal const string RelationshipManager_CollectionInitializeIsForDeserialization =
            "RelationshipManager_CollectionInitializeIsForDeserialization";

        internal const string RelationshipManager_NavigationPropertyNotFound = "RelationshipManager_NavigationPropertyNotFound";

        internal const string RelationshipManager_CannotGetRelatEndForDetachedPocoEntity =
            "RelationshipManager_CannotGetRelatEndForDetachedPocoEntity";

        internal const string ObjectView_CannotReplacetheEntityorRow = "ObjectView_CannotReplacetheEntityorRow";
        internal const string ObjectView_IndexBasedInsertIsNotSupported = "ObjectView_IndexBasedInsertIsNotSupported";

        internal const string ObjectView_WriteOperationNotAllowedOnReadOnlyBindingList =
            "ObjectView_WriteOperationNotAllowedOnReadOnlyBindingList";

        internal const string ObjectView_AddNewOperationNotAllowedOnAbstractBindingList =
            "ObjectView_AddNewOperationNotAllowedOnAbstractBindingList";

        internal const string ObjectView_IncompatibleArgument = "ObjectView_IncompatibleArgument";
        internal const string ObjectView_CannotResolveTheEntitySet = "ObjectView_CannotResolveTheEntitySet";
        internal const string CodeGen_ConstructorNoParameterless = "CodeGen_ConstructorNoParameterless";
        internal const string CodeGen_PropertyDeclaringTypeIsValueType = "CodeGen_PropertyDeclaringTypeIsValueType";
        internal const string CodeGen_PropertyStrongNameIdentity = "CodeGen_PropertyStrongNameIdentity";
        internal const string CodeGen_PropertyUnsupportedForm = "CodeGen_PropertyUnsupportedForm";
        internal const string CodeGen_PropertyUnsupportedType = "CodeGen_PropertyUnsupportedType";
        internal const string CodeGen_PropertyIsIndexed = "CodeGen_PropertyIsIndexed";
        internal const string CodeGen_PropertyIsStatic = "CodeGen_PropertyIsStatic";
        internal const string CodeGen_PropertyNoGetter = "CodeGen_PropertyNoGetter";
        internal const string CodeGen_PropertyNoSetter = "CodeGen_PropertyNoSetter";
        internal const string PocoEntityWrapper_UnableToSetFieldOrProperty = "PocoEntityWrapper_UnableToSetFieldOrProperty";

        internal const string PocoEntityWrapper_UnexpectedTypeForNavigationProperty =
            "PocoEntityWrapper_UnexpectedTypeForNavigationProperty";

        internal const string PocoEntityWrapper_UnableToMaterializeArbitaryNavPropType =
            "PocoEntityWrapper_UnableToMaterializeArbitaryNavPropType";

        internal const string GeneralQueryError = "GeneralQueryError";
        internal const string CtxAlias = "CtxAlias";
        internal const string CtxAliasedNamespaceImport = "CtxAliasedNamespaceImport";
        internal const string CtxAnd = "CtxAnd";
        internal const string CtxAnyElement = "CtxAnyElement";
        internal const string CtxApplyClause = "CtxApplyClause";
        internal const string CtxBetween = "CtxBetween";
        internal const string CtxCase = "CtxCase";
        internal const string CtxCaseElse = "CtxCaseElse";
        internal const string CtxCaseWhenThen = "CtxCaseWhenThen";
        internal const string CtxCast = "CtxCast";
        internal const string CtxCollatedOrderByClauseItem = "CtxCollatedOrderByClauseItem";
        internal const string CtxCollectionTypeDefinition = "CtxCollectionTypeDefinition";
        internal const string CtxCommandExpression = "CtxCommandExpression";
        internal const string CtxCreateRef = "CtxCreateRef";
        internal const string CtxDeref = "CtxDeref";
        internal const string CtxDivide = "CtxDivide";
        internal const string CtxElement = "CtxElement";
        internal const string CtxEquals = "CtxEquals";
        internal const string CtxEscapedIdentifier = "CtxEscapedIdentifier";
        internal const string CtxExcept = "CtxExcept";
        internal const string CtxExists = "CtxExists";
        internal const string CtxExpressionList = "CtxExpressionList";
        internal const string CtxFlatten = "CtxFlatten";
        internal const string CtxFromApplyClause = "CtxFromApplyClause";
        internal const string CtxFromClause = "CtxFromClause";
        internal const string CtxFromClauseItem = "CtxFromClauseItem";
        internal const string CtxFromClauseList = "CtxFromClauseList";
        internal const string CtxFromJoinClause = "CtxFromJoinClause";
        internal const string CtxFunction = "CtxFunction";
        internal const string CtxFunctionDefinition = "CtxFunctionDefinition";
        internal const string CtxGreaterThan = "CtxGreaterThan";
        internal const string CtxGreaterThanEqual = "CtxGreaterThanEqual";
        internal const string CtxGroupByClause = "CtxGroupByClause";
        internal const string CtxGroupPartition = "CtxGroupPartition";
        internal const string CtxHavingClause = "CtxHavingClause";
        internal const string CtxIdentifier = "CtxIdentifier";
        internal const string CtxIn = "CtxIn";
        internal const string CtxIntersect = "CtxIntersect";
        internal const string CtxIsNotNull = "CtxIsNotNull";
        internal const string CtxIsNotOf = "CtxIsNotOf";
        internal const string CtxIsNull = "CtxIsNull";
        internal const string CtxIsOf = "CtxIsOf";
        internal const string CtxJoinClause = "CtxJoinClause";
        internal const string CtxJoinOnClause = "CtxJoinOnClause";
        internal const string CtxKey = "CtxKey";
        internal const string CtxLessThan = "CtxLessThan";
        internal const string CtxLessThanEqual = "CtxLessThanEqual";
        internal const string CtxLike = "CtxLike";
        internal const string CtxLimitSubClause = "CtxLimitSubClause";
        internal const string CtxLiteral = "CtxLiteral";
        internal const string CtxMemberAccess = "CtxMemberAccess";
        internal const string CtxMethod = "CtxMethod";
        internal const string CtxMinus = "CtxMinus";
        internal const string CtxModulus = "CtxModulus";
        internal const string CtxMultiply = "CtxMultiply";
        internal const string CtxMultisetCtor = "CtxMultisetCtor";
        internal const string CtxNamespaceImport = "CtxNamespaceImport";
        internal const string CtxNamespaceImportList = "CtxNamespaceImportList";
        internal const string CtxNavigate = "CtxNavigate";
        internal const string CtxNot = "CtxNot";
        internal const string CtxNotBetween = "CtxNotBetween";
        internal const string CtxNotEqual = "CtxNotEqual";
        internal const string CtxNotIn = "CtxNotIn";
        internal const string CtxNotLike = "CtxNotLike";
        internal const string CtxNullLiteral = "CtxNullLiteral";
        internal const string CtxOfType = "CtxOfType";
        internal const string CtxOfTypeOnly = "CtxOfTypeOnly";
        internal const string CtxOr = "CtxOr";
        internal const string CtxOrderByClause = "CtxOrderByClause";
        internal const string CtxOrderByClauseItem = "CtxOrderByClauseItem";
        internal const string CtxOverlaps = "CtxOverlaps";
        internal const string CtxParen = "CtxParen";
        internal const string CtxPlus = "CtxPlus";
        internal const string CtxTypeNameWithTypeSpec = "CtxTypeNameWithTypeSpec";
        internal const string CtxQueryExpression = "CtxQueryExpression";
        internal const string CtxQueryStatement = "CtxQueryStatement";
        internal const string CtxRef = "CtxRef";
        internal const string CtxRefTypeDefinition = "CtxRefTypeDefinition";
        internal const string CtxRelationship = "CtxRelationship";
        internal const string CtxRelationshipList = "CtxRelationshipList";
        internal const string CtxRowCtor = "CtxRowCtor";
        internal const string CtxRowTypeDefinition = "CtxRowTypeDefinition";
        internal const string CtxSelectRowClause = "CtxSelectRowClause";
        internal const string CtxSelectValueClause = "CtxSelectValueClause";
        internal const string CtxSet = "CtxSet";
        internal const string CtxSimpleIdentifier = "CtxSimpleIdentifier";
        internal const string CtxSkipSubClause = "CtxSkipSubClause";
        internal const string CtxTopSubClause = "CtxTopSubClause";
        internal const string CtxTreat = "CtxTreat";
        internal const string CtxTypeCtor = "CtxTypeCtor";
        internal const string CtxTypeName = "CtxTypeName";
        internal const string CtxUnaryMinus = "CtxUnaryMinus";
        internal const string CtxUnaryPlus = "CtxUnaryPlus";
        internal const string CtxUnion = "CtxUnion";
        internal const string CtxUnionAll = "CtxUnionAll";
        internal const string CtxWhereClause = "CtxWhereClause";
        internal const string CannotConvertNumericLiteral = "CannotConvertNumericLiteral";
        internal const string GenericSyntaxError = "GenericSyntaxError";
        internal const string InFromClause = "InFromClause";
        internal const string InGroupClause = "InGroupClause";
        internal const string InRowCtor = "InRowCtor";
        internal const string InSelectProjectionList = "InSelectProjectionList";
        internal const string InvalidAliasName = "InvalidAliasName";
        internal const string InvalidEmptyIdentifier = "InvalidEmptyIdentifier";
        internal const string InvalidEmptyQuery = "InvalidEmptyQuery";
        internal const string InvalidEmptyQueryTextArgument = "InvalidEmptyQueryTextArgument";
        internal const string InvalidEscapedIdentifier = "InvalidEscapedIdentifier";
        internal const string InvalidEscapedIdentifierUnbalanced = "InvalidEscapedIdentifierUnbalanced";
        internal const string InvalidOperatorSymbol = "InvalidOperatorSymbol";
        internal const string InvalidPunctuatorSymbol = "InvalidPunctuatorSymbol";
        internal const string InvalidSimpleIdentifier = "InvalidSimpleIdentifier";
        internal const string InvalidSimpleIdentifierNonASCII = "InvalidSimpleIdentifierNonASCII";
        internal const string LocalizedCollection = "LocalizedCollection";
        internal const string LocalizedColumn = "LocalizedColumn";
        internal const string LocalizedComplex = "LocalizedComplex";
        internal const string LocalizedEntity = "LocalizedEntity";
        internal const string LocalizedEntityContainerExpression = "LocalizedEntityContainerExpression";
        internal const string LocalizedFunction = "LocalizedFunction";
        internal const string LocalizedInlineFunction = "LocalizedInlineFunction";
        internal const string LocalizedKeyword = "LocalizedKeyword";
        internal const string LocalizedLeft = "LocalizedLeft";
        internal const string LocalizedLine = "LocalizedLine";
        internal const string LocalizedMetadataMemberExpression = "LocalizedMetadataMemberExpression";
        internal const string LocalizedNamespace = "LocalizedNamespace";
        internal const string LocalizedNear = "LocalizedNear";
        internal const string LocalizedPrimitive = "LocalizedPrimitive";
        internal const string LocalizedReference = "LocalizedReference";
        internal const string LocalizedRight = "LocalizedRight";
        internal const string LocalizedRow = "LocalizedRow";
        internal const string LocalizedTerm = "LocalizedTerm";
        internal const string LocalizedType = "LocalizedType";
        internal const string LocalizedEnumMember = "LocalizedEnumMember";
        internal const string LocalizedValueExpression = "LocalizedValueExpression";
        internal const string AliasNameAlreadyUsed = "AliasNameAlreadyUsed";
        internal const string AmbiguousFunctionArguments = "AmbiguousFunctionArguments";
        internal const string AmbiguousMetadataMemberName = "AmbiguousMetadataMemberName";
        internal const string ArgumentTypesAreIncompatible = "ArgumentTypesAreIncompatible";
        internal const string BetweenLimitsCannotBeUntypedNulls = "BetweenLimitsCannotBeUntypedNulls";
        internal const string BetweenLimitsTypesAreNotCompatible = "BetweenLimitsTypesAreNotCompatible";
        internal const string BetweenLimitsTypesAreNotOrderComparable = "BetweenLimitsTypesAreNotOrderComparable";
        internal const string BetweenValueIsNotOrderComparable = "BetweenValueIsNotOrderComparable";
        internal const string CannotCreateEmptyMultiset = "CannotCreateEmptyMultiset";
        internal const string CannotCreateMultisetofNulls = "CannotCreateMultisetofNulls";
        internal const string CannotInstantiateAbstractType = "CannotInstantiateAbstractType";
        internal const string CannotResolveNameToTypeOrFunction = "CannotResolveNameToTypeOrFunction";
        internal const string ConcatBuiltinNotSupported = "ConcatBuiltinNotSupported";
        internal const string CouldNotResolveIdentifier = "CouldNotResolveIdentifier";
        internal const string CreateRefTypeIdentifierMustBeASubOrSuperType = "CreateRefTypeIdentifierMustBeASubOrSuperType";
        internal const string CreateRefTypeIdentifierMustSpecifyAnEntityType = "CreateRefTypeIdentifierMustSpecifyAnEntityType";
        internal const string DeRefArgIsNotOfRefType = "DeRefArgIsNotOfRefType";
        internal const string DuplicatedInlineFunctionOverload = "DuplicatedInlineFunctionOverload";
        internal const string ElementOperatorIsNotSupported = "ElementOperatorIsNotSupported";
        internal const string MemberDoesNotBelongToEntityContainer = "MemberDoesNotBelongToEntityContainer";
        internal const string ExpressionCannotBeNull = "ExpressionCannotBeNull";
        internal const string OfTypeExpressionElementTypeMustBeEntityType = "OfTypeExpressionElementTypeMustBeEntityType";
        internal const string OfTypeExpressionElementTypeMustBeNominalType = "OfTypeExpressionElementTypeMustBeNominalType";
        internal const string ExpressionMustBeCollection = "ExpressionMustBeCollection";
        internal const string ExpressionMustBeNumericType = "ExpressionMustBeNumericType";
        internal const string ExpressionTypeMustBeBoolean = "ExpressionTypeMustBeBoolean";
        internal const string ExpressionTypeMustBeEqualComparable = "ExpressionTypeMustBeEqualComparable";
        internal const string ExpressionTypeMustBeEntityType = "ExpressionTypeMustBeEntityType";
        internal const string ExpressionTypeMustBeNominalType = "ExpressionTypeMustBeNominalType";
        internal const string ExpressionTypeMustNotBeCollection = "ExpressionTypeMustNotBeCollection";
        internal const string ExprIsNotValidEntitySetForCreateRef = "ExprIsNotValidEntitySetForCreateRef";
        internal const string FailedToResolveAggregateFunction = "FailedToResolveAggregateFunction";
        internal const string GeneralExceptionAsQueryInnerException = "GeneralExceptionAsQueryInnerException";
        internal const string GroupingKeysMustBeEqualComparable = "GroupingKeysMustBeEqualComparable";
        internal const string GroupPartitionOutOfContext = "GroupPartitionOutOfContext";
        internal const string HavingRequiresGroupClause = "HavingRequiresGroupClause";
        internal const string ImcompatibleCreateRefKeyElementType = "ImcompatibleCreateRefKeyElementType";
        internal const string ImcompatibleCreateRefKeyType = "ImcompatibleCreateRefKeyType";
        internal const string InnerJoinMustHaveOnPredicate = "InnerJoinMustHaveOnPredicate";
        internal const string InvalidAssociationTypeForUnion = "InvalidAssociationTypeForUnion";
        internal const string InvalidCaseResultTypes = "InvalidCaseResultTypes";
        internal const string InvalidCaseWhenThenNullType = "InvalidCaseWhenThenNullType";
        internal const string InvalidCast = "InvalidCast";
        internal const string InvalidCastExpressionType = "InvalidCastExpressionType";
        internal const string InvalidCastType = "InvalidCastType";
        internal const string InvalidComplexType = "InvalidComplexType";
        internal const string InvalidCreateRefKeyType = "InvalidCreateRefKeyType";
        internal const string InvalidCtorArgumentType = "InvalidCtorArgumentType";
        internal const string InvalidCtorUseOnType = "InvalidCtorUseOnType";
        internal const string InvalidDateTimeOffsetLiteral = "InvalidDateTimeOffsetLiteral";
        internal const string InvalidDay = "InvalidDay";
        internal const string InvalidDayInMonth = "InvalidDayInMonth";
        internal const string InvalidDeRefProperty = "InvalidDeRefProperty";
        internal const string InvalidDistinctArgumentInCtor = "InvalidDistinctArgumentInCtor";
        internal const string InvalidDistinctArgumentInNonAggFunction = "InvalidDistinctArgumentInNonAggFunction";
        internal const string InvalidEntityRootTypeArgument = "InvalidEntityRootTypeArgument";
        internal const string InvalidEntityTypeArgument = "InvalidEntityTypeArgument";
        internal const string InvalidExpressionResolutionClass = "InvalidExpressionResolutionClass";
        internal const string InvalidFlattenArgument = "InvalidFlattenArgument";
        internal const string InvalidGroupIdentifierReference = "InvalidGroupIdentifierReference";
        internal const string InvalidHour = "InvalidHour";
        internal const string InvalidImplicitRelationshipFromEnd = "InvalidImplicitRelationshipFromEnd";
        internal const string InvalidImplicitRelationshipToEnd = "InvalidImplicitRelationshipToEnd";
        internal const string InvalidInExprArgs = "InvalidInExprArgs";
        internal const string InvalidJoinLeftCorrelation = "InvalidJoinLeftCorrelation";
        internal const string InvalidKeyArgument = "InvalidKeyArgument";
        internal const string InvalidKeyTypeForCollation = "InvalidKeyTypeForCollation";
        internal const string InvalidLiteralFormat = "InvalidLiteralFormat";
        internal const string InvalidMetadataMemberName = "InvalidMetadataMemberName";
        internal const string InvalidMinute = "InvalidMinute";
        internal const string InvalidModeForWithRelationshipClause = "InvalidModeForWithRelationshipClause";
        internal const string InvalidMonth = "InvalidMonth";
        internal const string InvalidNamespaceAlias = "InvalidNamespaceAlias";
        internal const string InvalidNullArithmetic = "InvalidNullArithmetic";
        internal const string InvalidNullComparison = "InvalidNullComparison";
        internal const string InvalidNullLiteralForNonNullableMember = "InvalidNullLiteralForNonNullableMember";
        internal const string InvalidParameterFormat = "InvalidParameterFormat";
        internal const string InvalidPlaceholderRootTypeArgument = "InvalidPlaceholderRootTypeArgument";
        internal const string InvalidPlaceholderTypeArgument = "InvalidPlaceholderTypeArgument";
        internal const string InvalidPredicateForCrossJoin = "InvalidPredicateForCrossJoin";
        internal const string InvalidRelationshipMember = "InvalidRelationshipMember";
        internal const string InvalidMetadataMemberClassResolution = "InvalidMetadataMemberClassResolution";
        internal const string InvalidRootComplexType = "InvalidRootComplexType";
        internal const string InvalidRootRowType = "InvalidRootRowType";
        internal const string InvalidRowType = "InvalidRowType";
        internal const string InvalidSecond = "InvalidSecond";
        internal const string InvalidSelectValueAliasedExpression = "InvalidSelectValueAliasedExpression";
        internal const string InvalidSelectValueList = "InvalidSelectValueList";
        internal const string InvalidTypeForWithRelationshipClause = "InvalidTypeForWithRelationshipClause";
        internal const string InvalidUnarySetOpArgument = "InvalidUnarySetOpArgument";
        internal const string InvalidUnsignedTypeForUnaryMinusOperation = "InvalidUnsignedTypeForUnaryMinusOperation";
        internal const string InvalidYear = "InvalidYear";
        internal const string InvalidWithRelationshipTargetEndMultiplicity = "InvalidWithRelationshipTargetEndMultiplicity";
        internal const string InvalidQueryResultType = "InvalidQueryResultType";
        internal const string IsNullInvalidType = "IsNullInvalidType";
        internal const string KeyMustBeCorrelated = "KeyMustBeCorrelated";
        internal const string LeftSetExpressionArgsMustBeCollection = "LeftSetExpressionArgsMustBeCollection";
        internal const string LikeArgMustBeStringType = "LikeArgMustBeStringType";
        internal const string LiteralTypeNotFoundInMetadata = "LiteralTypeNotFoundInMetadata";
        internal const string MalformedSingleQuotePayload = "MalformedSingleQuotePayload";
        internal const string MalformedStringLiteralPayload = "MalformedStringLiteralPayload";
        internal const string MethodInvocationNotSupported = "MethodInvocationNotSupported";
        internal const string MultipleDefinitionsOfParameter = "MultipleDefinitionsOfParameter";
        internal const string MultipleDefinitionsOfVariable = "MultipleDefinitionsOfVariable";
        internal const string MultisetElemsAreNotTypeCompatible = "MultisetElemsAreNotTypeCompatible";
        internal const string NamespaceAliasAlreadyUsed = "NamespaceAliasAlreadyUsed";
        internal const string NamespaceAlreadyImported = "NamespaceAlreadyImported";
        internal const string NestedAggregateCannotBeUsedInAggregate = "NestedAggregateCannotBeUsedInAggregate";
        internal const string NoAggrFunctionOverloadMatch = "NoAggrFunctionOverloadMatch";
        internal const string NoCanonicalAggrFunctionOverloadMatch = "NoCanonicalAggrFunctionOverloadMatch";
        internal const string NoCanonicalFunctionOverloadMatch = "NoCanonicalFunctionOverloadMatch";
        internal const string NoFunctionOverloadMatch = "NoFunctionOverloadMatch";
        internal const string NotAMemberOfCollection = "NotAMemberOfCollection";
        internal const string NotAMemberOfType = "NotAMemberOfType";
        internal const string NotASuperOrSubType = "NotASuperOrSubType";
        internal const string NullLiteralCannotBePromotedToCollectionOfNulls = "NullLiteralCannotBePromotedToCollectionOfNulls";
        internal const string NumberOfTypeCtorIsLessThenFormalSpec = "NumberOfTypeCtorIsLessThenFormalSpec";
        internal const string NumberOfTypeCtorIsMoreThenFormalSpec = "NumberOfTypeCtorIsMoreThenFormalSpec";
        internal const string OrderByKeyIsNotOrderComparable = "OrderByKeyIsNotOrderComparable";
        internal const string OfTypeOnlyTypeArgumentCannotBeAbstract = "OfTypeOnlyTypeArgumentCannotBeAbstract";
        internal const string ParameterTypeNotSupported = "ParameterTypeNotSupported";
        internal const string ParameterWasNotDefined = "ParameterWasNotDefined";
        internal const string PlaceholderExpressionMustBeCompatibleWithEdm64 = "PlaceholderExpressionMustBeCompatibleWithEdm64";
        internal const string PlaceholderExpressionMustBeConstant = "PlaceholderExpressionMustBeConstant";
        internal const string PlaceholderExpressionMustBeGreaterThanOrEqualToZero = "PlaceholderExpressionMustBeGreaterThanOrEqualToZero";
        internal const string PlaceholderSetArgTypeIsNotEqualComparable = "PlaceholderSetArgTypeIsNotEqualComparable";
        internal const string PlusLeftExpressionInvalidType = "PlusLeftExpressionInvalidType";
        internal const string PlusRightExpressionInvalidType = "PlusRightExpressionInvalidType";
        internal const string PrecisionMustBeGreaterThanScale = "PrecisionMustBeGreaterThanScale";
        internal const string RefArgIsNotOfEntityType = "RefArgIsNotOfEntityType";
        internal const string RefTypeIdentifierMustSpecifyAnEntityType = "RefTypeIdentifierMustSpecifyAnEntityType";
        internal const string RelatedEndExprTypeMustBeReference = "RelatedEndExprTypeMustBeReference";
        internal const string RelatedEndExprTypeMustBePromotoableToToEnd = "RelatedEndExprTypeMustBePromotoableToToEnd";
        internal const string RelationshipFromEndIsAmbiguos = "RelationshipFromEndIsAmbiguos";
        internal const string RelationshipTypeExpected = "RelationshipTypeExpected";
        internal const string RelationshipToEndIsAmbiguos = "RelationshipToEndIsAmbiguos";
        internal const string RelationshipTargetMustBeUnique = "RelationshipTargetMustBeUnique";
        internal const string ResultingExpressionTypeCannotBeNull = "ResultingExpressionTypeCannotBeNull";
        internal const string RightSetExpressionArgsMustBeCollection = "RightSetExpressionArgsMustBeCollection";
        internal const string RowCtorElementCannotBeNull = "RowCtorElementCannotBeNull";
        internal const string SelectDistinctMustBeEqualComparable = "SelectDistinctMustBeEqualComparable";
        internal const string SourceTypeMustBePromotoableToFromEndRelationType = "SourceTypeMustBePromotoableToFromEndRelationType";
        internal const string TopAndLimitCannotCoexist = "TopAndLimitCannotCoexist";
        internal const string TopAndSkipCannotCoexist = "TopAndSkipCannotCoexist";
        internal const string TypeDoesNotSupportSpec = "TypeDoesNotSupportSpec";
        internal const string TypeDoesNotSupportFacet = "TypeDoesNotSupportFacet";
        internal const string TypeArgumentCountMismatch = "TypeArgumentCountMismatch";
        internal const string TypeArgumentMustBeLiteral = "TypeArgumentMustBeLiteral";
        internal const string TypeArgumentBelowMin = "TypeArgumentBelowMin";
        internal const string TypeArgumentExceedsMax = "TypeArgumentExceedsMax";
        internal const string TypeArgumentIsNotValid = "TypeArgumentIsNotValid";
        internal const string TypeKindMismatch = "TypeKindMismatch";
        internal const string TypeMustBeInheritableType = "TypeMustBeInheritableType";
        internal const string TypeMustBeEntityType = "TypeMustBeEntityType";
        internal const string TypeMustBeNominalType = "TypeMustBeNominalType";
        internal const string TypeNameNotFound = "TypeNameNotFound";
        internal const string GroupVarNotFoundInScope = "GroupVarNotFoundInScope";
        internal const string InvalidArgumentTypeForAggregateFunction = "InvalidArgumentTypeForAggregateFunction";
        internal const string InvalidSavePoint = "InvalidSavePoint";
        internal const string InvalidScopeIndex = "InvalidScopeIndex";
        internal const string LiteralTypeNotSupported = "LiteralTypeNotSupported";
        internal const string ParserFatalError = "ParserFatalError";
        internal const string ParserInputError = "ParserInputError";
        internal const string StackOverflowInParser = "StackOverflowInParser";
        internal const string UnknownAstCommandExpression = "UnknownAstCommandExpression";
        internal const string UnknownAstExpressionType = "UnknownAstExpressionType";
        internal const string UnknownBuiltInAstExpressionType = "UnknownBuiltInAstExpressionType";
        internal const string UnknownExpressionResolutionClass = "UnknownExpressionResolutionClass";
        internal const string Cqt_General_UnsupportedExpression = "Cqt_General_UnsupportedExpression";
        internal const string Cqt_General_PolymorphicTypeRequired = "Cqt_General_PolymorphicTypeRequired";
        internal const string Cqt_General_PolymorphicArgRequired = "Cqt_General_PolymorphicArgRequired";
        internal const string Cqt_General_MetadataNotReadOnly = "Cqt_General_MetadataNotReadOnly";
        internal const string Cqt_General_NoProviderBooleanType = "Cqt_General_NoProviderBooleanType";
        internal const string Cqt_General_NoProviderIntegerType = "Cqt_General_NoProviderIntegerType";
        internal const string Cqt_General_NoProviderStringType = "Cqt_General_NoProviderStringType";
        internal const string Cqt_Metadata_EdmMemberIncorrectSpace = "Cqt_Metadata_EdmMemberIncorrectSpace";
        internal const string Cqt_Metadata_EntitySetEntityContainerNull = "Cqt_Metadata_EntitySetEntityContainerNull";
        internal const string Cqt_Metadata_EntitySetIncorrectSpace = "Cqt_Metadata_EntitySetIncorrectSpace";
        internal const string Cqt_Metadata_EntityTypeNullKeyMembersInvalid = "Cqt_Metadata_EntityTypeNullKeyMembersInvalid";
        internal const string Cqt_Metadata_EntityTypeEmptyKeyMembersInvalid = "Cqt_Metadata_EntityTypeEmptyKeyMembersInvalid";
        internal const string Cqt_Metadata_FunctionReturnParameterNull = "Cqt_Metadata_FunctionReturnParameterNull";
        internal const string Cqt_Metadata_FunctionIncorrectSpace = "Cqt_Metadata_FunctionIncorrectSpace";
        internal const string Cqt_Metadata_FunctionParameterIncorrectSpace = "Cqt_Metadata_FunctionParameterIncorrectSpace";
        internal const string Cqt_Metadata_TypeUsageIncorrectSpace = "Cqt_Metadata_TypeUsageIncorrectSpace";
        internal const string Cqt_Exceptions_InvalidCommandTree = "Cqt_Exceptions_InvalidCommandTree";
        internal const string Cqt_Util_CheckListEmptyInvalid = "Cqt_Util_CheckListEmptyInvalid";
        internal const string Cqt_Util_CheckListDuplicateName = "Cqt_Util_CheckListDuplicateName";
        internal const string Cqt_ExpressionLink_TypeMismatch = "Cqt_ExpressionLink_TypeMismatch";
        internal const string Cqt_ExpressionList_IncorrectElementCount = "Cqt_ExpressionList_IncorrectElementCount";
        internal const string Cqt_Copier_EntityContainerNotFound = "Cqt_Copier_EntityContainerNotFound";
        internal const string Cqt_Copier_EntitySetNotFound = "Cqt_Copier_EntitySetNotFound";
        internal const string Cqt_Copier_FunctionNotFound = "Cqt_Copier_FunctionNotFound";
        internal const string Cqt_Copier_PropertyNotFound = "Cqt_Copier_PropertyNotFound";
        internal const string Cqt_Copier_NavPropertyNotFound = "Cqt_Copier_NavPropertyNotFound";
        internal const string Cqt_Copier_EndNotFound = "Cqt_Copier_EndNotFound";
        internal const string Cqt_Copier_TypeNotFound = "Cqt_Copier_TypeNotFound";
        internal const string Cqt_CommandTree_InvalidDataSpace = "Cqt_CommandTree_InvalidDataSpace";
        internal const string Cqt_CommandTree_InvalidParameterName = "Cqt_CommandTree_InvalidParameterName";
        internal const string Cqt_Validator_InvalidIncompatibleParameterReferences = "Cqt_Validator_InvalidIncompatibleParameterReferences";
        internal const string Cqt_Validator_InvalidOtherWorkspaceMetadata = "Cqt_Validator_InvalidOtherWorkspaceMetadata";
        internal const string Cqt_Validator_InvalidIncorrectDataSpaceMetadata = "Cqt_Validator_InvalidIncorrectDataSpaceMetadata";
        internal const string Cqt_Factory_NewCollectionInvalidCommonType = "Cqt_Factory_NewCollectionInvalidCommonType";
        internal const string Cqt_Factory_NoSuchProperty = "Cqt_Factory_NoSuchProperty";
        internal const string Cqt_Factory_NoSuchRelationEnd = "Cqt_Factory_NoSuchRelationEnd";
        internal const string Cqt_Factory_IncompatibleRelationEnds = "Cqt_Factory_IncompatibleRelationEnds";
        internal const string Cqt_Factory_MethodResultTypeNotSupported = "Cqt_Factory_MethodResultTypeNotSupported";
        internal const string Cqt_Aggregate_InvalidFunction = "Cqt_Aggregate_InvalidFunction";
        internal const string Cqt_Binding_CollectionRequired = "Cqt_Binding_CollectionRequired";
        internal const string Cqt_Binding_VariableNameNotValid = "Cqt_Binding_VariableNameNotValid";
        internal const string Cqt_GroupBinding_CollectionRequired = "Cqt_GroupBinding_CollectionRequired";
        internal const string Cqt_GroupBinding_GroupVariableNameNotValid = "Cqt_GroupBinding_GroupVariableNameNotValid";
        internal const string Cqt_Binary_CollectionsRequired = "Cqt_Binary_CollectionsRequired";
        internal const string Cqt_Unary_CollectionRequired = "Cqt_Unary_CollectionRequired";
        internal const string Cqt_And_BooleanArgumentsRequired = "Cqt_And_BooleanArgumentsRequired";
        internal const string Cqt_Apply_DuplicateVariableNames = "Cqt_Apply_DuplicateVariableNames";
        internal const string Cqt_Arithmetic_NumericCommonType = "Cqt_Arithmetic_NumericCommonType";
        internal const string Cqt_Arithmetic_InvalidUnsignedTypeForUnaryMinus = "Cqt_Arithmetic_InvalidUnsignedTypeForUnaryMinus";
        internal const string Cqt_Case_WhensMustEqualThens = "Cqt_Case_WhensMustEqualThens";
        internal const string Cqt_Case_InvalidResultType = "Cqt_Case_InvalidResultType";
        internal const string Cqt_Cast_InvalidCast = "Cqt_Cast_InvalidCast";
        internal const string Cqt_Comparison_ComparableRequired = "Cqt_Comparison_ComparableRequired";
        internal const string Cqt_Constant_InvalidType = "Cqt_Constant_InvalidType";
        internal const string Cqt_Constant_InvalidValueForType = "Cqt_Constant_InvalidValueForType";
        internal const string Cqt_Constant_InvalidConstantType = "Cqt_Constant_InvalidConstantType";
        internal const string Cqt_Constant_ClrEnumTypeDoesNotMatchEdmEnumType = "Cqt_Constant_ClrEnumTypeDoesNotMatchEdmEnumType";
        internal const string Cqt_Distinct_InvalidCollection = "Cqt_Distinct_InvalidCollection";
        internal const string Cqt_DeRef_RefRequired = "Cqt_DeRef_RefRequired";
        internal const string Cqt_Element_InvalidArgumentForUnwrapSingleProperty = "Cqt_Element_InvalidArgumentForUnwrapSingleProperty";
        internal const string Cqt_Function_VoidResultInvalid = "Cqt_Function_VoidResultInvalid";
        internal const string Cqt_Function_NonComposableInExpression = "Cqt_Function_NonComposableInExpression";
        internal const string Cqt_Function_CommandTextInExpression = "Cqt_Function_CommandTextInExpression";
        internal const string Cqt_Function_CanonicalFunction_NotFound = "Cqt_Function_CanonicalFunction_NotFound";
        internal const string Cqt_Function_CanonicalFunction_AmbiguousMatch = "Cqt_Function_CanonicalFunction_AmbiguousMatch";
        internal const string Cqt_GetEntityRef_EntityRequired = "Cqt_GetEntityRef_EntityRequired";
        internal const string Cqt_GetRefKey_RefRequired = "Cqt_GetRefKey_RefRequired";
        internal const string Cqt_GroupBy_AtLeastOneKeyOrAggregate = "Cqt_GroupBy_AtLeastOneKeyOrAggregate";
        internal const string Cqt_GroupBy_KeyNotEqualityComparable = "Cqt_GroupBy_KeyNotEqualityComparable";
        internal const string Cqt_GroupBy_AggregateColumnExistsAsGroupColumn = "Cqt_GroupBy_AggregateColumnExistsAsGroupColumn";
        internal const string Cqt_GroupBy_MoreThanOneGroupAggregate = "Cqt_GroupBy_MoreThanOneGroupAggregate";
        internal const string Cqt_CrossJoin_AtLeastTwoInputs = "Cqt_CrossJoin_AtLeastTwoInputs";
        internal const string Cqt_CrossJoin_DuplicateVariableNames = "Cqt_CrossJoin_DuplicateVariableNames";
        internal const string Cqt_IsNull_CollectionNotAllowed = "Cqt_IsNull_CollectionNotAllowed";
        internal const string Cqt_IsNull_InvalidType = "Cqt_IsNull_InvalidType";
        internal const string Cqt_InvalidTypeForSetOperation = "Cqt_InvalidTypeForSetOperation";
        internal const string Cqt_Join_DuplicateVariableNames = "Cqt_Join_DuplicateVariableNames";
        internal const string Cqt_Limit_ConstantOrParameterRefRequired = "Cqt_Limit_ConstantOrParameterRefRequired";
        internal const string Cqt_Limit_IntegerRequired = "Cqt_Limit_IntegerRequired";
        internal const string Cqt_Limit_NonNegativeLimitRequired = "Cqt_Limit_NonNegativeLimitRequired";
        internal const string Cqt_NewInstance_CollectionTypeRequired = "Cqt_NewInstance_CollectionTypeRequired";
        internal const string Cqt_NewInstance_StructuralTypeRequired = "Cqt_NewInstance_StructuralTypeRequired";
        internal const string Cqt_NewInstance_CannotInstantiateMemberlessType = "Cqt_NewInstance_CannotInstantiateMemberlessType";
        internal const string Cqt_NewInstance_CannotInstantiateAbstractType = "Cqt_NewInstance_CannotInstantiateAbstractType";

        internal const string Cqt_NewInstance_IncompatibleRelatedEntity_SourceTypeNotValid =
            "Cqt_NewInstance_IncompatibleRelatedEntity_SourceTypeNotValid";

        internal const string Cqt_Not_BooleanArgumentRequired = "Cqt_Not_BooleanArgumentRequired";
        internal const string Cqt_Or_BooleanArgumentsRequired = "Cqt_Or_BooleanArgumentsRequired";
        internal const string Cqt_Property_InstanceRequiredForInstance = "Cqt_Property_InstanceRequiredForInstance";
        internal const string Cqt_Ref_PolymorphicArgRequired = "Cqt_Ref_PolymorphicArgRequired";

        internal const string Cqt_RelatedEntityRef_TargetEndFromDifferentRelationship =
            "Cqt_RelatedEntityRef_TargetEndFromDifferentRelationship";

        internal const string Cqt_RelatedEntityRef_TargetEndMustBeAtMostOne = "Cqt_RelatedEntityRef_TargetEndMustBeAtMostOne";
        internal const string Cqt_RelatedEntityRef_TargetEndSameAsSourceEnd = "Cqt_RelatedEntityRef_TargetEndSameAsSourceEnd";
        internal const string Cqt_RelatedEntityRef_TargetEntityNotRef = "Cqt_RelatedEntityRef_TargetEntityNotRef";
        internal const string Cqt_RelatedEntityRef_TargetEntityNotCompatible = "Cqt_RelatedEntityRef_TargetEntityNotCompatible";
        internal const string Cqt_RelNav_NoCompositions = "Cqt_RelNav_NoCompositions";
        internal const string Cqt_RelNav_WrongSourceType = "Cqt_RelNav_WrongSourceType";
        internal const string Cqt_Skip_ConstantOrParameterRefRequired = "Cqt_Skip_ConstantOrParameterRefRequired";
        internal const string Cqt_Skip_IntegerRequired = "Cqt_Skip_IntegerRequired";
        internal const string Cqt_Skip_NonNegativeCountRequired = "Cqt_Skip_NonNegativeCountRequired";
        internal const string Cqt_Sort_EmptyCollationInvalid = "Cqt_Sort_EmptyCollationInvalid";
        internal const string Cqt_Sort_NonStringCollationInvalid = "Cqt_Sort_NonStringCollationInvalid";
        internal const string Cqt_Sort_OrderComparable = "Cqt_Sort_OrderComparable";
        internal const string Cqt_UDF_FunctionDefinitionGenerationFailed = "Cqt_UDF_FunctionDefinitionGenerationFailed";
        internal const string Cqt_UDF_FunctionDefinitionWithCircularReference = "Cqt_UDF_FunctionDefinitionWithCircularReference";
        internal const string Cqt_UDF_FunctionDefinitionResultTypeMismatch = "Cqt_UDF_FunctionDefinitionResultTypeMismatch";
        internal const string Cqt_UDF_FunctionHasNoDefinition = "Cqt_UDF_FunctionHasNoDefinition";
        internal const string Cqt_Validator_VarRefInvalid = "Cqt_Validator_VarRefInvalid";
        internal const string Cqt_Validator_VarRefTypeMismatch = "Cqt_Validator_VarRefTypeMismatch";
        internal const string Iqt_General_UnsupportedOp = "Iqt_General_UnsupportedOp";
        internal const string Iqt_CTGen_UnexpectedAggregate = "Iqt_CTGen_UnexpectedAggregate";
        internal const string Iqt_CTGen_UnexpectedVarDefList = "Iqt_CTGen_UnexpectedVarDefList";
        internal const string Iqt_CTGen_UnexpectedVarDef = "Iqt_CTGen_UnexpectedVarDef";
        internal const string ADP_MustUseSequentialAccess = "ADP_MustUseSequentialAccess";
        internal const string ADP_ProviderDoesNotSupportCommandTrees = "ADP_ProviderDoesNotSupportCommandTrees";
        internal const string ADP_ClosedDataReaderError = "ADP_ClosedDataReaderError";
        internal const string ADP_DataReaderClosed = "ADP_DataReaderClosed";
        internal const string ADP_ImplicitlyClosedDataReaderError = "ADP_ImplicitlyClosedDataReaderError";
        internal const string ADP_NoData = "ADP_NoData";
        internal const string ADP_GetSchemaTableIsNotSupported = "ADP_GetSchemaTableIsNotSupported";
        internal const string ADP_InvalidDataReaderFieldCountForScalarType = "ADP_InvalidDataReaderFieldCountForScalarType";
        internal const string ADP_InvalidDataReaderMissingColumnForType = "ADP_InvalidDataReaderMissingColumnForType";
        internal const string ADP_InvalidDataReaderMissingDiscriminatorColumn = "ADP_InvalidDataReaderMissingDiscriminatorColumn";
        internal const string ADP_InvalidDataReaderUnableToDetermineType = "ADP_InvalidDataReaderUnableToDetermineType";

        internal const string ADP_InvalidDataReaderUnableToMaterializeNonScalarType =
            "ADP_InvalidDataReaderUnableToMaterializeNonScalarType";

        internal const string ADP_KeysRequiredForJoinOverNest = "ADP_KeysRequiredForJoinOverNest";
        internal const string ADP_KeysRequiredForNesting = "ADP_KeysRequiredForNesting";
        internal const string ADP_NestingNotSupported = "ADP_NestingNotSupported";
        internal const string ADP_NoQueryMappingView = "ADP_NoQueryMappingView";
        internal const string ADP_InternalProviderError = "ADP_InternalProviderError";
        internal const string ADP_InvalidEnumerationValue = "ADP_InvalidEnumerationValue";
        internal const string ADP_InvalidBufferSizeOrIndex = "ADP_InvalidBufferSizeOrIndex";
        internal const string ADP_InvalidDataLength = "ADP_InvalidDataLength";
        internal const string ADP_InvalidDataType = "ADP_InvalidDataType";
        internal const string ADP_InvalidDestinationBufferIndex = "ADP_InvalidDestinationBufferIndex";
        internal const string ADP_InvalidSourceBufferIndex = "ADP_InvalidSourceBufferIndex";
        internal const string ADP_NonSequentialChunkAccess = "ADP_NonSequentialChunkAccess";
        internal const string ADP_NonSequentialColumnAccess = "ADP_NonSequentialColumnAccess";
        internal const string ADP_UnknownDataTypeCode = "ADP_UnknownDataTypeCode";
        internal const string DataCategory_Data = "DataCategory_Data";
        internal const string DbParameter_Direction = "DbParameter_Direction";
        internal const string DbParameter_Size = "DbParameter_Size";
        internal const string DataCategory_Update = "DataCategory_Update";
        internal const string DbParameter_SourceColumn = "DbParameter_SourceColumn";
        internal const string DbParameter_SourceVersion = "DbParameter_SourceVersion";
        internal const string ADP_CollectionParameterElementIsNull = "ADP_CollectionParameterElementIsNull";
        internal const string ADP_CollectionParameterElementIsNullOrEmpty = "ADP_CollectionParameterElementIsNullOrEmpty";
        internal const string EntityParameterCollectionInvalidParameterName = "EntityParameterCollectionInvalidParameterName";
        internal const string EntityParameterCollectionInvalidIndex = "EntityParameterCollectionInvalidIndex";
        internal const string InvalidEntityParameterType = "InvalidEntityParameterType";
        internal const string EntityParameterContainedByAnotherCollection = "EntityParameterContainedByAnotherCollection";
        internal const string EntityParameterNull = "EntityParameterNull";
        internal const string EntityParameterCollectionRemoveInvalidObject = "EntityParameterCollectionRemoveInvalidObject";
        internal const string ADP_ConnectionStringSyntax = "ADP_ConnectionStringSyntax";
        internal const string ExpandingDataDirectoryFailed = "ExpandingDataDirectoryFailed";
        internal const string ADP_InvalidDataDirectory = "ADP_InvalidDataDirectory";
        internal const string ADP_InvalidMultipartNameDelimiterUsage = "ADP_InvalidMultipartNameDelimiterUsage";
        internal const string ADP_InvalidSizeValue = "ADP_InvalidSizeValue";
        internal const string ADP_KeywordNotSupported = "ADP_KeywordNotSupported";
        internal const string ConstantFacetSpecifiedInSchema = "ConstantFacetSpecifiedInSchema";
        internal const string DuplicateAnnotation = "DuplicateAnnotation";
        internal const string EmptyFile = "EmptyFile";
        internal const string EmptySchemaTextReader = "EmptySchemaTextReader";
        internal const string EmptyName = "EmptyName";
        internal const string InvalidName = "InvalidName";
        internal const string MissingName = "MissingName";
        internal const string UnexpectedXmlAttribute = "UnexpectedXmlAttribute";
        internal const string UnexpectedXmlElement = "UnexpectedXmlElement";
        internal const string TextNotAllowed = "TextNotAllowed";
        internal const string UnexpectedXmlNodeType = "UnexpectedXmlNodeType";
        internal const string MalformedXml = "MalformedXml";
        internal const string ValueNotUnderstood = "ValueNotUnderstood";
        internal const string EntityContainerAlreadyExists = "EntityContainerAlreadyExists";
        internal const string TypeNameAlreadyDefinedDuplicate = "TypeNameAlreadyDefinedDuplicate";
        internal const string PropertyNameAlreadyDefinedDuplicate = "PropertyNameAlreadyDefinedDuplicate";
        internal const string DuplicateMemberNameInExtendedEntityContainer = "DuplicateMemberNameInExtendedEntityContainer";
        internal const string DuplicateEntityContainerMemberName = "DuplicateEntityContainerMemberName";
        internal const string PropertyTypeAlreadyDefined = "PropertyTypeAlreadyDefined";
        internal const string InvalidSize = "InvalidSize";
        internal const string InvalidSystemReferenceId = "InvalidSystemReferenceId";
        internal const string BadNamespaceOrAlias = "BadNamespaceOrAlias";
        internal const string MissingNamespaceAttribute = "MissingNamespaceAttribute";
        internal const string InvalidBaseTypeForStructuredType = "InvalidBaseTypeForStructuredType";
        internal const string InvalidPropertyType = "InvalidPropertyType";
        internal const string InvalidBaseTypeForItemType = "InvalidBaseTypeForItemType";
        internal const string InvalidBaseTypeForNestedType = "InvalidBaseTypeForNestedType";
        internal const string DefaultNotAllowed = "DefaultNotAllowed";
        internal const string FacetNotAllowed = "FacetNotAllowed";
        internal const string RequiredFacetMissing = "RequiredFacetMissing";
        internal const string InvalidDefaultBinaryWithNoMaxLength = "InvalidDefaultBinaryWithNoMaxLength";
        internal const string InvalidDefaultIntegral = "InvalidDefaultIntegral";
        internal const string InvalidDefaultDateTime = "InvalidDefaultDateTime";
        internal const string InvalidDefaultTime = "InvalidDefaultTime";
        internal const string InvalidDefaultDateTimeOffset = "InvalidDefaultDateTimeOffset";
        internal const string InvalidDefaultDecimal = "InvalidDefaultDecimal";
        internal const string InvalidDefaultFloatingPoint = "InvalidDefaultFloatingPoint";
        internal const string InvalidDefaultGuid = "InvalidDefaultGuid";
        internal const string InvalidDefaultBoolean = "InvalidDefaultBoolean";
        internal const string DuplicateMemberName = "DuplicateMemberName";
        internal const string GeneratorErrorSeverityError = "GeneratorErrorSeverityError";
        internal const string GeneratorErrorSeverityWarning = "GeneratorErrorSeverityWarning";
        internal const string GeneratorErrorSeverityUnknown = "GeneratorErrorSeverityUnknown";
        internal const string SourceUriUnknown = "SourceUriUnknown";
        internal const string BadPrecisionAndScale = "BadPrecisionAndScale";
        internal const string InvalidNamespaceInUsing = "InvalidNamespaceInUsing";
        internal const string BadNavigationPropertyRelationshipNotRelationship = "BadNavigationPropertyRelationshipNotRelationship";
        internal const string BadNavigationPropertyRolesCannotBeTheSame = "BadNavigationPropertyRolesCannotBeTheSame";
        internal const string BadNavigationPropertyUndefinedRole = "BadNavigationPropertyUndefinedRole";
        internal const string BadNavigationPropertyBadFromRoleType = "BadNavigationPropertyBadFromRoleType";
        internal const string InvalidMemberNameMatchesTypeName = "InvalidMemberNameMatchesTypeName";
        internal const string InvalidKeyKeyDefinedInBaseClass = "InvalidKeyKeyDefinedInBaseClass";
        internal const string InvalidKeyNullablePart = "InvalidKeyNullablePart";
        internal const string InvalidKeyNoProperty = "InvalidKeyNoProperty";
        internal const string KeyMissingOnEntityType = "KeyMissingOnEntityType";
        internal const string InvalidDocumentationBothTextAndStructure = "InvalidDocumentationBothTextAndStructure";
        internal const string ArgumentOutOfRangeExpectedPostiveNumber = "ArgumentOutOfRangeExpectedPostiveNumber";
        internal const string ArgumentOutOfRange = "ArgumentOutOfRange";
        internal const string UnacceptableUri = "UnacceptableUri";
        internal const string UnexpectedTypeInCollection = "UnexpectedTypeInCollection";
        internal const string AllElementsMustBeInSchema = "AllElementsMustBeInSchema";
        internal const string AliasNameIsAlreadyDefined = "AliasNameIsAlreadyDefined";
        internal const string NeedNotUseSystemNamespaceInUsing = "NeedNotUseSystemNamespaceInUsing";
        internal const string CannotUseSystemNamespaceAsAlias = "CannotUseSystemNamespaceAsAlias";
        internal const string EntitySetTypeHasNoKeys = "EntitySetTypeHasNoKeys";
        internal const string TableAndSchemaAreMutuallyExclusiveWithDefiningQuery = "TableAndSchemaAreMutuallyExclusiveWithDefiningQuery";
        internal const string UnexpectedRootElement = "UnexpectedRootElement";
        internal const string UnexpectedRootElementNoNamespace = "UnexpectedRootElementNoNamespace";
        internal const string ParameterNameAlreadyDefinedDuplicate = "ParameterNameAlreadyDefinedDuplicate";
        internal const string FunctionWithNonPrimitiveTypeNotSupported = "FunctionWithNonPrimitiveTypeNotSupported";
        internal const string FunctionWithNonEdmPrimitiveTypeNotSupported = "FunctionWithNonEdmPrimitiveTypeNotSupported";
        internal const string FunctionImportWithUnsupportedReturnTypeV1 = "FunctionImportWithUnsupportedReturnTypeV1";
        internal const string FunctionImportWithUnsupportedReturnTypeV1_1 = "FunctionImportWithUnsupportedReturnTypeV1_1";
        internal const string FunctionImportWithUnsupportedReturnTypeV2 = "FunctionImportWithUnsupportedReturnTypeV2";
        internal const string FunctionImportUnknownEntitySet = "FunctionImportUnknownEntitySet";

        internal const string FunctionImportReturnEntitiesButDoesNotSpecifyEntitySet =
            "FunctionImportReturnEntitiesButDoesNotSpecifyEntitySet";

        internal const string FunctionImportEntityTypeDoesNotMatchEntitySet = "FunctionImportEntityTypeDoesNotMatchEntitySet";
        internal const string FunctionImportSpecifiesEntitySetButNotEntityType = "FunctionImportSpecifiesEntitySetButNotEntityType";
        internal const string FunctionImportEntitySetAndEntitySetPathDeclared = "FunctionImportEntitySetAndEntitySetPathDeclared";
        internal const string FunctionImportComposableAndSideEffectingNotAllowed = "FunctionImportComposableAndSideEffectingNotAllowed";
        internal const string FunctionImportCollectionAndRefParametersNotAllowed = "FunctionImportCollectionAndRefParametersNotAllowed";
        internal const string FunctionImportNonNullableParametersNotAllowed = "FunctionImportNonNullableParametersNotAllowed";
        internal const string TVFReturnTypeRowHasNonScalarProperty = "TVFReturnTypeRowHasNonScalarProperty";
        internal const string DuplicateEntitySetTable = "DuplicateEntitySetTable";
        internal const string ConcurrencyRedefinedOnSubTypeOfEntitySetType = "ConcurrencyRedefinedOnSubTypeOfEntitySetType";
        internal const string SimilarRelationshipEnd = "SimilarRelationshipEnd";
        internal const string InvalidRelationshipEndMultiplicity = "InvalidRelationshipEndMultiplicity";
        internal const string EndNameAlreadyDefinedDuplicate = "EndNameAlreadyDefinedDuplicate";
        internal const string InvalidRelationshipEndType = "InvalidRelationshipEndType";
        internal const string BadParameterDirection = "BadParameterDirection";
        internal const string BadParameterDirectionForComposableFunctions = "BadParameterDirectionForComposableFunctions";
        internal const string InvalidOperationMultipleEndsInAssociation = "InvalidOperationMultipleEndsInAssociation";
        internal const string InvalidAction = "InvalidAction";
        internal const string DuplicationOperation = "DuplicationOperation";
        internal const string NotInNamespaceAlias = "NotInNamespaceAlias";
        internal const string NotNamespaceQualified = "NotNamespaceQualified";
        internal const string NotInNamespaceNoAlias = "NotInNamespaceNoAlias";
        internal const string InvalidValueForParameterTypeSemanticsAttribute = "InvalidValueForParameterTypeSemanticsAttribute";
        internal const string DuplicatePropertyNameSpecifiedInEntityKey = "DuplicatePropertyNameSpecifiedInEntityKey";
        internal const string InvalidEntitySetType = "InvalidEntitySetType";
        internal const string InvalidRelationshipSetType = "InvalidRelationshipSetType";
        internal const string InvalidEntityContainerNameInExtends = "InvalidEntityContainerNameInExtends";
        internal const string InvalidNamespaceOrAliasSpecified = "InvalidNamespaceOrAliasSpecified";
        internal const string InvalidPrecisionAndScaleSpecified = "InvalidPrecisionAndScaleSpecified";
        internal const string PrecisionOutOfRange = "PrecisionOutOfRange";
        internal const string ScaleOutOfRange = "ScaleOutOfRange";
        internal const string InvalidEntitySetNameReference = "InvalidEntitySetNameReference";
        internal const string InvalidEntityEndName = "InvalidEntityEndName";
        internal const string DuplicateEndName = "DuplicateEndName";
        internal const string AmbiguousEntityContainerEnd = "AmbiguousEntityContainerEnd";
        internal const string MissingEntityContainerEnd = "MissingEntityContainerEnd";
        internal const string InvalidEndEntitySetTypeMismatch = "InvalidEndEntitySetTypeMismatch";
        internal const string InferRelationshipEndFailedNoEntitySetMatch = "InferRelationshipEndFailedNoEntitySetMatch";
        internal const string InferRelationshipEndAmbiguous = "InferRelationshipEndAmbiguous";
        internal const string InferRelationshipEndGivesAlreadyDefinedEnd = "InferRelationshipEndGivesAlreadyDefinedEnd";
        internal const string TooManyAssociationEnds = "TooManyAssociationEnds";
        internal const string InvalidEndRoleInRelationshipConstraint = "InvalidEndRoleInRelationshipConstraint";
        internal const string InvalidFromPropertyInRelationshipConstraint = "InvalidFromPropertyInRelationshipConstraint";
        internal const string InvalidToPropertyInRelationshipConstraint = "InvalidToPropertyInRelationshipConstraint";
        internal const string InvalidPropertyInRelationshipConstraint = "InvalidPropertyInRelationshipConstraint";
        internal const string TypeMismatchRelationshipConstaint = "TypeMismatchRelationshipConstaint";
        internal const string InvalidMultiplicityFromRoleUpperBoundMustBeOne = "InvalidMultiplicityFromRoleUpperBoundMustBeOne";
        internal const string InvalidMultiplicityFromRoleToPropertyNonNullableV1 = "InvalidMultiplicityFromRoleToPropertyNonNullableV1";
        internal const string InvalidMultiplicityFromRoleToPropertyNonNullableV2 = "InvalidMultiplicityFromRoleToPropertyNonNullableV2";
        internal const string InvalidMultiplicityFromRoleToPropertyNullableV1 = "InvalidMultiplicityFromRoleToPropertyNullableV1";
        internal const string InvalidMultiplicityToRoleLowerBoundMustBeZero = "InvalidMultiplicityToRoleLowerBoundMustBeZero";
        internal const string InvalidMultiplicityToRoleUpperBoundMustBeOne = "InvalidMultiplicityToRoleUpperBoundMustBeOne";
        internal const string InvalidMultiplicityToRoleUpperBoundMustBeMany = "InvalidMultiplicityToRoleUpperBoundMustBeMany";
        internal const string MismatchNumberOfPropertiesinRelationshipConstraint = "MismatchNumberOfPropertiesinRelationshipConstraint";
        internal const string MissingConstraintOnRelationshipType = "MissingConstraintOnRelationshipType";
        internal const string SameRoleReferredInReferentialConstraint = "SameRoleReferredInReferentialConstraint";
        internal const string InvalidPrimitiveTypeKind = "InvalidPrimitiveTypeKind";
        internal const string EntityKeyMustBeScalar = "EntityKeyMustBeScalar";
        internal const string EntityKeyTypeCurrentlyNotSupportedInSSDL = "EntityKeyTypeCurrentlyNotSupportedInSSDL";
        internal const string EntityKeyTypeCurrentlyNotSupported = "EntityKeyTypeCurrentlyNotSupported";
        internal const string MissingFacetDescription = "MissingFacetDescription";
        internal const string EndWithManyMultiplicityCannotHaveOperationsSpecified = "EndWithManyMultiplicityCannotHaveOperationsSpecified";
        internal const string EndWithoutMultiplicity = "EndWithoutMultiplicity";
        internal const string EntityContainerCannotExtendItself = "EntityContainerCannotExtendItself";

        internal const string ComposableFunctionOrFunctionImportMustDeclareReturnType =
            "ComposableFunctionOrFunctionImportMustDeclareReturnType";

        internal const string NonComposableFunctionMustNotDeclareReturnType = "NonComposableFunctionMustNotDeclareReturnType";
        internal const string CommandTextFunctionsNotComposable = "CommandTextFunctionsNotComposable";
        internal const string CommandTextFunctionsCannotDeclareStoreFunctionName = "CommandTextFunctionsCannotDeclareStoreFunctionName";
        internal const string NonComposableFunctionHasDisallowedAttribute = "NonComposableFunctionHasDisallowedAttribute";
        internal const string EmptyDefiningQuery = "EmptyDefiningQuery";
        internal const string EmptyCommandText = "EmptyCommandText";
        internal const string AmbiguousFunctionOverload = "AmbiguousFunctionOverload";
        internal const string AmbiguousFunctionAndType = "AmbiguousFunctionAndType";
        internal const string CycleInTypeHierarchy = "CycleInTypeHierarchy";
        internal const string IncorrectProviderManifest = "IncorrectProviderManifest";
        internal const string ComplexTypeAsReturnTypeAndDefinedEntitySet = "ComplexTypeAsReturnTypeAndDefinedEntitySet";
        internal const string ComplexTypeAsReturnTypeAndNestedComplexProperty = "ComplexTypeAsReturnTypeAndNestedComplexProperty";
        internal const string FacetsOnNonScalarType = "FacetsOnNonScalarType";
        internal const string FacetDeclarationRequiresTypeAttribute = "FacetDeclarationRequiresTypeAttribute";
        internal const string TypeMustBeDeclared = "TypeMustBeDeclared";
        internal const string RowTypeWithoutProperty = "RowTypeWithoutProperty";
        internal const string TypeDeclaredAsAttributeAndElement = "TypeDeclaredAsAttributeAndElement";
        internal const string ReferenceToNonEntityType = "ReferenceToNonEntityType";
        internal const string NoCodeGenNamespaceInStructuralAnnotation = "NoCodeGenNamespaceInStructuralAnnotation";

        internal const string CannotLoadDifferentVersionOfSchemaInTheSameItemCollection =
            "CannotLoadDifferentVersionOfSchemaInTheSameItemCollection";

        internal const string InvalidEnumUnderlyingType = "InvalidEnumUnderlyingType";
        internal const string DuplicateEnumMember = "DuplicateEnumMember";
        internal const string CalculatedEnumValueOutOfRange = "CalculatedEnumValueOutOfRange";
        internal const string EnumMemberValueOutOfItsUnderylingTypeRange = "EnumMemberValueOutOfItsUnderylingTypeRange";
        internal const string SpatialWithUseStrongSpatialTypesFalse = "SpatialWithUseStrongSpatialTypesFalse";
        internal const string ObjectQuery_QueryBuilder_InvalidProjectionList = "ObjectQuery_QueryBuilder_InvalidProjectionList";
        internal const string ObjectQuery_QueryBuilder_InvalidSortKeyList = "ObjectQuery_QueryBuilder_InvalidSortKeyList";
        internal const string ObjectQuery_QueryBuilder_InvalidGroupKeyList = "ObjectQuery_QueryBuilder_InvalidGroupKeyList";
        internal const string ObjectQuery_QueryBuilder_InvalidSkipCount = "ObjectQuery_QueryBuilder_InvalidSkipCount";
        internal const string ObjectQuery_QueryBuilder_InvalidTopCount = "ObjectQuery_QueryBuilder_InvalidTopCount";
        internal const string ObjectQuery_QueryBuilder_InvalidFilterPredicate = "ObjectQuery_QueryBuilder_InvalidFilterPredicate";
        internal const string ObjectQuery_QueryBuilder_InvalidResultType = "ObjectQuery_QueryBuilder_InvalidResultType";
        internal const string ObjectQuery_QueryBuilder_InvalidQueryArgument = "ObjectQuery_QueryBuilder_InvalidQueryArgument";
        internal const string ObjectQuery_QueryBuilder_NotSupportedLinqSource = "ObjectQuery_QueryBuilder_NotSupportedLinqSource";
        internal const string ObjectQuery_InvalidEmptyQuery = "ObjectQuery_InvalidEmptyQuery";
        internal const string ObjectQuery_InvalidConnection = "ObjectQuery_InvalidConnection";
        internal const string ObjectQuery_InvalidQueryName = "ObjectQuery_InvalidQueryName";
        internal const string ObjectQuery_UnableToMapResultType = "ObjectQuery_UnableToMapResultType";
        internal const string ObjectQuery_UnableToMaterializeArray = "ObjectQuery_UnableToMaterializeArray";

        internal const string ObjectQuery_UnableToMaterializeArbitaryProjectionType =
            "ObjectQuery_UnableToMaterializeArbitaryProjectionType";

        internal const string ObjectParameter_InvalidParameterName = "ObjectParameter_InvalidParameterName";
        internal const string ObjectParameter_InvalidParameterType = "ObjectParameter_InvalidParameterType";
        internal const string ObjectParameterCollection_ParameterNameNotFound = "ObjectParameterCollection_ParameterNameNotFound";
        internal const string ObjectParameterCollection_ParameterAlreadyExists = "ObjectParameterCollection_ParameterAlreadyExists";
        internal const string ObjectParameterCollection_DuplicateParameterName = "ObjectParameterCollection_DuplicateParameterName";
        internal const string ObjectParameterCollection_ParametersLocked = "ObjectParameterCollection_ParametersLocked";
        internal const string ProviderReturnedNullForGetDbInformation = "ProviderReturnedNullForGetDbInformation";
        internal const string ProviderReturnedNullForCreateCommandDefinition = "ProviderReturnedNullForCreateCommandDefinition";
        internal const string ProviderDidNotReturnAProviderManifest = "ProviderDidNotReturnAProviderManifest";
        internal const string ProviderDidNotReturnAProviderManifestToken = "ProviderDidNotReturnAProviderManifestToken";
        internal const string ProviderDidNotReturnSpatialServices = "ProviderDidNotReturnSpatialServices";
        internal const string ProviderRequiresStoreCommandTree = "ProviderRequiresStoreCommandTree";
        internal const string ProviderShouldOverrideEscapeLikeArgument = "ProviderShouldOverrideEscapeLikeArgument";
        internal const string ProviderEscapeLikeArgumentReturnedNull = "ProviderEscapeLikeArgumentReturnedNull";
        internal const string ProviderDidNotCreateACommandDefinition = "ProviderDidNotCreateACommandDefinition";
        internal const string ProviderDoesNotSupportCreateDatabaseScript = "ProviderDoesNotSupportCreateDatabaseScript";
        internal const string ProviderDoesNotSupportCreateDatabase = "ProviderDoesNotSupportCreateDatabase";
        internal const string ProviderDoesNotSupportDatabaseExists = "ProviderDoesNotSupportDatabaseExists";
        internal const string ProviderDoesNotSupportDeleteDatabase = "ProviderDoesNotSupportDeleteDatabase";

        internal const string Spatial_GeographyValueNotCompatibleWithSpatialServices =
            "Spatial_GeographyValueNotCompatibleWithSpatialServices";

        internal const string Spatial_GeometryValueNotCompatibleWithSpatialServices =
            "Spatial_GeometryValueNotCompatibleWithSpatialServices";

        internal const string Spatial_ProviderValueNotCompatibleWithSpatialServices =
            "Spatial_ProviderValueNotCompatibleWithSpatialServices";

        internal const string Spatial_WellKnownValueSerializationPropertyNotDirectlySettable =
            "Spatial_WellKnownValueSerializationPropertyNotDirectlySettable";

        internal const string EntityConnectionString_Name = "EntityConnectionString_Name";
        internal const string EntityConnectionString_Provider = "EntityConnectionString_Provider";
        internal const string EntityConnectionString_Metadata = "EntityConnectionString_Metadata";
        internal const string EntityConnectionString_ProviderConnectionString = "EntityConnectionString_ProviderConnectionString";
        internal const string EntityDataCategory_Context = "EntityDataCategory_Context";
        internal const string EntityDataCategory_NamedConnectionString = "EntityDataCategory_NamedConnectionString";
        internal const string EntityDataCategory_Source = "EntityDataCategory_Source";

        internal const string ObjectQuery_Span_IncludeRequiresEntityOrEntityCollection =
            "ObjectQuery_Span_IncludeRequiresEntityOrEntityCollection";

        internal const string ObjectQuery_Span_NoNavProp = "ObjectQuery_Span_NoNavProp";
        internal const string ObjectQuery_Span_SpanPathSyntaxError = "ObjectQuery_Span_SpanPathSyntaxError";
        internal const string ObjectQuery_Span_WhiteSpacePath = "ObjectQuery_Span_WhiteSpacePath";
        internal const string EntityProxyTypeInfo_ProxyHasWrongWrapper = "EntityProxyTypeInfo_ProxyHasWrongWrapper";

        internal const string EntityProxyTypeInfo_CannotSetEntityCollectionProperty =
            "EntityProxyTypeInfo_CannotSetEntityCollectionProperty";

        internal const string EntityProxyTypeInfo_ProxyMetadataIsUnavailable = "EntityProxyTypeInfo_ProxyMetadataIsUnavailable";
        internal const string EntityProxyTypeInfo_DuplicateOSpaceType = "EntityProxyTypeInfo_DuplicateOSpaceType";
        internal const string InvalidEdmMemberInstance = "InvalidEdmMemberInstance";
        internal const string EF6Providers_NoProviderFound = "EF6Providers_NoProviderFound";
        internal const string EF6Providers_ProviderTypeMissing = "EF6Providers_ProviderTypeMissing";
        internal const string EF6Providers_InstanceMissing = "EF6Providers_InstanceMissing";
        internal const string EF6Providers_NotDbProviderServices = "EF6Providers_NotDbProviderServices";
        internal const string ProviderInvariantRepeatedInConfig = "ProviderInvariantRepeatedInConfig";
        internal const string ProviderInvariantNotPassedToResolver = "ProviderInvariantNotPassedToResolver";
        internal const string DefaultConfigurationUsedBeforeSet = "DefaultConfigurationUsedBeforeSet";
        internal const string ConfigurationSetTwice = "ConfigurationSetTwice";
        internal const string ConfigurationNotDiscovered = "ConfigurationNotDiscovered";
        internal const string SetConfigurationNotDiscovered = "SetConfigurationNotDiscovered";
        internal const string MultipleConfigsInAssembly = "MultipleConfigsInAssembly";
        internal const string CreateInstance_BadMigrationsConfigurationType = "CreateInstance_BadMigrationsConfigurationType";
        internal const string CreateInstance_BadSqlGeneratorType = "CreateInstance_BadSqlGeneratorType";
        internal const string CreateInstance_NoParameterlessConstructor = "CreateInstance_NoParameterlessConstructor";
        internal const string CreateInstance_AbstractType = "CreateInstance_AbstractType";
        internal const string CreateInstance_GenericType = "CreateInstance_GenericType";
        internal const string SqlGeneratorTypeMissing = "SqlGeneratorTypeMissing";
        internal const string ConfigurationLocked = "ConfigurationLocked";
        internal const string EnableMigrationsForContext = "EnableMigrationsForContext";
        internal const string EnableMigrations_MultipleContexts = "EnableMigrations_MultipleContexts";
        internal const string EnableMigrations_MultipleContextsWithName = "EnableMigrations_MultipleContextsWithName";
        internal const string EnableMigrations_NoContext = "EnableMigrations_NoContext";
        internal const string EnableMigrations_NoContextWithName = "EnableMigrations_NoContextWithName";
        internal const string MoreThanOneElement = "MoreThanOneElement";
        internal const string IQueryable_Not_Async = "IQueryable_Not_Async";
        internal const string IQueryable_Provider_Not_Async = "IQueryable_Provider_Not_Async";
        internal const string EmptySequence = "EmptySequence";
        internal const string UnableToAutoMigrateDefaultSchema = "UnableToAutoMigrateDefaultSchema";

        private static EntityRes loader;
        private readonly ResourceManager resources;

        private EntityRes()
        {
            resources = new ResourceManager("System.Data.Entity.Properties.Resources", typeof(DbContext).Assembly);
        }

        private static EntityRes GetLoader()
        {
            if (loader == null)
            {
                var sr = new EntityRes();
                Interlocked.CompareExchange(ref loader, sr, null);
            }
            return loader;
        }

        private static CultureInfo Culture
        {
            get { return null /*use ResourceManager default, CultureInfo.CurrentUICulture*/; }
        }

        public static ResourceManager Resources
        {
            get { return GetLoader().resources; }
        }

        public static string GetString(string name, params object[] args)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            var res = sys.resources.GetString(name, Culture);

            if (args != null
                && args.Length > 0)
            {
                for (var i = 0; i < args.Length; i ++)
                {
                    var value = args[i] as String;
                    if (value != null
                        && value.Length > 1024)
                    {
                        args[i] = value.Substring(0, 1024 - 3) + "...";
                    }
                }
                return String.Format(CultureInfo.CurrentCulture, res, args);
            }
            else
            {
                return res;
            }
        }

        public static string GetString(string name)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            return sys.resources.GetString(name, Culture);
        }

        public static string GetString(string name, out bool usedFallback)
        {
            // always false for this version of gensr
            usedFallback = false;
            return GetString(name);
        }

        public static object GetObject(string name)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            return sys.resources.GetObject(name, Culture);
        }
    }
}
