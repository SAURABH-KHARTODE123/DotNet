using OrderProcessing;

CRMHistory hist = new CRMHistory();

ICustomerDetails cust = (ICustomerDetails)hist;
cust.ShowDetails();

// ICustomerDetails cust = hist;
// IOrderDetails ord = hist;

// cust.ShowDetails();
// ord.ShowDetails();

