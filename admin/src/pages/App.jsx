import Slide from "../Components/Slide";
import "../styles/App.scss";

export default function App({ view }) {
  App.propTypes = {
    view,
  };

  return (
    <section>
      <Slide />
      {view}
    </section>
  );
}
