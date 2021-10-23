using System.Collections.Generic;
using Productivo.Core.Entities;

namespace Productivo.Core.ViewModels.Imports
{
    public class ImportDetailViewModel
    {
        public ImportEntity imports { get; set; }
        public List<ImportDetailEntity> importsDetails { get; set; }
        public List<ImportFileEntity> importFiles { get; set; }
        public List<ContainerEntity> containers { get; set; }

    }
}
