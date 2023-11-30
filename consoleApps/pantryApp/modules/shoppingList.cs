using System;
using System.Collections.Generic;

namespace Shopping
{
class List {
    private List<string> foodItems;

    public List() {
        foodItems = new List<string>();
    }

    public void AddFoodItem(string foodItem) {
        foodItems.Add(foodItem);
    }

    public void RemoveFoodItem(string foodItem) {
        foodItems.Remove(foodItem);
    }

    public List<string> GetFoodItems() {
        return foodItems;
    }
}

}