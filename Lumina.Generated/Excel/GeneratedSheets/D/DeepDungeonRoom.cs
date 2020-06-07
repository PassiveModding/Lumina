using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonRoom", columnHash: 0x6be0e840 )]
    public class DeepDungeonRoom : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint[] Level;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Level = new uint[5];
            Level[0] = parser.ReadOffset< uint >( 0x0 );
            Level[1] = parser.ReadOffset< uint >( 0x4 );
            Level[2] = parser.ReadOffset< uint >( 0x8 );
            Level[3] = parser.ReadOffset< uint >( 0xc );
            Level[4] = parser.ReadOffset< uint >( 0x10 );


        }
    }
}