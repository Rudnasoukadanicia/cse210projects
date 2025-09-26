# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

W04 : Foundation program design

Program 1 : Abstraction with Youtube Videos

Objective :

This program stores information about Youtube videos , including the title , autor, duration and comments attached to them. It displays information about each video and allows the user to view all comments.

Classes and their responsibilities:

Video: Stores the title, author, duration, and list of comments. Displays video information and counts comments.

Comment: Stores the author and comment text. Displays the comment.

Attributes and Methods:

For video (Attributes):

_title: string
_author: string
_length: int
_comments: List<Comment>

For video (Methods):

DisplayVideoInfo()
GetCommentCount()
DisplayAllComments()

For Comment(Attributes):

_author: string
_text: string

For Comment(Methods):

DisplayComment()

The program flow is to create a list of video objects for each video and add multyiple comments.

Program 2 : Encapsulation with Online Ordering

Objective :

This program simulates an online order. It stores customer and product data, calculates the total cost, including shipping, and displays the packaging and shipping labels.

Classes and their responsibilities:

Order: Store customer and product list. Calculates the total price and prints the labels.

Product: Store name, product ID, price, quantity, and returns the total price per product.

Customer: Store name and address. Determines if the customer resides in the United States.

Address: Store street, city, state, and country. Returns the full address.
Attributes and Methods

For Order (Attributes):

_customer : Customer
_products: List<Product>

For Order (Methods):

GetTotalPrice()
GetPackingLabel()
GetShippingLabel()

For Product (Attributes):

_name: string
_id: string
_price : float
_quantity : integer

For Product (Methods):

GetTotalPrice()
GetProductInfo()

For Customer (Attributes):

_name: sting
_adress: Address

For Customer (Methods):

LivesInUsa()

For Address (Attributes):

_street: string
_city: string
_state: string
_contry: string

For Address (Methods):

GetFullAddress()

The program flow is to create a Customer object with an address. Also create several Product objects and add them to an order.
