﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Structs.Items {
    public partial class SafiItemLottery : MhwMultiStructItem<SafiItemLottery>, IShowAsSingleStruct<SafiItemLottery.Entries> {
        public partial class Entries : IHasWeaponType {
            public WeaponType GetWeaponType() {
                return Weapon_Type;
            }
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}