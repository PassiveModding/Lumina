using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceStatus", columnHash: 0xf8ab135e )]
    public class ChocoboRaceStatus : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Status;

        // col: 01 offset: 0004
        public ushort unknown4;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Status = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}