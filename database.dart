/// Author: Tristan 

/// Date: 10/30/2024

class DataProvider with ChangeNotifier {
  List<Item> _items = [];
  bool _isLoading = false;

  List<Item> get items => _items;
  bool get isLoading => _isLoading;

  Future<void> fetchItems() async {
    _isLoading = true;
    notifyListeners();

    try {
      final response = await http.get(Uri.parse('your-api-endpoint'));
      final data = json.decode(response.body) as List;
      _items = data.map((item) => Item.fromJson(item)).toList();
    } catch (error) {
      print(error);
    } finally {
      _isLoading = false;
      notifyListeners();
    }
  }
}
