﻿using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class KulveGradeLottery : ISingleStruct {
        public SingleStruct Generate() { // .em117glt
            return new SingleStruct("MHW_Editor.Items", "KulveGradeLottery", new MhwStructData {
                size             = 28,
                offsetInitial    = 6,
                entryCountOffset = 2,
                uniqueIdFormula  = "{Item_Id}",
                autoOffset       = true,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", typeof(uint), true),
                    new MhwStructData.Entry("Item Id", typeof(uint), true, dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Grade 1", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 2", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 3", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 4", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 5", typeof(uint), createPercentField: true)
                }
            });
        }
    }
}