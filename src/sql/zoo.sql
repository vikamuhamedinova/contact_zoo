/*
Created: 09.03.2018
Modified: 13.03.2018
Model: SQLite 3.7
Database: SQLite 3.7
*/


-- Create tables section -------------------------------------------------

-- Table animal_spec

CREATE TABLE animal_spec
(
  id_animal_spec INTEGER NOT NULL
        CONSTRAINT Key2 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL,
  ration_type TEXT NOT NULL
);

-- Table animal

CREATE TABLE animal
(
  id_animal INTEGER NOT NULL
        CONSTRAINT Key1 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL,
  birth_year INTEGER NOT NULL,
  id_animal_spec INTEGER NOT NULL,
  photo TEXT,
  CONSTRAINT Relationship1 FOREIGN KEY (id_animal_spec) REFERENCES animal_spec (id_animal_spec)
);

CREATE INDEX IX_Relationship1 ON animal (id_animal_spec);

-- Table unit

CREATE TABLE unit
(
  id_unit INTEGER NOT NULL
        CONSTRAINT Key22 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Table food

CREATE TABLE food
(
  id_food INTEGER NOT NULL
        CONSTRAINT Key5 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Table food_set

CREATE TABLE food_set
(
  id_food_set INTEGER NOT NULL
        CONSTRAINT Key6 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Table employee

CREATE TABLE employee
(
  id_employee INTEGER NOT NULL
        CONSTRAINT Key7 PRIMARY KEY AUTOINCREMENT,
  fio TEXT NOT NULL,
  appointment TEXT NOT NULL,
  inn TEXT NOT NULL,
  passport_no TEXT NOT NULL,
  rate decimal(30, 2) NOT NULL
);

-- Table shift

CREATE TABLE shift
(
  id_shift INTEGER NOT NULL,
  time_start timestamp NOT NULL,
  time_end timestamp NOT NULL,
  id_employee INTEGER NOT NULL,
  CONSTRAINT Key8 PRIMARY KEY (id_shift,id_employee),
  CONSTRAINT Relationship15 FOREIGN KEY (id_employee) REFERENCES employee (id_employee)
);

-- Table food_distr

CREATE TABLE food_distr
(
  id_food_distr INTEGER NOT NULL
        CONSTRAINT Key4 PRIMARY KEY AUTOINCREMENT,
  date_time timestamp NOT NULL,
  id_animal INTEGER,
  id_food INTEGER NOT NULL,
  id_employee INTEGER NOT NULL,
  quantity NUMERIC NOT NULL,
  CONSTRAINT Relationship2 FOREIGN KEY (id_animal) REFERENCES animal (id_animal),
  CONSTRAINT Relationship3 FOREIGN KEY (id_food) REFERENCES food (id_food),
  CONSTRAINT Relationship4 FOREIGN KEY (id_employee) REFERENCES employee (id_employee)
);

CREATE INDEX IX_Relationship2 ON food_distr (id_animal);

CREATE INDEX IX_Relationship3 ON food_distr (id_food);

CREATE INDEX IX_Relationship4 ON food_distr (id_employee);

-- Table food_set_pos

CREATE TABLE food_set_pos
(
  id_food_set_pos INTEGER NOT NULL,
  id_food_set INTEGER NOT NULL,
  id_food INTEGER NOT NULL,
  quantity NUMERIC NOT NULL DEFAULT 0,
  CONSTRAINT Key10 PRIMARY KEY (id_food_set_pos,id_food_set),
  CONSTRAINT Relationship5 FOREIGN KEY (id_food_set) REFERENCES food_set (id_food_set),
  CONSTRAINT Relationship6 FOREIGN KEY (id_food) REFERENCES food (id_food)
);

CREATE INDEX IX_Relationship6 ON food_set_pos (id_food);

-- Table ticket_type

CREATE TABLE ticket_type
(
  id_ticket_type INTEGER NOT NULL
        CONSTRAINT Key16 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Table promo

CREATE TABLE promo
(
  id_promo INTEGER NOT NULL
        CONSTRAINT Key17 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL,
  discount NUMERIC NOT NULL DEFAULT 0.00,
  promo_start timestamp NOT NULL,
  promo_end timestamp NOT NULL
);

-- Table ticket

CREATE TABLE ticket
(
  id_ticket INTEGER NOT NULL
        CONSTRAINT Key15 PRIMARY KEY AUTOINCREMENT,
  ticket_no INTEGER NOT NULL,
  id_ticket_type INTEGER NOT NULL,
  id_promo INTEGER,
  CONSTRAINT Relationship8 FOREIGN KEY (id_ticket_type) REFERENCES ticket_type (id_ticket_type),
  CONSTRAINT Relationship9 FOREIGN KEY (id_promo) REFERENCES promo (id_promo)
);

CREATE INDEX IX_Relationship8 ON ticket (id_ticket_type);

CREATE INDEX IX_Relationship9 ON ticket (id_promo);

-- Table service

CREATE TABLE service
(
  id_service INTEGER NOT NULL
        CONSTRAINT Key14 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL,
  cost decimal(30, 2) NOT NULL DEFAULT 0.00
);

-- Table sale

CREATE TABLE sale
(
  id_sale INTEGER NOT NULL
        CONSTRAINT Key11 PRIMARY KEY AUTOINCREMENT,
  date_time timestamp NOT NULL
);

-- Table service_pos

CREATE TABLE service_pos
(
  id_service_pos INTEGER NOT NULL,
  id_sale INTEGER NOT NULL,
  id_service INTEGER NOT NULL,
  CONSTRAINT Key18 PRIMARY KEY (id_service_pos,id_sale),
  CONSTRAINT Relationship10 FOREIGN KEY (id_sale) REFERENCES sale (id_sale),
  CONSTRAINT Relationship11 FOREIGN KEY (id_service) REFERENCES service (id_service)
);

CREATE INDEX IX_Relationship11 ON service_pos (id_service);

-- Table consumable

CREATE TABLE consumable
(
  id_consumable INTEGER NOT NULL
        CONSTRAINT Key12 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL,
  price decimal(30, 2) NOT NULL,
  id_unit INTEGER NOT NULL,
  income NUMERIC NOT NULL,
  outcome NUMERIC NOT NULL,
  income_date timestamp NOT NULL,
  outcome_date timestamp NOT NULL,
  CONSTRAINT Relationship32 FOREIGN KEY (id_unit) REFERENCES unit (id_unit)
);

CREATE INDEX IX_Relationship32 ON consumable (id_unit);

-- Table purchase_pos_food

CREATE TABLE purchase_pos_food
(
  id_purchase_pos_food INTEGER NOT NULL
        CONSTRAINT Key21 PRIMARY KEY AUTOINCREMENT,
  quantity NUMERIC NOT NULL,
  id_food INTEGER NOT NULL,
  date_time timestamp NOT NULL,
  price decimal(30, 2) NOT NULL,
  id_unit INTEGER,
  CONSTRAINT Relationship19 FOREIGN KEY (id_food) REFERENCES food (id_food),
  CONSTRAINT Relationship38 FOREIGN KEY (id_unit) REFERENCES unit (id_unit)
);

CREATE INDEX IX_Relationship19 ON purchase_pos_food (id_food);

CREATE INDEX IX_Relationship38 ON purchase_pos_food (id_unit);

-- Table ticket_pos

CREATE TABLE ticket_pos
(
  id_ticket_pos INTEGER NOT NULL,
  id_ticket INTEGER NOT NULL,
  id_sale INTEGER NOT NULL,
  CONSTRAINT Key23 PRIMARY KEY (id_ticket_pos,id_sale),
  CONSTRAINT Relationship27 FOREIGN KEY (id_ticket) REFERENCES ticket (id_ticket),
  CONSTRAINT Relationship29 FOREIGN KEY (id_sale) REFERENCES sale (id_sale)
);

CREATE INDEX IX_Relationship27 ON ticket_pos (id_ticket);

-- Table ticket_type_price

CREATE TABLE ticket_type_price
(
  id_ticket_type_price INTEGER NOT NULL,
  price decimal(30, 2) NOT NULL,
  date_start date NOT NULL,
  id_ticket_type INTEGER NOT NULL,
  date_end date,
  CONSTRAINT Key24 PRIMARY KEY (id_ticket_type_price,id_ticket_type),
  CONSTRAINT Relationship33 FOREIGN KEY (id_ticket_type) REFERENCES ticket_type (id_ticket_type)
);

-- Table food_set_ready

CREATE TABLE food_set_ready
(
  id_food_set_ready INTEGER NOT NULL
        CONSTRAINT Key25 PRIMARY KEY AUTOINCREMENT,
  quantity NUMERIC NOT NULL,
  id_food_set INTEGER,
  price decimal(30, 2) NOT NULL,
  CONSTRAINT Relationship34 FOREIGN KEY (id_food_set) REFERENCES food_set (id_food_set)
);

CREATE INDEX IX_Relationship34 ON food_set_ready (id_food_set);

-- Table food_sale_pos

CREATE TABLE food_sale_pos
(
  id_food_sale_pos INTEGER NOT NULL,
  id_sale INTEGER NOT NULL,
  id_food_set_ready INTEGER NOT NULL,
  quantity NUMERIC NOT NULL,
  CONSTRAINT Key19 PRIMARY KEY (id_food_sale_pos,id_sale),
  CONSTRAINT Relationship13 FOREIGN KEY (id_sale) REFERENCES sale (id_sale),
  CONSTRAINT Relationship35 FOREIGN KEY (id_food_set_ready) REFERENCES food_set_ready (id_food_set_ready)
);

CREATE INDEX IX_Relationship35 ON food_sale_pos (id_food_set_ready);

