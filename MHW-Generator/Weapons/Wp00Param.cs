﻿using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class Wp00Param : IMultiStruct {
        public MultiStruct Generate() { // .w00p
            var paramIndex = 0;
            var i          = 0;

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W00p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Weapon", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Unk Arr 1", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 20),

                new MhwMultiStructData.StructData($"W00p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Unk Arr 2", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(int)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 9),

                new MhwMultiStructData.StructData("Unk Arr 3", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 5),

                new MhwMultiStructData.StructData($"W00p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Unk Arr 4", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(ushort)),
                }, 4),

                new MhwMultiStructData.StructData("Unk Arr 5", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 13),

                new MhwMultiStructData.StructData($"W00p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Unk Arr 6", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 8),

                new MhwMultiStructData.StructData($"W00p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float)),
                }, 1, showVertically: true),
            };

            return new MultiStruct("MHW_Editor.Weapons", "Wp00Param", new MhwMultiStructData(structs, "w00p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w00p"]));
        }
    }
}