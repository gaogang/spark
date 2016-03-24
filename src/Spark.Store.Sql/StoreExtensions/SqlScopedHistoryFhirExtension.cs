using System;
using Hl7.Fhir.Model;
using Spark.Engine.Core;
using Spark.Engine.Interfaces;

namespace Spark.Store.Sql.StoreExtensions
{
    internal class SqlScopedHistoryFhirExtension : IScopedFhirExtension, IHistoryExtension
    {
        public IScope Scope { get; set; }

        public Bundle History(HistoryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Bundle History(IKey key, HistoryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Bundle History(string typename, HistoryParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnEntryAdded(Entry entry)
        {
        }

        public void OnExtensionAdded(IFhirStore extensibleObject)
        {
        }
    }
}