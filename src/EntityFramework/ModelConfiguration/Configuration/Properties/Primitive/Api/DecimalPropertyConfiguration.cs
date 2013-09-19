// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.ModelConfiguration.Configuration
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Used to configure a <see cref="T:System.decimal" /> property of an entity type or complex type.
    /// This configuration functionality is available via the Code First Fluent API, see <see cref="DbModelBuilder" />.
    /// </summary>
    public class DecimalPropertyConfiguration : PrimitivePropertyConfiguration
    {
        internal DecimalPropertyConfiguration(Properties.Primitive.DecimalPropertyConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// Configures the property to be optional.
        /// The database column used to store this property will be nullable.
        /// </summary>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration IsOptional()
        {
            base.IsOptional();

            return this;
        }

        /// <summary>
        /// Configures the property to be required.
        /// The database column used to store this property will be non-nullable.
        /// <see cref="T:System.decimal" /> properties are required by default.
        /// </summary>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration IsRequired()
        {
            base.IsRequired();

            return this;
        }

        /// <summary>
        /// Configures how values for the property are generated by the database.
        /// </summary>
        /// <param name="databaseGeneratedOption"> The pattern used to generate values for the property in the database. Setting 'null' will remove the database generated pattern facet from the property. Setting 'null' will cause the same runtime behavior as specifying 'None'. </param>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration HasDatabaseGeneratedOption(
            DatabaseGeneratedOption? databaseGeneratedOption)
        {
            base.HasDatabaseGeneratedOption(databaseGeneratedOption);

            return this;
        }

        /// <summary>
        /// Configures the property to be used as an optimistic concurrency token.
        /// </summary>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration IsConcurrencyToken()
        {
            base.IsConcurrencyToken();

            return this;
        }

        /// <summary>
        /// Configures whether or not the property is to be used as an optimistic concurrency token.
        /// </summary>
        /// <param name="concurrencyToken"> Value indicating if the property is a concurrency token or not. Specifying 'null' will remove the concurrency token facet from the property. Specifying 'null' will cause the same runtime behavior as specifying 'false'. </param>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
        {
            base.IsConcurrencyToken(concurrencyToken);

            return this;
        }

        /// <summary>
        /// Configures the name of the database column used to store the property.
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration HasColumnName(string columnName)
        {
            base.HasColumnName(columnName);

            return this;
        }

        /// <summary>
        /// Configures the data type of the database column used to store the property.
        /// </summary>
        /// <param name="columnType"> Name of the database provider specific data type. </param>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration HasColumnType(string columnType)
        {
            base.HasColumnType(columnType);

            return this;
        }

        /// <summary>
        /// Configures the order of the database column used to store the property.
        /// This method is also used to specify key ordering when an entity type has a composite key.
        /// </summary>
        /// <param name="columnOrder"> The order that this column should appear in the database table. </param>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public new DecimalPropertyConfiguration HasColumnOrder(int? columnOrder)
        {
            base.HasColumnOrder(columnOrder);

            return this;
        }

        /// <summary>
        /// Configures the precision and scale of the property.
        /// </summary>
        /// <param name="precision"> The precision of the property. </param>
        /// <param name="scale"> The scale of the property. </param>
        /// <returns> The same DecimalPropertyConfiguration instance so that multiple calls can be chained. </returns>
        public DecimalPropertyConfiguration HasPrecision(byte precision, byte scale)
        {
            Configuration.Precision = precision;
            Configuration.Scale = scale;

            return this;
        }

        internal new Properties.Primitive.DecimalPropertyConfiguration Configuration
        {
            get { return (Properties.Primitive.DecimalPropertyConfiguration)base.Configuration; }
        }
    }
}
