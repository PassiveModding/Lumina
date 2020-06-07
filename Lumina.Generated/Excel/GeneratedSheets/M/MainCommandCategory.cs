using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MainCommandCategory", columnHash: 0x0c8db36c )]
    public class MainCommandCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public int unknown4;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< int >( 0x4 );


        }
    }
}