package org.FileCollection;

import java.util.ArrayList;
import java.util.List;

public class Collection {
    public String name;
    public int totalSize;
    private List<FileOperation> files;

    Collection(String n) {
        this.name = n;
        this.totalSize = 0;
        files = new ArrayList<FileOperation>();
    }

    public void addFile(FileOperation file){
        files.add(file);
        this.totalSize = this.totalSize + file.getSize();
    }
}
