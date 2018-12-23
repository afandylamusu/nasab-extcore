using System;
using ExtCore.Data.Abstractions;

namespace Contacts.ViewModels.Contacts
{
    internal class IndexViewModelFactory
    {
        internal IndexViewModel Create(IStorage storage)
        {
            return new IndexViewModel { };
        }
    }
}
