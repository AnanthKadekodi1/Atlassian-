import org.FileCollection.FileUtility;
import org.junit.Before;
import org.junit.Test;

public class FileCollectionTest {

    private FileUtility utility;

    @Before
    public void setUp() {

        utility = new FileUtility();
    }

    @Test
    public void testFileCollection(){

        utility.saveFiletoCollection("collection1",200);
        utility.saveFiletoCollection("collection2",200);
        utility.saveFiletoCollection(null,200);

        utility.saveFiletoCollection("collection3",200);
        utility.saveFiletoCollection("collection3",200);
        utility.saveFiletoCollection("collection3",200);
        utility.saveFiletoCollection("collection2",100);
        utility.getTotalSize();
        utility.getTop(3);
    }


}
