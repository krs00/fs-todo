import { Link } from "react-router-dom";

function App() {

  return (
    <>
      <h1>Home Page</h1>
      <h2>This is the home page for my simple todo app, hope you enjoy.</h2>
      <p>This app was made for learning purposes</p>

      <br></br>

      <Link to="add-page">Add a to-do!</Link>

      <br></br>
      <br></br>

      <Link to="delete-page">Delete a to-do!</Link>

      <br></br>
      <br></br>

      <Link to="edit-page">Edit a to-do!</Link>

      <br></br>
      <br></br>

      <Link to="list-page">View all to-dos!</Link>



    </>
  )
}

export default App
