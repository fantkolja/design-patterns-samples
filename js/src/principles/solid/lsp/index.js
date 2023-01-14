class Database {
  joinTables(table1, table2) {
    console.log('Joining', table1, table2);
  }
}

class SQLDatabase extends Database {}

class MongoDatabase extends Database {
  mergeTables(table1, table2) {
    console.log('Merging', table1, table2);
  }

  // joinTables(table1, table2) {
  //   super.joinTables(table1, table2);
  //   throw new Error('Not permitted!');
  // }
}



function joinTables(db, table1, table2) {
  db.joinTables(table1, table2);
}

function main() {
  // const sqlDB = new SQLDatabase();
  // joinTables(sqlDB, '1', '2');

  const mongoDB = new MongoDatabase();
  joinTables(mongoDB, '1', '2');
}

main();