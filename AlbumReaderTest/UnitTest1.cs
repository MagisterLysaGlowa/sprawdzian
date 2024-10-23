using konsola;

namespace AlbumReaderTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReadFile_ThenMatchAndAddToList_ReturnListOfAlbums()
        {
            //Arrange
            string testedFilePath = "../../../testedFile.txt";
            File.WriteAllLines(testedFilePath, new[]
            {
                "Artist 1",
                "\"Album 1\"",
                "14",
                "2024",
                "123456",
                "",
                "Artist 2",
                "\"Album 2\"",
                "13",
                "2023",
                "654321",
            });
            //Act
            var albums = konsola.Program.ReadAlbums(testedFilePath);
            //Assert
            Assert.Equal(2, albums.Count);
            Assert.Equal("Artist 1", albums[0].Artist);
            Assert.Equal("\"Album 1\"", albums[0].Album);
            Assert.Equal(14u, albums[0].SongsNumber);
            Assert.Equal(2024, albums[0].YearOfEdition);
            Assert.Equal(123456u, albums[0].DownloadNumber);

            Assert.Equal("Artist 2", albums[1].Artist);
            Assert.Equal("\"Album 2\"", albums[1].Album);
            Assert.Equal(13u, albums[1].SongsNumber);
            Assert.Equal(2023, albums[1].YearOfEdition);
            Assert.Equal(654321u, albums[1].DownloadNumber);
        }
    }
}