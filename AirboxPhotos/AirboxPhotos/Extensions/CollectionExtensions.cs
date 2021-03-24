using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AirboxPhotos.Extensions
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Changes IEnumerable to an ObservableCollection
        /// </summary>
        /// <typeparam name="T">The type of items in the enumerable</typeparam>
        /// <param name="enumerableList">The list of times wanting to be changed to an ObservableCollection</param>
        /// <returns>An ObservableCollection of type T</returns>s
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerableList)
        {
            if (enumerableList != null)
            {
                //create an emtpy observable collection object
                var observableCollection = new ObservableCollection<T>();

                //loop through all the records and add to observable collection object
                foreach (var item in enumerableList)
                    observableCollection.Add(item);

                //return the populated observable collection
                return observableCollection;
            }

            return null;
        }
    }
}
