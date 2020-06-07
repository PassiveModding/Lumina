using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalkDynamicIcon", columnHash: 0x5d58cc84 )]
    public class CustomTalkDynamicIcon : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint SmallIcon;

        // col: 01 offset: 0004
        public uint LargeIcon;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            SmallIcon = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            LargeIcon = parser.ReadOffset< uint >( 0x4 );


        }
    }
}