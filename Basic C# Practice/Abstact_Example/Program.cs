using Abstact_Example;

TimeBasedWorker timeBasedWorker = new TimeBasedWorker();
timeBasedWorker.Name = "Trump";
timeBasedWorker.ContactNo = "099";
timeBasedWorker.AmountPerHour = 20;
timeBasedWorker.WorkedHour = 6;

Console.WriteLine(timeBasedWorker.GetTotalWage());


PieceBasedWorker pieceBasedWorker = new PieceBasedWorker();
pieceBasedWorker.Name = "Biden";
pieceBasedWorker.ContactNo = "098";
pieceBasedWorker.AmountPerPiece = 0.5;
pieceBasedWorker.NoOfPiecedsProduced = 400;

Console.WriteLine(pieceBasedWorker.GetTotalWage());

PieceBasedWorker pieceBasedWorker2 = new PieceBasedWorker();
pieceBasedWorker2.Name = "Putin";
pieceBasedWorker2.ContactNo = "098";
pieceBasedWorker2.AmountPerPiece = 0.5;
pieceBasedWorker2.NoOfPiecedsProduced = 550;

Console.WriteLine(pieceBasedWorker2.GetTotalWage());