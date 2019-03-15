﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Maps { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Multi-layers",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/Multilayer",
                FileName = "Multilayer.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Marker",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/marker",
                FileName = "marker.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/Tooltip",
                FileName = "Tooltip.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "OpenStreetMap",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/OpenStreetMap",
                FileName = "OpenStreetMap.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Projection",
                Category = "Maps",
                Directory = "Maps/Maps",
                Url = "Maps/Projection",
                FileName = "Projection.cshtml",
                Type = SampleType.New
            }
             

        };      
    }

   


}
