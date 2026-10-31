using UnityEngine;

[System.Serializable]
public class QuadTreeNode
{
    public Rect bounds;
    public GameObject terrain;

    public QuadTreeNode[] children;
    bool isDivided = false;
    public bool IsDivided
    {
        get { return isDivided; }
    }

    public bool IsLeaf
    {
        get
        {
            return children == null;
        }
    }

    public QuadTreeNode(Rect _bounds)
    {
        this.bounds = _bounds;
    }

    public void Subdivide()
    {
        float w = bounds.width / 2;
        float h = bounds.height / 2;

        children = new QuadTreeNode[4];

        children[0] = new QuadTreeNode(new Rect(bounds.x,       bounds.y,           w, h));
        children[1] = new QuadTreeNode(new Rect(bounds.x + w,   bounds.y,           w, h));
        children[2] = new QuadTreeNode(new Rect(bounds.x,       bounds.y + h,       w, h));
        children[3] = new QuadTreeNode(new Rect(bounds.x + w,   bounds.y + h,       w, h));

        isDivided = true;
    }
}
