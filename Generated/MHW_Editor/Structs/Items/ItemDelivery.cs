using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Items {
    public partial class ItemDelivery {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual uint Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected ushort Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 150;
            [SortOrder(Entry_Count_sortIndex)]
            [DisplayName(Entry_Count_displayName)]
            [IsReadOnly]
            public virtual uint Entry_Count {
                get => Entry_Count_raw;
                set {
                    if (Entry_Count_raw == value) return;
                    Entry_Count_raw = value;
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Header>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Header LoadData(BinaryReader reader, ulong i) {
                var data = new Header();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt16();
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => "{Id}";

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected uint Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 100;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual uint Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected uint Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 150;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual uint Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected int Client_Id_raw;
            public const string Client_Id_displayName = "Client Id";
            public const int Client_Id_sortIndex = 200;
            [SortOrder(Client_Id_sortIndex)]
            [DisplayName(Client_Id_displayName)]
            public virtual int Client_Id {
                get => Client_Id_raw;
                set {
                    if (Client_Id_raw == value) return;
                    Client_Id_raw = value;
                    OnPropertyChanged(nameof(Client_Id));
                }
            }

            protected uint Decoration_Reward_raw;
            public const string Decoration_Reward_displayName = "Decoration Reward";
            public const int Decoration_Reward_sortIndex = 250;
            [SortOrder(Decoration_Reward_sortIndex)]
            [DisplayName(Decoration_Reward_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Decoration_Reward {
                get => Decoration_Reward_raw;
                set {
                    if (Decoration_Reward_raw == value) return;
                    Decoration_Reward_raw = value;
                    OnPropertyChanged(nameof(Decoration_Reward));
                    OnPropertyChanged(nameof(Decoration_Reward_button));
                }
            }

            [SortOrder(Decoration_Reward_sortIndex)]
            [DisplayName(Decoration_Reward_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Decoration_Reward_button => DataHelper.itemNames[MainWindow.locale].TryGet(Decoration_Reward).ToStringWithId(Decoration_Reward);

            protected uint Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 300;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual uint Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected uint Cost_raw;
            public const string Cost_displayName = "Cost";
            public const int Cost_sortIndex = 350;
            [SortOrder(Cost_sortIndex)]
            [DisplayName(Cost_displayName)]
            public virtual uint Cost {
                get => Cost_raw;
                set {
                    if (Cost_raw == value) return;
                    Cost_raw = value;
                    OnPropertyChanged(nameof(Cost));
                }
            }

            protected uint Item_1_Id_raw;
            public const string Item_1_Id_displayName = "Item 1 Id";
            public const int Item_1_Id_sortIndex = 400;
            [SortOrder(Item_1_Id_sortIndex)]
            [DisplayName(Item_1_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_1_Id {
                get => Item_1_Id_raw;
                set {
                    if (Item_1_Id_raw == value) return;
                    Item_1_Id_raw = value;
                    OnPropertyChanged(nameof(Item_1_Id));
                    OnPropertyChanged(nameof(Item_1_Id_button));
                }
            }

            [SortOrder(Item_1_Id_sortIndex)]
            [DisplayName(Item_1_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_1_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_1_Id).ToStringWithId(Item_1_Id);

            protected uint Item_1_Cnt_raw;
            public const string Item_1_Cnt_displayName = "Item 1 Cnt";
            public const int Item_1_Cnt_sortIndex = 450;
            [SortOrder(Item_1_Cnt_sortIndex)]
            [DisplayName(Item_1_Cnt_displayName)]
            public virtual uint Item_1_Cnt {
                get => Item_1_Cnt_raw;
                set {
                    if (Item_1_Cnt_raw == value) return;
                    Item_1_Cnt_raw = value;
                    OnPropertyChanged(nameof(Item_1_Cnt));
                }
            }

            protected uint Item_2_Id_raw;
            public const string Item_2_Id_displayName = "Item 2 Id";
            public const int Item_2_Id_sortIndex = 500;
            [SortOrder(Item_2_Id_sortIndex)]
            [DisplayName(Item_2_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_2_Id {
                get => Item_2_Id_raw;
                set {
                    if (Item_2_Id_raw == value) return;
                    Item_2_Id_raw = value;
                    OnPropertyChanged(nameof(Item_2_Id));
                    OnPropertyChanged(nameof(Item_2_Id_button));
                }
            }

            [SortOrder(Item_2_Id_sortIndex)]
            [DisplayName(Item_2_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_2_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_2_Id).ToStringWithId(Item_2_Id);

            protected uint Item_2_Cnt_raw;
            public const string Item_2_Cnt_displayName = "Item 2 Cnt";
            public const int Item_2_Cnt_sortIndex = 550;
            [SortOrder(Item_2_Cnt_sortIndex)]
            [DisplayName(Item_2_Cnt_displayName)]
            public virtual uint Item_2_Cnt {
                get => Item_2_Cnt_raw;
                set {
                    if (Item_2_Cnt_raw == value) return;
                    Item_2_Cnt_raw = value;
                    OnPropertyChanged(nameof(Item_2_Cnt));
                }
            }

            public const int lastSortIndex = 600;

            public static ObservableMhwStructCollection<Entries> LoadData(BinaryReader reader, ObservableMhwStructCollection<Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Entries>();
                var countTarget = (Header) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Entries LoadData(BinaryReader reader, ulong i) {
                var data = new Entries();
                data.Index = i;
                data.Id_raw = reader.ReadUInt32();
                data.Unk1_raw = reader.ReadUInt32();
                data.Unk2_raw = reader.ReadUInt32();
                data.Client_Id_raw = reader.ReadInt32();
                data.Decoration_Reward_raw = reader.ReadUInt32();
                data.Unk3_raw = reader.ReadUInt32();
                data.Cost_raw = reader.ReadUInt32();
                data.Item_1_Id_raw = reader.ReadUInt32();
                data.Item_1_Cnt_raw = reader.ReadUInt32();
                data.Item_2_Id_raw = reader.ReadUInt32();
                data.Item_2_Cnt_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Client_Id_raw);
                writer.Write(Decoration_Reward_raw);
                writer.Write(Unk3_raw);
                writer.Write(Cost_raw);
                writer.Write(Item_1_Id_raw);
                writer.Write(Item_1_Cnt_raw);
                writer.Write(Item_2_Id_raw);
                writer.Write(Item_2_Cnt_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer<Entries, Header>(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}