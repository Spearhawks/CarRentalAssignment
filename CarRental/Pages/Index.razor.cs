namespace CarRental.Pages;

partial class Index
{
    ///  <summary>
    /// Uses "state" to show the list corresponding to the current "state".
    /// </summary>
    string state = "vehicles";
    void ShowVehicles() => state = "vehicles";
    void ShowBookings() => state = "bookings";
    void ShowCustomers() => state = "customers";
}
