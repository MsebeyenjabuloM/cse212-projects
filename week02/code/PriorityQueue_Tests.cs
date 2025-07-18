using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and then dequeue.
    // Expected Result: Item with highest priority should be dequeued first.
    // Defect(s) Found: Initially, the dequeue didn’t always return the highest priority item.
    public void TestPriorityQueue_DequeueBasic()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        Assert.AreEqual("High", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with same highest priority. Should dequeue the one added first
    // Expected Result: FIFO order implemented among equal-priority items.
    // Defect(s) Found: It removed the wrong one (not the first added).
    public void TestPriorityQueue_DequeueEqualPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 5);

        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected Result: Throws exception.
    // Defect(s) Found: No exception or wrong error message.
    public void TestPriorityQueue_EmptyQueue()
    {
        var pq = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            pq.Dequeue();
        });
    }
    
    /// <summary>
    /// Test: Items are added to the back regardless of priority
    /// Verifies ToString returns them in insertion order
    /// </summary>
    [TestMethod]
    public void TestPriorityQueue_EnqueuingAtBack()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("1", 1);
        pq.Enqueue("2", 2);
        pq.Enqueue("3", 3);
        pq.Enqueue("0", 0);

        string expected = "[1 (Pri:1), 2 (Pri:2), 3 (Pri:3), 0 (Pri:0)]";
        Assert.AreEqual(expected, pq.ToString());
    }

    /// <summary>
    /// Test: Highest priority at the front is dequeued first
    /// </summary>
    [TestMethod]
    public void TestPriorityQueue_DequeueHighestPriorityAtFront()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("High", 10);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("Low", 1);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Medium", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
    }

    /// <summary>
    /// Test: Highest priority item in the middle is dequeued first
    /// </summary>
    [TestMethod]
    public void TestPriorityQueue_DequeueHighestPriorityAtMiddle()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 10);
        pq.Enqueue("Medium", 5);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Medium", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
    }

    /// <summary>
    /// Test: Highest priority at the back is dequeued first
    /// </summary>
    [TestMethod]
    public void TestPriorityQueue_DequeueHighestPriorityAtBack()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Medium", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
    }

}