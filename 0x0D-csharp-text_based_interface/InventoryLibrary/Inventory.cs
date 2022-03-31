using System;

class Inventory : BaseClass
{
    private string user_id = "User id";

    public string User_id
    {
        get { return this.user_id; }
        set
        {
            User user = new User();

            this.user_id = user.id;
        }
    }

    private string item_id = "Item id";

    public string Item_id
    {
        get { return this.item_id; }
        set
        {
            Item item = new Item();

            this.item_id = item.id;
        }
    }

    private int quantity = 1;

    public int Quantity
    {
        get
        {
            if (this.quantity < 0)
                this.quantity = 1;

            return this.quantity;
        }
        set
        {
            if (this.quantity < 0)
                value = 1;

            this.quantity = value;
        }
    }
}
