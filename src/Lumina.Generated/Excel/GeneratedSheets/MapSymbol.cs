using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapSymbol", columnHash: 0xe7e370e4 )]
    public class MapSymbol : IExcelRow
    {
        
        public int Icon;
        public LazyRow< PlaceName > PlaceName;
        public bool DisplayNavi;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = parser.ReadColumn< int >( 0 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 1 ), language );
            DisplayNavi = parser.ReadColumn< bool >( 2 );
        }
    }
}