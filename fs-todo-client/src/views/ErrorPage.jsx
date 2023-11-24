import { Link } from "react-router-dom";

const ErrorPage = () => {
  return (
    <div>
      <h1>This page does not exist</h1>

      <br></br>

      <Link to="/">
        go back to home
      </Link> 
    </div>
  );
};

export default ErrorPage;