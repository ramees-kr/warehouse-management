CREATE TABLE [products] (
  [id] int PRIMARY KEY,
  [gender] varchar(255),
  [masterCategory] varchar(255),
  [subCategory] varchar(255),
  [articleType] varchar(255),
  [baseColour] varchar(255),
  [season] varchar(255),
  [year] int,
  [usage] varchar(255),
  [productDisplayName] varchar(255),
  [weight] float,
  [price] decimal(18,0)
)
GO

CREATE TABLE [inventory] (
  [id] int PRIMARY KEY IDENTITY(1,1),
  [product_id] int,
  [size] varchar(255),
  [quantity_available] int
)
GO

CREATE TABLE [location] (
  [id] int PRIMARY KEY IDENTITY(1,1),
  [_aisle] int,
  [_row] int,
  [_column] int
)
GO

CREATE TABLE [orders] (
  [order_id] int PRIMARY KEY IDENTITY(1,1),
  [customer_id] int,
  [order_date] datetime,
  [status] varchar(255)
)
GO

CREATE TABLE [orderItems] (
  [order_item_id] int PRIMARY KEY IDENTITY(1,1),
  [order_id] int,
  [product_id] int,
  [size] varchar(255),
  [quantity_ordered] int
)
GO

CREATE TABLE [packedItems] (
  [packed_item_id] int PRIMARY KEY IDENTITY(1,1),
  [order_item_id] int,
  [quantity_packed] int
)
GO

CREATE TABLE [pickingQueue] (
  [picking_id] int PRIMARY KEY IDENTITY(1,1),
  [order_item_id] int,
  [quantity_to_pick] int
)
GO

CREATE TABLE [productLocation] (
  [id] int PRIMARY KEY IDENTITY(1,1),
  [location_id] int,
  [product_id] int
)
GO

ALTER TABLE [inventory] ADD FOREIGN KEY ([product_id]) REFERENCES [products] ([id])
GO

ALTER TABLE [orderItems] ADD FOREIGN KEY ([order_id]) REFERENCES [orders] ([order_id])
GO

ALTER TABLE [orderItems] ADD FOREIGN KEY ([product_id]) REFERENCES [products] ([id])
GO

ALTER TABLE [packedItems] ADD FOREIGN KEY ([order_item_id]) REFERENCES [orderItems] ([order_item_id])
GO

ALTER TABLE [pickingQueue] ADD FOREIGN KEY ([order_item_id]) REFERENCES [orderItems] ([order_item_id])
GO

ALTER TABLE [productLocation] ADD FOREIGN KEY ([location_id]) REFERENCES [location] ([id])
GO

ALTER TABLE [productLocation] ADD FOREIGN KEY ([product_id]) REFERENCES [products] ([id])
GO
