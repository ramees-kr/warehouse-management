BULK INSERT Products
From "D:\Projects\warehouse-sorting\creating-datasets\[Products]\updated_fashion_items.csv"
WITH (
    FIELDTERMINATOR = ',',  -- Specify the field delimiter in the CSV file
    ROWTERMINATOR = '\n',    -- Specify the row terminator in the CSV file
    FIRSTROW = 2             -- Skip the header row if present
);