using PhotoGallery2.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace PhotoGallery2
{
    public  interface IPhotoImporter
    {

        Task<ObservableCollection<Photo>> Get(
            int start
            , int count
            , Quality quality = Quality.Low
        );

        Task<ObservableCollection<Photo>> Get(
            List<string> filenames
            , Quality quality = Quality.Low
        );
    }

    public enum Quality
    {
        Low,
        High
    }
}
