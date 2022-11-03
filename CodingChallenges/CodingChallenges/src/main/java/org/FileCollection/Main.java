package org.FileCollection;

public class Main {
    public static void main(String[] args) {
        FileUtility  utility = new FileUtility();
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