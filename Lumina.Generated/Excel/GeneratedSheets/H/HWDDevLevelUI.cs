using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDDevLevelUI", columnHash: 0xd73eab80 )]
    public class HWDDevLevelUI : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public ushort unknown0;

        // col: 00 offset: 0002
        public byte unknown2;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 0 offset: 0002
            unknown2 = parser.ReadOffset< byte >( 0x2 );


        }
    }
}