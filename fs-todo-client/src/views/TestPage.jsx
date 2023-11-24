import { Link } from "react-router-dom";

function TestPage() {


    return (
      <>
        <h1>This is the test page</h1>
        <h2>I am learning about react router!</h2>

        <br></br>
        <br></br>

        <Link to="/">go to home page</Link>
 
        <br></br>
        <br></br>

        <Link to="/testpage/moretesting">go to moretesting</Link>

      </>
    )
  }
  
  export default TestPage 
  