using System;

public class Node
{
    public char File { get; set; }
    public int Rank { get; set; }
    public Node Top { get; set; }
    public Node Bottom { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(char file, int rank)
    {
        File = file;
        Rank = rank;
    }

    public void InsertTop(Node node)
    {
        if (node == null) return;
        this.Top = node;
        node.Bottom = this;
    }

    public void InsertBottom(Node node)
    {
        if (node == null) return;
        this.Bottom = node;
        node.Top = this;
    }

    public void InsertLeft(Node node)
    {
        if (node == null) return;
        this.Left = node;
        node.Right = this;
    }

    public void InsertRight(Node node)
    {
        if (node == null) return;
        this.Right = node;
        node.Left = this;
    }

    public string GetPosition()
    {
        return $"{File}{Rank}";
    }

    public override string ToString()
    {
        return $"Node {GetPosition()}";
    }
}

public class Program
{
    public static void Main()
    {

        Node a1 = new Node('A', 1);
        Node a2 = new Node('A', 2);
        Node a3 = new Node('A', 3);
        Node a4 = new Node('A', 4);
        Node a5 = new Node('A', 5);
        Node a6 = new Node('A', 6);
        Node a7 = new Node('A', 7);
        Node b1 = new Node('B', 1);
        Node b2 = new Node('B', 2);
        Node b3 = new Node('B', 3);
        Node b4 = new Node('B', 4);
        Node b5 = new Node('B', 5);
        Node b6 = new Node('B', 6);
        Node b7 = new Node('B', 7);
        Node c1 = new Node('C', 1);
        Node c2 = new Node('C', 2);
        Node c3 = new Node('C', 3);
        Node c4 = new Node('C', 4);
        Node c5 = new Node('C', 5);
        Node c6 = new Node('C', 6);
        Node c7 = new Node('C', 7);

        a1.InsertRight(a2);
        a2.InsertRight(a3);
        a3.InsertRight(a4);
        a4.InsertRight(a5);
        a5.InsertRight(a6);
        a6.InsertRight(a7);

        a7.InsertLeft(a6);
        a6.InsertLeft(a5);
        a5.InsertLeft(a4);
        a4.InsertLeft(a3);
        a3.InsertLeft(a2);
        a2.InsertLeft(a1);

        b1.InsertRight(b2);
        b2.InsertRight(b3);
        b3.InsertRight(b4);
        b4.InsertRight(b5);
        b5.InsertRight(b6);
        b6.InsertRight(b7);

        b7.InsertLeft(b6);
        b6.InsertLeft(b5);
        b5.InsertLeft(b4);
        b4.InsertLeft(b3);
        b3.InsertLeft(b2);
        b2.InsertLeft(b1);

        c1.InsertRight(c2);
        c2.InsertRight(c3);
        c3.InsertRight(c4);
        c4.InsertRight(c5);
        c5.InsertRight(c6);
        c6.InsertRight(c7);

        c7.InsertLeft(c6);
        c6.InsertLeft(c5);
        c5.InsertLeft(c4);
        c4.InsertLeft(c3);
        c3.InsertLeft(c2);
        c2.InsertLeft(c1);
        
        a1.InsertTop(b1);
        b1.InsertTop(c1);
        a2.InsertTop(b2);
        b2.InsertTop(c2);
        a3.InsertTop(b3);
        b3.InsertTop(c3);
        a4.InsertTop(b4);
        b4.InsertTop(c4);
        a5.InsertTop(b5);
        b5.InsertTop(c5);
        a6.InsertTop(b6);
        b6.InsertTop(c6);
        a7.InsertTop(b7);
        b7.InsertTop(c7);

        c1.InsertBottom(b1);
        b1.InsertBottom(a1);
        c2.InsertBottom(b2);
        b2.InsertBottom(a2);
        c3.InsertBottom(b3);
        b3.InsertBottom(a3);
        c4.InsertBottom(b4);
        b4.InsertBottom(a4);
        c5.InsertBottom(b5);
        b5.InsertBottom(a5);
        c6.InsertBottom(b6);
        b6.InsertBottom(a6);
        c7.InsertBottom(b7);
        b7.InsertBottom(a7);



        Console.WriteLine($"{a1.GetPosition()} is linked to:");
        if (a1.Top != null) Console.WriteLine($"  Top: {a1.Top.GetPosition()}");
        if (a1.Right != null) Console.WriteLine($"  Right: {a1.Right.GetPosition()}");
    }
}