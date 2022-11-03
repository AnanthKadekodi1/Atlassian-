/*global using NUnit.Framework;

Atlassian hints - */ http://webcache.googleusercontent.com/search?q=cache:HWtUoXgoprEJ:https://leetcode.com/discuss/interview-question/object-oriented-design/1583096/API-Rate-limiter-or-LLD-(Common-Atlassian-question)/1164211&hl=en&gl=au&strip=1&vwsrc=0

https://leetcode.com/discuss/interview-question/1645336/atlassian-onsite-backend-se-winter-2021

https://leetcode.com/discuss/interview-experience/1102488/atlassian-software-development-engineer-ii-bengaluru-25-yoe-reject

http://webcache.googleusercontent.com/search?q=cache:eSEr51txkZoJ:https://leetcode.com/discuss/interview-question/system-design/1616482/System-Design%253A-Rate-Limiter&hl=en&gl=au&strip=1&vwsrc=0

https://www.scribd.com/document/573023480/Atlassian-LeetCode

https://leetcode.com/problems/online-election/

https://github.com/hahalulu/import-leetcode-company-wise-problems-2022/blob/main/companies/Atlassian.csv

https://leetcode.com/discuss/interview-experience/1504593/atlassian-sde-2-p4-september-2021-bangalore-offer

import java.util.Scanner;
import java.util.Collections;
import java.util.*;
class FileSystem
{

    Map<String, FileSystemAttributes> directoryDetailsMap;
    PriorityQueue<Directory> directoryHeap;
    HashSet<Directory> isDirectoryPresentInHeap;

    int allFileSize;

    public FileSystem()
    {
        directoryDetailsMap = new HashMap<>();
        directoryHeap = new PriorityQueue<Directory>((a, b)->b.size - a.size);
        isDirectoryPresentInHeap = new HashSet<>();
        this.allFileSize = 0;
    }

    public int getSizeOfAllFiles()
    {
        return this.allFileSize;
    }

    public List<Directory> getNCollection(int n)
    {

        if (directoryHeap.size() < n)
            return new ArrayList<>();

        List<Directory> output = new ArrayList<>();
        PriorityQueue<Directory> tempDirectoryHeap = new PriorityQueue<Directory>((a, b)->b.size - a.size);

        for (int i = 0; i < n; i++)
        {
            Directory d = directoryHeap.poll();
            output.add(d);
            tempDirectoryHeap.add(d);
        }

        for (int i = 0; i < n; i++)
            directoryHeap.add(tempDirectoryHeap.poll());

        return output;
    }

    public void addFileToDirectory(String fileName, int size, String dName)
    {
        File file;
        if (dName.equals(""))
        {
            file = new File(fileName, size);
            directoryDetailsMap.put(fileName, file);
        }
        else
        {
            Directory d = (Directory)directoryDetailsMap.getOrDefault(dName, new Directory(dName));
            file = new File(d, fileName, size);

            d.size += size;
            d.files.add(file);

            if (!isDirectoryPresentInHeap.contains(d))
            {
                directoryHeap.add(d);
                isDirectoryPresentInHeap.add(d);
            }

            directoryDetailsMap.put(dName, d);
        }

        allFileSize += size;
    }
}

interface FileSystemAttributes { }

class Directory implements FileSystemAttributes
{

    String name;
    List<File> files;
    int size;


    public Directory (String name)
{
    this.name = name;
    files = new ArrayList<>();
    this.size = 0;
}
}

class File implements FileSystemAttributes
{

    Directory directory;
    String name;
    int size;

    public File(Directory d, String n, int size)
{
    this.directory = d;
    this.name = n;
    this.size = size;
}

public File(String n, int size)
{
    this.name = n;
    this.size = size;
}    
}

public class Main
{

    public static void main(String args[])
    {

        FileSystem fileSystem = new FileSystem();

        fileSystem.addFileToDirectory("file1.txt", 100, "");
        fileSystem.addFileToDirectory("file2.txt", 100, "collection1");
        fileSystem.addFileToDirectory("file3.txt", 200, "collection1");
        fileSystem.addFileToDirectory("file4.txt", 300, "collection3");
        fileSystem.addFileToDirectory("file5.txt", 400, "collection4");

        System.out.println(fileSystem.getSizeOfAllFiles());
        List<Directory> topNCollections = fileSystem.getNCollection(2);

        for (Directory collection: topNCollections)
            System.out.println(collection.name + " " + collection.size + " ");
    }
}

https://github.com/krishnadey30/LeetCode-Questions-CompanyWise/blob/master/atlassian_alltime.csv