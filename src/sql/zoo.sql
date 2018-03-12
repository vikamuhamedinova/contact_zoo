/*
Created: 09.03.2018
Modified: 12.03.2018
Model: SQLite 3.7
Database: SQLite 3.7
*/


-- Create tables section -------------------------------------------------

-- Table animal_spec

CREATE TABLE animal_spec
(
  id_animal_spec INTEGER NOT NULL
        CONSTRAINT Key2 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Table animal

CREATE TABLE animal
(
  id_animal INTEGER NOT NULL
        CONSTRAINT Key1 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL,
  birth_year INTEGER NOT NULL,
  ration TEXT NOT NULL,
  id_animal_spec INTEGER NOT NULL,
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
  price decimal(30, 2) NOT NULL
);

-- Table employee

CREATE TABLE employee
(
  id_employee INTEGER NOT NULL
        CONSTRAINT Key7 PRIMARY KEY AUTOINCREMENT,
  fio TEXT NOT NULL,
  appointment TEXT NOT NULL,
  inn TEXT NOT NULL,
  passport_no TEXT NOT NULL
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

-- Table salary

CREATE TABLE salary
(
  id_salary INTEGER NOT NULL,
  rate NUMERIC NOT NULL,
  id_employee INTEGER NOT NULL,
  CONSTRAINT Key9 PRIMARY KEY (id_salary,id_employee),
  CONSTRAINT Relationship20 FOREIGN KEY (id_employee) REFERENCES employee (id_employee)
);

-- Table food_distr

CREATE TABLE food_distr
(
  id_food_distr INTEGER NOT NULL
        CONSTRAINT Key4 PRIMARY KEY AUTOINCREMENT,
  date_time timestamp NOT NULL,
  id_animal INTEGER NOT NULL,
  id_food INTEGER NOT NULL,
  id_employee INTEGER NOT NULL,
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
  id_unit INTEGER,
  CONSTRAINT Key10 PRIMARY KEY (id_food_set_pos,id_food_set),
  CONSTRAINT Relationship5 FOREIGN KEY (id_food_set) REFERENCES food_set (id_food_set),
  CONSTRAINT Relationship6 FOREIGN KEY (id_food) REFERENCES food (id_food),
  CONSTRAINT Relationship26 FOREIGN KEY (id_unit) REFERENCES unit (id_unit)
);

CREATE INDEX IX_Relationship6 ON food_set_pos (id_food);

CREATE INDEX IX_Relationship26 ON food_set_pos (id_unit);

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
  discount NUMERIC NOT NULL DEFAULT 0.00
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
  date_time timestamp NOT NULL,
  id_ticket INTEGER NOT NULL,
  CONSTRAINT Relationship12 FOREIGN KEY (id_ticket) REFERENCES ticket (id_ticket)
);

CREATE INDEX IX_Relationship12 ON sale (id_ticket);

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

-- Table food_sale_pos

CREATE TABLE food_sale_pos
(
  id_food_sale_pos INTEGER NOT NULL,
  id_sale INTEGER NOT NULL,
  id_food_set INTEGER NOT NULL,
  CONSTRAINT Key19 PRIMARY KEY (id_food_sale_pos,id_sale),
  CONSTRAINT Relationship13 FOREIGN KEY (id_sale) REFERENCES sale (id_sale),
  CONSTRAINT Relationship14 FOREIGN KEY (id_food_set) REFERENCES food_set (id_food_set)
);

CREATE INDEX IX_Relationship14 ON food_sale_pos (id_food_set);

-- Table consumable

CREATE TABLE consumable
(
  id_consumable INTEGER NOT NULL
        CONSTRAINT Key12 PRIMARY KEY AUTOINCREMENT,
  name TEXT NOT NULL
);

-- Table purchase

CREATE TABLE purchase
(
  id_purchase INTEGER NOT NULL
        CONSTRAINT Key13 PRIMARY KEY AUTOINCREMENT,
  purchase_date date NOT NULL
);

-- Table purchase_pos_cons

CREATE TABLE purchase_pos_cons
(
  id_purchase_pos_cons INTEGER NOT NULL,
  id_purchase INTEGER NOT NULL,
  quantity NUMERIC NOT NULL,
  id_consumable INTEGER NOT NULL,
  id_unit INTEGER NOT NULL,
  CONSTRAINT Key20 PRIMARY KEY (id_purchase_pos_cons,id_purchase),
  CONSTRAINT Relationship16 FOREIGN KEY (id_purchase) REFERENCES purchase (id_purchase),
  CONSTRAINT Relationship17 FOREIGN KEY (id_consumable) REFERENCES consumable (id_consumable),
  CONSTRAINT Relationship24 FOREIGN KEY (id_unit) REFERENCES unit (id_unit)
);

CREATE INDEX IX_Relationship17 ON purchase_pos_cons (id_consumable);

CREATE INDEX IX_Relationship24 ON purchase_pos_cons (id_unit);

-- Table purchase_pos_food

CREATE TABLE purchase_pos_food
(
  id_purchase_pos_food INTEGER NOT NULL,
  quantity NUMERIC NOT NULL,
  id_purchase INTEGER NOT NULL,
  id_food INTEGER NOT NULL,
  id_unit INTEGER NOT NULL,
  CONSTRAINT Key21 PRIMARY KEY (id_purchase_pos_food,id_purchase),
  CONSTRAINT Relationship18 FOREIGN KEY (id_purchase) REFERENCES purchase (id_purchase),
  CONSTRAINT Relationship19 FOREIGN KEY (id_food) REFERENCES food (id_food),
  CONSTRAINT Relationship25 FOREIGN KEY (id_unit) REFERENCES unit (id_unit)
);

CREATE INDEX IX_Relationship19 ON purchase_pos_food (id_food);

CREATE INDEX IX_Relationship25 ON purchase_pos_food (id_unit);

