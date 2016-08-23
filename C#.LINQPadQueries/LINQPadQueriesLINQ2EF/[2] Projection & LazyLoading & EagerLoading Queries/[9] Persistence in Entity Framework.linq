<Query Kind="Statements" />

//Now let’s see how we can persist an entity so that 
//it either inserts new row or updates an existing 
//row or delete an existing row in the database.
//
//We will see persisting an entity in two scenarios, 
//connected scenario and disconnected scenario.
//
//Connected Scenario:Connected scenario is when an entity 
//is retrieved from the database and modified in the same context.

//Disconnected Scenario:Disconnected scenario is when an entity is 
//retrieved from the database and modified in the different context. 
//Disconnected scenario is complex because context doesn’t know 
//anything about modified entity so you have to tell to
//ObjectContext that what has changed in entity.